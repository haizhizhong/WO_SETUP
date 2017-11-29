using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WO_Setup
{
    public partial class frmLoadBurdens : DevExpress.XtraEditors.XtraForm
    {
        #region Local Variables

        private HMConnection.HMCon ReflexCon;
         private WS_Popups.frmPopup Popups;
        private TUC_GridG.GridG GGBurden;

        private int iPri_ID;

        #endregion Local Variables

        #region Properties

        private TUC_HMDevXManager.TUC_HMDevXManager dxStyle;
        public TUC_HMDevXManager.TUC_HMDevXManager Style
        {
            get { return dxStyle; }
            set { dxStyle = value; }
        }

        #endregion Properties

        public frmLoadBurdens(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, int piPri_ID)
        {
            InitializeComponent();
            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            iPri_ID = piPri_ID;
            sqlConnTR.ConnectionString = ReflexCon.TRConnection;
            GGBurden = new TUC_GridG.GridG(ReflexCon.CompanyServer, ReflexCon.TRDB, gvSelectableBurdens, daBurdenSelection, dsBurdenSelection1);
            Popups = new WS_Popups.frmPopup(dxStyle);
            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void LoadSelectedBurdens()
        {
            //
        }

        private void frmLoadBurdens_Load(object sender, EventArgs e)
        {
            
            dsBurdenSelection_ProjWO1.WO_LoadSelectedBurdens_ByProjectWO.SelectedColumn.ReadOnly = false;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            UpdateSelection("T");
        }


        private void UpdateSelection (string sSelect)
        {
            string sqlStr = "update working_burden_type set selected ='" + sSelect + "' where username = '" + ReflexCon.MLUser + "'";
            ReflexCon.SQLExecutor.ExecuteNonQuery(sqlStr, ReflexCon.TRConnection);
            daBurdenSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
            daBurdenSelection.Fill(dsBurdenSelection1);
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            UpdateSelection("F");
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            string sqlstr = "select count(id) from working_burden_type where selected = 'T' and username = '" + ReflexCon.MLUser + "'";
            int count = Convert.ToInt32(ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection));
            if (count == 0)
            {
                if (Popups.ShowPopup("Are you sure you wish to select no burdens?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                else
                    return;
            }
            else
            {
                sqlstr = " insert costing_burdens ( pri_id, burden_type_id, calc_type, reg_rate, ot_rate, dt_rate, gl_account, IsCeiling) " +
                        " select " + iPri_ID.ToString() + ", burden_type_id ,calc_type, reg_rate, ot_rate, dt_rate, gl_account, IsCeiling from working_burden_type where selected ='T' and username = '" + ReflexCon.MLUser + "'"; ;
                ReflexCon.SQLExecutor.ExecuteNonQuery(sqlstr, ReflexCon.TRConnection);
                if (ReflexCon.SQLExecutor.Exception != null)
                {
                    Popups.ShowPopup("Unable to add burdens: " + ReflexCon.SQLExecutor.Exception.Message);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

      

        private void btnOK_Type_Click(object sender, EventArgs e)
        {
            string sqlstr ="";
            if (rgType.SelectedIndex == 0)  // by project
            {
                tcMain.SelectedTabPage = tpByProject;
                string is_wo = "F";
                sqlstr = "select isnull(is_wo,'') from proj_header where pri_id = " + iPri_ID.ToString();
                object oIS_WO = ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection);
                if (oIS_WO != null && oIS_WO != DBNull.Value)
                    is_wo = oIS_WO.ToString();
                dsProjWO1.Clear();
                daProjWO.SelectCommand.Parameters["@is_wo"].Value = is_wo;
                daProjWO.Fill(dsProjWO1);
                
            }
            else if (rgType.SelectedIndex == 1)
            {
                            
                sqlstr = "exec WO_LoadSelectedBurdens " + iPri_ID.ToString() + ",'S','" + ReflexCon.MLUser + "'";
                ReflexCon.SQLExecutor.ExecuteNonQuery(sqlstr, ReflexCon.TRConnection);

                sqlstr = "select count(id) from working_burden_type where username = '" + ReflexCon.MLUser + "'";
                int count = Convert.ToInt32(ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection));
                if (count == 0)
                {
                    Popups.ShowPopup(" No burden is loaded.");
                    return;
                }
               
                tcMain.SelectedTabPage = tpBySetup;
                dsBurdenSelection1.Clear();
                daBurdenSelection.SelectCommand.Parameters["@username"].Value = ReflexCon.MLUser;
                daBurdenSelection.Fill(dsBurdenSelection1);
               
            }

        }


        private void LoadSelectionBurdenByProjWO(int pri_id, int pri_id_sel)
        {
            dsBurdenSelection_ProjWO1.Clear();
            daBurdenSelection_ProjWO.SelectCommand.Parameters["@pri_id"].Value = pri_id;
            daBurdenSelection_ProjWO.SelectCommand.Parameters["@pri_id_sel"].Value = pri_id_sel;
            daBurdenSelection_ProjWO.Fill(dsBurdenSelection_ProjWO1);
            
        }

        private void luProjWO_EditValueChanged(object sender, EventArgs e)
        {
            LoadSelectionBurdenByProjWO(iPri_ID, Convert.ToInt32(luProjWO.EditValue));
        }

        private void UpdateSelection(bool pSelect)
        {
            for (int index = 0; gvBurden.DataRowCount >= index; index++)
            {
                if (gvBurden.GetDataRow(index) != null)
                    gvBurden.GetDataRow(index)["Selected"] = pSelect;
            }
        }

        private void btnSelectAll_Proj_Click(object sender, EventArgs e)
        {
            UpdateSelection(true);
        }

        private void btnSelectNone_Proj_Click(object sender, EventArgs e)
        {
            UpdateSelection(false);
        }

        private void bntOK_Proj_Click(object sender, EventArgs e)
        {

            gvBurden.UpdateCurrentRow();

            if (dsBurdenSelection_ProjWO1.WO_LoadSelectedBurdens_ByProjectWO.Select("Selected = 0").Length == dsBurdenSelection_ProjWO1.WO_LoadSelectedBurdens_ByProjectWO.Rows.Count)
            {
                if (Popups.ShowPopup("Are you sure you wish to select no burden?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                else
                    return;
            }
            DataRow[] drSelectedItem = dsBurdenSelection_ProjWO1.WO_LoadSelectedBurdens_ByProjectWO.Select("Selected = 1");
            System.Text.StringBuilder sbInsert = new StringBuilder();

            foreach (DataRow Row in drSelectedItem)
            {
                sbInsert.Append("insert costing_burdens(pri_id, burden_type_id, calc_type, reg_rate, ot_rate, dt_rate, gl_account, IsCeiling)");
                sbInsert.Append("Select " + iPri_ID.ToString() + ", burden_type_id, calc_type, reg_rate, ot_rate, dt_rate, gl_account, IsCeiling from costing_burdens where cb_id = '" + Row["cb_id"].ToString() + "' ");
                sbInsert.Append("\r\n");

            }
            ReflexCon.SQLExecutor.ExecuteNonQuery(sbInsert.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                Popups.ShowPopup("Unable to add burden: " + ReflexCon.SQLExecutor.Exception.Message);
            }

            DialogResult = DialogResult.OK;
            Close();
            
        }

        private void btnCancel_Type_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Proj_Click(object sender, EventArgs e)
        {
            Close();
        }

       

       
    }
}