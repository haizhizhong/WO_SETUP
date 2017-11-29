using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WO_Setup
{
    public partial class ucSetup_OvertimeLimits_BillingThresholds : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSetup_OvertimeLimits_BillingThresholds(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
        {
            InitializeComponent();
            hmConn = pConn;
            hmDevMgr = pDevMg;
            sqlConnTR.ConnectionString = hmConn.TRConnection;
            sqlConnTR1.ConnectionString = hmConn.TRConnection;
            LoadUserControls();
        }

        #region Local Variables

        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevMgr;
        private WorkOrder_Utilities.woUtils utilsWO;
        private TUC_GridG.GridG fGGOvertimeLimits;
        private TUC_GridG.GridG fGGBillThresholds;
        private WS_Popups.frmPopup Popups;
        private int _pri_id = 0;
        private bool bCustomErrorMsg = false;


        #endregion Local Variables


        private void ucSetup_OvertimeLimits_BillingThresholds_Load(object sender, EventArgs e)
        {
            hmDevMgr.FormInit(this);
        }

        private void LoadUserControls()
        {
            fGGOvertimeLimits = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvOvertimeLimits, daOvertimeLimits, dsOvertimeLimits1);
            fGGOvertimeLimits.AskBeforeDelete = false;
            fGGOvertimeLimits.AllowTabCreateNewRecord = true;
            fGGOvertimeLimits.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(fGGOvertimeLimits_AllowDelete);
            fGGBillThresholds = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvBillingThreshold, daBillThresh, dsBillThresh1);
            fGGBillThresholds.AskBeforeDelete = false;
            fGGBillThresholds.AllowTabCreateNewRecord = true;
            fGGBillThresholds.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(fGGBillThresholds_AllowDelete);
            utilsWO = new WorkOrder_Utilities.woUtils(hmConn, hmDevMgr);
            Popups = new WS_Popups.frmPopup(hmDevMgr);

        }

        public void LoadOTLimitsBillThresholds(int pPriID, bool bReadOnly)
        {
            _pri_id = pPriID;

            dsOverTimeLimitsList1.Clear();
            daOverTimeLimitsList.Fill(dsOverTimeLimitsList1);

            dsOvertimeLimits1.Clear();
            daOvertimeLimits.SelectCommand.Parameters["@priID"].Value = pPriID;
            daOvertimeLimits.Fill(dsOvertimeLimits1);
                        
            if (bReadOnly)
            {

                gvOvertimeLimits.OptionsBehavior.Editable = false;
                fGGOvertimeLimits.Event_ProcessGridKey_Enabled = false;
            }
            else
            {
                gvOvertimeLimits.OptionsBehavior.Editable = true;
                fGGOvertimeLimits.Event_ProcessGridKey_Enabled = true;
             
            }
            LoadBillThreshold(pPriID, bReadOnly);
        }

        private  void LoadBillThreshold(int pPriID, bool bReadOnly)
        {
            
            string sqlStr = "select isnull(is_wo,'') from proj_header where pri_id = " + pPriID.ToString();
            string isWO = "";
            object objResult = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            if (objResult != null && objResult != DBNull.Value)
                isWO = objResult.ToString();
            //if (isWO == "T")
            //{
                dpBillingThreshold.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            //}
            //else
            //{
            //    string use_bill_thresh = "";
            //    sqlStr = "select isnull(use_bill_thresh,'') from proj_header where pri_id = " + pPriID.ToString();
            //    objResult = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection);
            //    if (objResult != null && objResult != DBNull.Value)
            //        use_bill_thresh = objResult.ToString();
            //    if (use_bill_thresh == "T")
            //        ceBillThresh.EditValue = "T";
            //    else
            //        ceBillThresh.EditValue = "F";

            //    dsBillThresh1.Clear();
            //    daBillThresh.SelectCommand.Parameters["@priID"].Value = pPriID;
            //    daBillThresh.Fill(dsBillThresh1);
            //    if (bReadOnly)
            //    {
            //        gvBillingThreshold.OptionsBehavior.Editable = false;
            //        fGGBillThresholds.Event_ProcessGridKey_Enabled = false;
            //    }
            //    else
            //    {
                    
            //        gvBillingThreshold.OptionsBehavior.Editable = true;
            //        fGGBillThresholds.Event_ProcessGridKey_Enabled = true;
            //    }


            //}
        }

        private void gvOvertimeLimits_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvOvertimeLimits.GetDataRow(e.RowHandle)["pri_id"] = _pri_id;
            gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_ot"] = 0.00;
            gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_dt"] = 0.00;
            gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_ot"] = 0.00;
            gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_Week_dt"] = 0.00;
        }

        private void gvOvertimeLimits_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colol_code)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    string sCode = "";
                    try { sCode = e.Value.ToString(); }
                    catch { }

                    DataTable dt = hmConn.SQLExecutor.ExecuteDataAdapter("Select ol_desc, ol_ot, ol_dt, ol_week_ot, ol_week_dt From ot_limit Where pri_id = 0 and ol_code = '" + sCode + "'", hmConn.TRConnection);
                    if (hmConn.SQLExecutor.Exception != null)
                    {
                        Popups.ShowPopup("Unable to retrive description for Over Time Code: " + hmConn.SQLExecutor.Exception.Message);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        gvOvertimeLimits.SetFocusedRowCellValue(colol_desc, dt.Rows[0]["ol_desc"]);
                        gvOvertimeLimits.SetFocusedRowCellValue(colol_ot, dt.Rows[0]["ol_ot"]);
                        gvOvertimeLimits.SetFocusedRowCellValue(colol_dt, dt.Rows[0]["ol_dt"]);
                        gvOvertimeLimits.SetFocusedRowCellValue(colol_week_ot, dt.Rows[0]["ol_week_ot"]);
                        gvOvertimeLimits.SetFocusedRowCellValue(colol_week_dt, dt.Rows[0]["ol_week_dt"]);
                    }
                }
            }
        }

        private void gvOvertimeLimits_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gvOvertimeLimits.GetDataRow(e.RowHandle) != null)
            {
                if (gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_code"] == DBNull.Value || gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_code"] == null)
                {
                    e.Valid = false;
                    e.ErrorText = "Code cannot be blank.";
                }
                else
                {
                    string sCode = "";
                    try { sCode = gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_code"].ToString(); }
                    catch { }

                    if (sCode.Trim() == "")
                    {
                        e.Valid = false;
                        e.ErrorText = "Code cannot be blank.";
                    }
                    else
                    {
                        int iCount = 0, iID = 0;
                        try{iID = Convert.ToInt32(gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_id"]);}
                        catch{}

                        object oCount = hmConn.SQLExecutor.ExecuteScalar("Select Count(ol_id) From ot_limit Where ol_code = '" + sCode + "' and pri_id = " + _pri_id.ToString() + " and ol_id <> " + iID.ToString(), hmConn.TRConnection);
                        try { iCount = Convert.ToInt32(oCount); }
                        catch { }

                        if (iCount > 0)
                        {
                            e.Valid = false;
                            e.ErrorText = "Code has already been added.";
                        }
                    }
                }

                //if (e.Valid)
                //{
                //    if (gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_desc"] == DBNull.Value || gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_desc"] == null)
                //    {
                //        e.Valid = false;
                //        e.ErrorText = "Description cannot be blank.";
                //    }
                //    else
                //    {
                //        string sDescritpion = "";
                //        try { sDescritpion = gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_desc"].ToString(); }
                //        catch { }

                //        if (sDescritpion.Trim() == "")
                //        {
                //            e.Valid = false;
                //            e.ErrorText = "Description Cannot be blank.";
                //        }
                //    }
                //}

                double dRate = 0;

                if (e.Valid)
                {
                    if (gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_ot"] == DBNull.Value || gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_ot"] == null)
                    {
                        e.ErrorText = "Daily Overtime cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_ot"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Daily Overtime cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_dt"] == DBNull.Value || gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_dt"] == null)
                    {
                        e.ErrorText = "Daily Double Time cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_dt"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Daily Double Time cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_ot"] == DBNull.Value || gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_ot"] == null)
                    {
                        e.ErrorText = "Weekly Overtime cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_ot"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Weekly Overtime cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_dt"] == DBNull.Value || gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_dt"] == null)
                    {
                        e.ErrorText = "Weekly Double Time cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvOvertimeLimits.GetDataRow(e.RowHandle)["ol_week_dt"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Weekly Double Time cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }
            }

            if (!e.Valid)
                bCustomErrorMsg = true;

            //DataRow dr = gvOvertimeLimits.GetDataRow(e.RowHandle);
            //if (dr != null)
            //{
            //    double dRate = 0;
            //    object objResult = dr["ol_ot"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Daily overtime cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["ol_dt"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Daily double time cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }

            //    objResult = dr["ol_week_ot"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Weekly overtime cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["ol_week_dt"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Weekly double time cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }

            //}
        }

        private void gvOvertimeLimits_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomErrorMsg)
            {
                bCustomErrorMsg = false;
                Popups.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private bool fGGOvertimeLimits_AllowDelete(object sender, DataRow row)
        {
            if (Popups.ShowPopup("Are you sure you wish to delete this Overtime Limit?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;

            return false;
        }

        private void gvBillingThreshold_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvBillingThreshold.GetDataRow(e.RowHandle)["pri_id"] = _pri_id;
            gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_ot"] = 0.00;
            gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_dt"] = 0.00;
            gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_ot"] = 0.00;
            gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_dt"] = 0.00;
        }

        private bool fGGBillThresholds_AllowDelete(object sender, DataRow row)
        {
            if (Popups.ShowPopup("Are you sure you wish to delete this Billing Threashold?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                return true;

            return false;
        }

        private void gvBillingThreshold_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gvBillingThreshold.GetDataRow(e.RowHandle) != null)
            {
                if (gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_type"] == DBNull.Value || gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_type"] == null)
                {
                    e.Valid = false;
                    e.ErrorText = "Type cannot be blank.";
                }
                else
                {
                    string sType = "";
                    try { sType = gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_type"].ToString(); }
                    catch { }

                    if (sType.Trim() == "")
                    {
                        e.Valid = false;
                        e.ErrorText = "Type cannot be blank.";
                    }
                    else
                    {
                        int iCount = 0, iID = 0;
                        try { iID = Convert.ToInt32(gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_id"]); }
                        catch { }

                        object oCount = hmConn.SQLExecutor.ExecuteScalar("Select Count(pbt_id) From proj_bill_thresh Where pbt_type = '" + sType + "' and pri_id = " + _pri_id.ToString() + " and pbt_id <> " + iID.ToString(), hmConn.TRConnection);
                        try { iCount = Convert.ToInt32(oCount); }
                        catch { }

                        if (iCount > 0)
                        {
                            e.Valid = false;
                            e.ErrorText = "Type has alreday been added.";
                        }
                    }
                }

                double dRate = 0;

                if (e.Valid)
                {
                    if (gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_ot"] == DBNull.Value || gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_ot"] == null)
                    {
                        e.ErrorText = "Daily Overtime cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_ot"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Daily Overtime cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_dt"] == DBNull.Value || gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_dt"] == null)
                    {
                        e.ErrorText = "Daily Double Time cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_dt"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Daily Double Time cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_ot"] == DBNull.Value || gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_ot"] == null)
                    {
                        e.ErrorText = "Weekly Overtime cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_ot"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Weekly Overtime cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_dt"] == DBNull.Value || gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_dt"] == null)
                    {
                        e.ErrorText = "Weekly Double Time cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvBillingThreshold.GetDataRow(e.RowHandle)["pbt_week_dt"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Weekly Double Time cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }
            }

            if (!e.Valid)
                bCustomErrorMsg = true;

            //DataRow dr = gvBillingThreshold.GetDataRow(e.RowHandle);
            //if (dr != null)
            //{
            //    double dRate = 0;
            //    object objResult = dr["pbt_ot"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Daily overtime cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["pbt_dt"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Daily double time cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }

            //    objResult = dr["pbt_week_ot"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Weekly overtime cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["pbt_week_dt"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Weekly double time cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }

            //}
        }

        private void gvBillingThreshold_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomErrorMsg)
            {
                bCustomErrorMsg = false;
                Popups.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

      
        private void ceBillThresh_CheckedChanged(object sender, EventArgs e)
        {
            string sBillThresh = "F";
            if (ceBillThresh.Checked)
                sBillThresh = "T";
            string sqlStr = "update proj_header set use_bill_thresh = " + "'" + sBillThresh + "'" + "  where pri_id = " + _pri_id.ToString();
            hmConn.SQLExecutor.ExecuteNonQuery(sqlStr, hmConn.TRConnection);
            
        }

        private void rilueOTLCode_Enter(object sender, EventArgs e)
        {
            //Filter Work Classes based on what is not in this list.

            string sOL_Code = "";
            try { sOL_Code = gvOvertimeLimits.GetDataRow(gvOvertimeLimits.FocusedRowHandle)["ol_code"].ToString(); }
            catch { }

            DataTable dtFilteredList = hmConn.SQLExecutor.ExecuteDataAdapter("SELECT ol_id, ol_code, ol_desc FROM ot_limit WHERE (pri_id = 0) and ol_code not in (Select ol_code From ot_limit where pri_id =  " + _pri_id.ToString() + " and ol_code <> '" + sOL_Code + "') ORDER BY ol_code", hmConn.TRConnection);
            ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = dtFilteredList;
        }
    }
}
