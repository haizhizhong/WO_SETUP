using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WO_Setup
{
    public partial class frmLoadWorkClasses : Form
    {
        #region Local Variables

        private HMConnection.HMCon ReflexCon;
        private WS_Popups.frmPopup frmMessageBox;
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

        public frmLoadWorkClasses(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, int piPri_ID)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            iPri_ID = piPri_ID;

            sqlTR.ConnectionString = ReflexCon.TRConnection;
            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void frmLoadWorkClasses_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);

            dsWorkClass1.work_class.SelectedColumn.ReadOnly = false;
            dsWorkClassSelection1.work_class.SelectedColumn.ReadOnly = false;
            dxStyle.FormInit(this);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            UpdateSelection(true);
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            UpdateSelection(false);
        }

        private void UpdateSelection(bool pSelect)
        {
            for (int index = 0; gvSelectableWorkClasses.DataRowCount >= index; index++)
            {
                if (gvSelectableWorkClasses.GetDataRow(index) != null)
                    gvSelectableWorkClasses.GetDataRow(index)["Selected"] = pSelect;
            }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            gvSelectableWorkClasses.UpdateCurrentRow();
            
            if (dsWorkClassSelection1.work_class.Select("Selected = 0").Count() == dsWorkClassSelection1.work_class.Rows.Count)
            {
                if (frmMessageBox.ShowPopup("Are you sure you wish to select no work classes?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                else
                    return;
            }

            DataRow[] drSelectedItem = dsWorkClassSelection1.work_class.Select("Selected = 1");
            System.Text.StringBuilder sbInsert = new StringBuilder();

            foreach (DataRow Row in drSelectedItem)
            {
                if (Row["wc_code"] != DBNull.Value && Row["wc_code"] != null)
                {
                    sbInsert.Append("Insert Into costing_work_class (WC_Code, pri_id, Standard, OverTime, DoubleTime, TravelTime, CeilingCost) ");
                    sbInsert.Append("Select WC_Code, " + iPri_ID.ToString() + ", IsNull(Regular,0.00), IsNull(OverTime,0.00), IsNull(DoubleTime,0.00), IsNull(Travel,0.00), isnull(ceilingcost,0) From work_class where wc_code = '" + Row["wc_code"].ToString() + "' ");
                    sbInsert.Append("\r\n");
                }
            }

            ReflexCon.SQLExecutor.ExecuteNonQuery(sbInsert.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Unable to add work classes: " + ReflexCon.SQLExecutor.Exception.Message);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Type_Click(object sender, EventArgs e)
        {
            string sqlstr = "";
            if (rgType.SelectedIndex == 0)  // by project
            {
                tcMain.SelectedTabPage = tpByProject;
                string is_wo = "F";
                sqlstr = "select isnull(is_wo,'') from proj_header where pri_id = " + iPri_ID.ToString();
                object oIS_WO = ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection);
                if (oIS_WO != null && oIS_WO != DBNull.Value)
                    is_wo = oIS_WO.ToString();  
                dsProjWO_WC1.Clear();
                daProjWO_WC.SelectCommand.Parameters["@is_wo"].Value = is_wo;
                daProjWO_WC.Fill(dsProjWO_WC1);
            }
            else
            {
                int iCount = 0;
                object oCount = ReflexCon.SQLExecutor.ExecuteScalar("SELECT Count(wc_code) FROM work_class WHERE wc_code not in (Select WC_Code From costing_work_class where pri_id = " + iPri_ID.ToString() + ")", ReflexCon.TRConnection);

                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount == 0)
                {
                    frmMessageBox.ShowPopup("No work class is loaded.");
                    return;
                }
                tcMain.SelectedTabPage = tpBySetup;
                dsWorkClassSelection1.Clear();
                daWorkClassSelection.SelectCommand.CommandText = daWorkClassSelection.SelectCommand.CommandText.Replace("(1 = 1)", " wc_code not in (Select WC_Code From costing_work_class where pri_id = " + iPri_ID.ToString() + ") ");
                daWorkClassSelection.Fill(dsWorkClassSelection1);
                
            }

        }

        private void luProjWO_EditValueChanged(object sender, EventArgs e)
        {
            dsWorkClass1.Clear();
            daWorkClass.SelectCommand.Parameters["@pri_id_sel"].Value = luProjWO.EditValue;
            daWorkClass.SelectCommand.Parameters["@pri_id"].Value = iPri_ID ;
            daWorkClass.Fill(dsWorkClass1);


        }

        private void UpdateSelection_ByProject(bool pSelect)
        {
            for (int index = 0; gvWorkClass.DataRowCount >= index; index++)
            {
                if (gvWorkClass.GetDataRow(index) != null)
                    gvWorkClass.GetDataRow(index)["Selected"] = pSelect;
            }
        }

        private void btnSelectAll_Proj_Click(object sender, EventArgs e)
        {
            UpdateSelection_ByProject(true);
        }

        private void btnSelectNone_Proj_Click(object sender, EventArgs e)
        {
            UpdateSelection_ByProject(false);
        }

        private void btnCancel_Type_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Proj_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntOK_Proj_Click(object sender, EventArgs e)
        {
            gvWorkClass.UpdateCurrentRow();

            if (dsWorkClass1.work_class.Select("Selected = 0").Count() == dsWorkClass1.work_class.Rows.Count)
            {
                if (frmMessageBox.ShowPopup("Are you sure you wish to select no work classes?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                else
                    return;
            }

            DataRow[] drSelectedItem = dsWorkClass1.work_class.Select("Selected = 1");
            System.Text.StringBuilder sbInsert = new StringBuilder();

            foreach (DataRow Row in drSelectedItem)
            {
                if (Row["wc_code"] != DBNull.Value && Row["wc_code"] != null)
                {
                    sbInsert.Append("Insert Into costing_work_class (WC_Code, pri_id, Standard, OverTime, DoubleTime, TravelTime, ceilingcost) ");
                    sbInsert.Append("Select WC_Code, " + iPri_ID.ToString() + ", Standard, OverTime, DoubleTime, TravelTime, isnull(ceilingcost,0) From costing_work_class where cwc_id = " + Row["cwc_id"].ToString());
                    sbInsert.Append("\r\n");
                }
            }

            ReflexCon.SQLExecutor.ExecuteNonQuery(sbInsert.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Unable to add work classes: " + ReflexCon.SQLExecutor.Exception.Message);
            }

            DialogResult = DialogResult.OK;
            Close();
        }


        //
    }
}
