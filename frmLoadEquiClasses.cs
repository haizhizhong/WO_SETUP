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
    public partial class frmLoadEquiClasses : Form
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

        public frmLoadEquiClasses(HMConnection.HMCon pReflexCon, TUC_HMDevXManager.TUC_HMDevXManager pStyle, int piPri_ID)
        {
            InitializeComponent();

            ReflexCon = pReflexCon;
            dxStyle = pStyle;
            iPri_ID = piPri_ID;

            sqlTR.ConnectionString = ReflexCon.TRConnection;
            tcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        }

        private void frmLoadEquiClasses_Load(object sender, EventArgs e)
        {
            frmMessageBox = new WS_Popups.frmPopup(dxStyle);
                       

            dsEquipClassSelection1.fa_class.SelectedColumn.ReadOnly = false;
            dsEquipClass1.fa_class.SelectedColumn.ReadOnly = false;

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
            for (int index = 0; gvSelectableEquiClasses.DataRowCount >= index; index++)
            {
                if (gvSelectableEquiClasses.GetDataRow(index) != null)
                    gvSelectableEquiClasses.GetDataRow(index)["Selected"] = pSelect;
            }
        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            gvSelectableEquiClasses.UpdateCurrentRow();

            if (dsEquipClassSelection1.fa_class.Select("Selected = 0").Count() == dsEquipClassSelection1.fa_class.Rows.Count)
            {
                if (frmMessageBox.ShowPopup("Are you sure you wish to select no equipment classes?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                else
                    return;
            }

            DataRow[] drSelectedItem = dsEquipClassSelection1.fa_class.Select("Selected = 1");
            System.Text.StringBuilder sbInsert = new StringBuilder();

            string preSql = "declare @id int ";
            string execSql =  " select @id = SCOPE_IDENTITY() exec FA_EqiClassPayRate  @id ";
            foreach (DataRow Row in drSelectedItem)
            {
               
                if (Row["facl_code"] != DBNull.Value && Row["facl_code"] != null)
                {
                    sbInsert.Append(" Insert Into costing_equipment_class (pri_id, eqi_Class, rate_desc, rate, CostRate, UseEquipOverride) ");
                    sbInsert.Append("Select " + iPri_ID.ToString() + ", facl_code, facl_desc, IsNull(fac_bill_out,0.00), IsNull(fac_cost_rate,0.00), 'F' From fa_class where facl_code = '" + Row["facl_code"].ToString() + "' ");
                    sbInsert.Append(execSql);
                    sbInsert.Append("\r\n");
                }
            }

            ReflexCon.SQLExecutor.ExecuteNonQuery(preSql + sbInsert.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Unable to add equipment classes: " + ReflexCon.SQLExecutor.Exception.Message);
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
             string sqlstr ="";
            if (rgType.SelectedIndex == 0)  // by project
            {
                tcMain.SelectedTabPage = tpByProject;

                string is_wo = "F";
                sqlstr = "select isnull(is_wo,'') from proj_header where pri_id = " + iPri_ID.ToString();
                object oIS_WO = ReflexCon.SQLExecutor.ExecuteScalar(sqlstr, ReflexCon.TRConnection);
                if (oIS_WO != null && oIS_WO != DBNull.Value)
                    is_wo = oIS_WO.ToString();
                dsProjWO_Equi1.Clear();
                daProjWO_Equi.SelectCommand.Parameters["@is_wo"].Value = is_wo;
                daProjWO_Equi.Fill(dsProjWO_Equi1);
            }
            else if (rgType.SelectedIndex == 1)
            {
                

                int iCount = 0;
                object oCount = ReflexCon.SQLExecutor.ExecuteScalar("SELECT Count(facl_code) FROM fa_class WHERE facl_code not in (Select eqi_Class From costing_equipment_class where pri_id = " + iPri_ID.ToString() + ")", ReflexCon.TRConnection);

                try { iCount = Convert.ToInt32(oCount); }
                catch { }

                if (iCount == 0)
                {
                    frmMessageBox.ShowPopup("No equipment class is loaded.");
                    return;
                }
               
                 tcMain.SelectedTabPage = tpBySetup;
                 dsEquipClassSelection1.Clear();
                 daEquipClassSelection.SelectCommand.CommandText = daEquipClassSelection.SelectCommand.CommandText.Replace("(1 = 1)", " facl_code not in (Select eqi_Class From costing_equipment_class where pri_id = " + iPri_ID.ToString() + ")");
                 daEquipClassSelection.Fill(dsEquipClassSelection1);
                
            }
        }

        private void luProjWO_EditValueChanged(object sender, EventArgs e)
        {
            dsEquipClass1.Clear();
            daEquipClass.SelectCommand.Parameters["@pri_id_sel"].Value = luProjWO.EditValue;
            daEquipClass.SelectCommand.Parameters["@pri_id"].Value = iPri_ID;
            daEquipClass.Fill(dsEquipClass1);
        }
        private void UpdateSelectionByProj(bool pSelect)
        {
            for (int index = 0; gvEquiClasses.DataRowCount >= index; index++)
            {
                if (gvEquiClasses.GetDataRow(index) != null)
                    gvEquiClasses.GetDataRow(index)["Selected"] = pSelect;
            }
        }

        private void btnSelectAll_Proj_Click(object sender, EventArgs e)
        {
            UpdateSelectionByProj(true);

        }

        private void btnSelectNone_Proj_Click(object sender, EventArgs e)
        {
            UpdateSelectionByProj(false);
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
            gvEquiClasses.UpdateCurrentRow();

            if (dsEquipClass1.fa_class.Select("Selected = 0").Count() == dsEquipClass1.fa_class.Rows.Count)
            {
                if (frmMessageBox.ShowPopup("Are you sure you wish to select no equipment classes?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
                else
                    return;
            }

            DataRow[] drSelectedItem = dsEquipClass1.fa_class.Select("Selected = 1");
            System.Text.StringBuilder sbInsert = new StringBuilder();

            string preSql = "declare @id int ";
            string execSql = " select @id = SCOPE_IDENTITY() exec FA_EqiClassPayRate  @id ";

            foreach (DataRow Row in drSelectedItem)
            {
                if (Row["eqi_Class"] != DBNull.Value && Row["eqi_Class"] != null)
                {
                    sbInsert.Append("Insert Into costing_equipment_class (pri_id, eqi_Class, rate_desc, rate, CostRate, UseEquipOverride) ");
                    sbInsert.Append("Select " + iPri_ID.ToString() + ", eqi_Class, rate_desc, rate, CostRate, UseEquipOverride From costing_equipment_class where cer_id = " + Row["cer_id"].ToString() );
                    sbInsert.Append(execSql);
                    sbInsert.Append("\r\n");
                }
            }

            ReflexCon.SQLExecutor.ExecuteNonQuery(preSql + sbInsert.ToString(), ReflexCon.TRConnection);
            if (ReflexCon.SQLExecutor.Exception != null)
            {
                frmMessageBox.ShowPopup("Unable to add equipment classes: " + ReflexCon.SQLExecutor.Exception.Message);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        //
    }
}
