using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace WO_Setup
{
    public partial class ucSetup_Burden : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSetup_Burden(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            sqlConnTR.ConnectionString = hmConn.TRConnection;
            LoadUserControls();
           
        }

        #region Local Variables

        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;
        private WorkOrder_Utilities.woUtils utilsWO;
        private TUC_GridG.GridG fGGBurdens;
        private GL_Account_Lookup_Rep.Repository_GL_Lookup GL_Repository;
        private WS_Popups.frmPopup Popups;

        private string deleteStr = "Delete Record?";
        private int _pri_id = 0;

        #endregion Local Variables


        private void ucSetup_Burden_Load(object sender, EventArgs e)
        {
            hmDevMgr.FormInit(this);
            
        }

        private void LoadUserControls()
        {
            fGGBurdens = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvBurden, daCostingBurden, dsCostingBurden1);
            fGGBurdens.AskBeforeDelete = false;
            fGGBurdens.AllowTabCreateNewRecord = true;
            fGGBurdens.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(fGGBurdens_AllowDelete);
          
            utilsWO = new WorkOrder_Utilities.woUtils(hmConn, hmDevMgr);
            Popups = new WS_Popups.frmPopup(hmDevMgr);
            GL_Repository = new GL_Account_Lookup_Rep.Repository_GL_Lookup();
            GL_Repository.OpeningBalance = false;
            GL_Repository.HideVailidation = true;
            GL_Repository.HideSubCode = true;
            GL_Repository.HMConnection = this.hmConn;
            GL_Repository.DevXMgr = this.hmDevMgr;
            colgl_account.ColumnEdit = this.GL_Repository;
        }

        bool fGGBurdens_AllowDelete(object sender, DataRow row)
        {
            return AllowDelete();
            
        }

        private bool AllowDelete()
        {
            bool doDeleting = false;
            try
            {

                if (this.Popups.ShowPopup(this, deleteStr, "Confirmation", WS_Popups.frmPopup.PopupType.Yes_No)
                    == WS_Popups.frmPopup.PopupResult.Yes)
                {

                    doDeleting = true;
                }

            }
            catch (Exception ex)
            {
                doDeleting = false;
                MessageBox.Show(String.Format("Error found in deleting process: ", ex.Message));
            }

            return doDeleting;

        }

        public void LoadBurdens(int pPriID, bool  bReadOnly)
        {
            _pri_id = pPriID;
            dsCostingBurden1.Clear();
            daCostingBurden.SelectCommand.Parameters["@priID"].Value = pPriID;
            daCostingBurden.Fill(dsCostingBurden1);

            ActivateLUDataset();

            if (bReadOnly)
                gvBurden.OptionsBehavior.Editable = false;
            else
                gvBurden.OptionsBehavior.Editable = true;

        }

        private void ActivateLUDataset()
        {
            string isWO = "";
            string sqlStr = "select  isnull(is_wo,'') from proj_header where pri_id = " + _pri_id.ToString();
            object objResult = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (objResult != null && objResult != DBNull.Value)
                isWO = objResult.ToString();
            if (isWO == "T")
               sqlStr = "select burden_type_id,burden_type,burden_desc from wo_burden_type order by burden_desc";
            else
                sqlStr = "select burden_type_id,burden_type,burden_desc from burden_type order by burden_desc";

            utilsWO.LoadLookupDataSource(sqlStr, luBurdenType, "burden_type", "burden_desc", true, hmConn.TRConnection,
                "Code", "Description", "burden_type_id", "burden_type");
            utilsWO.LoadLookupDataSource(sqlStr, luBurdenDesc, "burden_type", "burden_desc", false, hmConn.TRConnection, "Code",
                 "Description", "burden_type_id", "burden_desc");

            
        }

        private void gvBurden_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gvBurden_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            DataRow dr = ((gvBurden.DataSource as IList)[e.ListSourceRowIndex] as DataRowView).Row;
            string glAcct = "";
            if (dr != null)
            {
                if (e.Column == grdAcctDesc && e.IsGetData)
                {
                    object objResult = dr["gl_account"];
                    if (objResult != null && objResult != DBNull.Value)
                        glAcct = objResult.ToString();
                    if (glAcct != "")
                    {
                        string sqlStr = "select description  from gl_accounts where account_number = "+ "'"+glAcct+"'";
                        string acctDesc = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection).ToString();
                        e.Value = acctDesc;


                    }
                }
            }

        }

        private void gvBurden_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DataRow dr = gvBurden.GetDataRow(e.RowHandle);
            
            dr["pri_id"] = _pri_id;
            dr["calc_type"] = "P";
            dr["reg_rate"] = 0;
            dr["ot_rate"] = 0;
            dr["dt_rate"] = 0;
            dr["gl_account"] = "";
        }

        private void gvBurden_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int burdenID = 0;
            int typeID = 0;
           
            double dRate = 0;
            double regHR, OTHR, DTHR; // regualr hours, over-time hours and double time hours

            DataRow dr = gvBurden.GetDataRow(e.RowHandle);
            if (dr != null)
            {
                object objResult = dr["burden_type_id"];
                if (objResult == null || objResult == DBNull.Value)
                {
                    Popups.ShowPopup("A burden type is required.");
                    e.Valid = false;
                    return;
                }
                typeID = Convert.ToInt32(objResult);
                objResult = dr["cb_id"];
                if (objResult != null && objResult != DBNull.Value)
                {
                    burdenID = Convert.ToInt32(objResult);
                }
                string sqlStr = "select count(*) from costing_burdens where pri_id = " + _pri_id.ToString() +
                    " and cb_id  <> " + burdenID.ToString() + "  and burden_type_id =  " + typeID.ToString();
                int count = Convert.ToInt32(hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection));
                if (count > 0)
                {
                    Popups.ShowPopup("This burden type already setup.");
                    e.Valid = false;
                    return;
                }

                //
                objResult = dr["reg_rate"];
                if (objResult != null && objResult != DBNull.Value)
                {
                    dRate = Convert.ToDouble(objResult);
                }
                if (dRate < 0)
                {
                    Popups.ShowPopup("Regular Hours cannot be negative.");
                    e.Valid = false;
                    return;
                }
                else
                {
                    regHR = dRate;
                }

                objResult = dr["ot_rate"];
                if (objResult != null && objResult != DBNull.Value)
                {
                    dRate = Convert.ToDouble(objResult);
                }
                if (dRate < 0)
                {
                    Popups.ShowPopup("Overtime Hours cannot be negative.");
                    e.Valid = false;
                    return;
                }
                else
                {
                    OTHR = dRate;
                }

                objResult = dr["dt_rate"];
                if (objResult != null && objResult != DBNull.Value)
                {
                    dRate = Convert.ToDouble(objResult);
                }
                if (dRate < 0)
                {
                    Popups.ShowPopup("Double Hours cannot be negative.");
                    e.Valid = false;
                    return;
                }
                else
                {
                    DTHR = dRate;
                }
                
                objResult = dr["gl_account"];
                if (objResult.ToString() == "")
                {
                    Popups.ShowPopup("GL Account is required.");
                    e.Valid = false;
                    return;
                }

                // if it is Ceiling Burden, do not allow the line to save with Regular, OT, DT hours other than 0
                if (IsCeilingBurden(gvBurden.FocusedRowHandle))
                {
                    if (regHR != 0 || OTHR != 0 || DTHR != 0)
                    {
                        if (Popups.ShowPopup("Regular Hours, Overtime Hours and Double Hours must each equal to 0. Do you want to set it to zero ?", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                        {
                            dr["reg_rate"] = dr["ot_rate"] = dr["dt_rate"] = 0;
                            gvBurden.SetFocusedRowCellValue("reg_rate", 0);
                            gvBurden.SetFocusedRowCellValue("ot_rate", 0);
                            gvBurden.SetFocusedRowCellValue("dt_rate", 0);
                        }
                        else
                        {
                            e.Valid = false;
                            return;
                        }
                    }
                }
            }
        }

        private void btnLoadBurdens_Click(object sender, EventArgs e)
        {
            using (frmLoadBurdens LoadBurdens = new frmLoadBurdens(hmConn, hmDevMgr, _pri_id))
            {
                if (LoadBurdens.ShowDialog() == DialogResult.OK)
                {
                    dsCostingBurden1.Clear();
                    daCostingBurden.SelectCommand.Parameters["@priID"].Value = _pri_id;
                    daCostingBurden.Fill(dsCostingBurden1);
                }
            }
        }

        private void gvBurden_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == colcalc_type)
            {
                DataRow dr = gvBurden.GetDataRow(e.RowHandle);
                if (dr != null)
                {
                    object oCeiling = dr["IsCeiling"];
                    if (oCeiling == null || oCeiling == DBNull.Value)
                        oCeiling = 0;

                    if (Convert.ToBoolean(oCeiling))
                    {
                        e.RepositoryItem = rgCalMethodRO;
                    }
                    else
                    {
                        e.RepositoryItem = rgCalMethod;
                    }
                }
            }
        }

        private void luBurdenType_EditValueChanged(object sender, EventArgs e)
        {
            object oBurden = ((LookUpEdit)sender).EditValue;
            if (oBurden == null || oBurden == DBNull.Value)
            {
                gvBurden.SetFocusedRowCellValue("IsCeiling", false);
                return;
            }

            string sSQL = @"select isnull((select ISNULL(ceiling_burden,'F') from burden_type where burden_type_id=" + oBurden + @"), 'F')";
            object oCeiling = hmConn.SQLExecutor.ExecuteScalar(sSQL, hmConn.TRConnection);
            if (oCeiling == null || oCeiling == DBNull.Value)
                oCeiling = "F";

            if (oCeiling.Equals("T")) // ceiling burden type
            {
                gvBurden.SetFocusedRowCellValue("IsCeiling", true);
                gvBurden.SetFocusedRowCellValue("calc_type", "A");
                gvBurden.SetFocusedRowCellValue(colreg_rate, 0);
                gvBurden.SetFocusedRowCellValue(colot_rate, 0);
                gvBurden.SetFocusedRowCellValue(coldt_rate, 0);
            }
            else
                gvBurden.SetFocusedRowCellValue("IsCeiling", false);
        }


        private bool IsCeilingBurden(int rowHandle)
        {
            bool retval = false;

            object oBurden = gvBurden.GetRowCellValue(rowHandle, colburden_type_id);

            if ( (oBurden == null || oBurden == DBNull.Value) == false)
            {
                string sSQL = @"select isnull((select ISNULL(ceiling_burden,'F') from burden_type where burden_type_id=" + oBurden + @"), 'F')";
                object oCeiling = hmConn.SQLExecutor.ExecuteScalar(sSQL, hmConn.TRConnection);

                if (oCeiling.Equals("T")) // ceiling burden type
                {
                    retval = true;
                }
            }

            return retval;
        }
    }
}
