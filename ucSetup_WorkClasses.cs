using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WO_Setup
{
    public partial class ucSetup_WorkClasses : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSetup_WorkClasses(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
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
        private TUC_GridG.GridG fGGWorkClass;
        private WS_Popups.frmPopup Popups;
        private bool bCustomErrorMsg = false;

        private int _pri_id = 0;


        #endregion Local Variables

        private void ucSetup_WorkClasses_Load(object sender, EventArgs e)
        {
            hmDevMgr.FormInit(this);

        }
        
        private void LoadUserControls()
        {
            fGGWorkClass = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvWorkClasses,daCostingWorkClass,dsCostingWorkClass1);
            fGGWorkClass.AskBeforeDelete = false;
            fGGWorkClass.AllowTabCreateNewRecord = true;
            fGGWorkClass.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(fGGWorkClass_AllowDelete);
            utilsWO = new WorkOrder_Utilities.woUtils(hmConn, hmDevMgr);
            Popups = new WS_Popups.frmPopup(hmDevMgr);
                        
           
        }

        public void LoadCostingWorkClass(int pPriID, bool bReadOnly)
        {
            try
            {
                _pri_id = pPriID;
                dsCostingWorkClass1.Clear();
                daCostingWorkClass.SelectCommand.Parameters["@priID"].Value = pPriID;
                daCostingWorkClass.Fill(dsCostingWorkClass1);
                if (bReadOnly)
                {
                    gvWorkClasses.OptionsBehavior.Editable = false;
                    fGGWorkClass.Event_ProcessGridKey_Enabled = false;
                    btnLoadWorkClasses.Enabled = false;
                }
                else
                {
                    gvWorkClasses.OptionsBehavior.Editable = true;
                    fGGWorkClass.Event_ProcessGridKey_Enabled = true;
                    btnLoadWorkClasses.Enabled = true;
                }

                dsWorkClasses1.Clear();
                daWorkClasses.Fill(dsWorkClasses1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error found in LoadCostingWorkClass in ucSetup_WorkClasses:" + ex.Message.ToString());
            }
        }

        #region "Gridview gvWorkClasses events" 
        private void gvWorkClasses_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            string wcCode = "";
            DataRow dr = ((gvWorkClasses.DataSource as IList)[e.ListSourceRowIndex] as DataRowView).Row;
            if (dr != null)
            {
                if (e.Column == grdColDesc  && e.IsGetData)
                {
                    object objResult = dr["wc_code"];
                    if (objResult != null && objResult != DBNull.Value)
                        wcCode = objResult.ToString();
                    if (wcCode != "")
                    {
                        string sqlStr = "select wc_desc from work_class where wc_code = "+ "'"+wcCode+"'";
                        object oDesc = hmConn.SQLExecutor.ExecuteScalar(sqlStr, hmConn.TRConnection); 
                        
                        if(oDesc != null || oDesc != DBNull.Value) {
                            e.Value = Convert.ToString(oDesc);
                        }
                    }

                }
            }
        }

        private void gvWorkClasses_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //Standard

            if (gvWorkClasses.GetDataRow(e.RowHandle) != null)
            {
                if (gvWorkClasses.GetDataRow(e.RowHandle)["WC_Code"] == DBNull.Value || gvWorkClasses.GetDataRow(e.RowHandle)["WC_Code"] == null)
                {
                    e.ErrorText = "Work Code cannot be blank.";
                    e.Valid = false;
                }

                double dRate = 0;

                if (e.Valid)
                {
                    if (gvWorkClasses.GetDataRow(e.RowHandle)["Standard"] == DBNull.Value || gvWorkClasses.GetDataRow(e.RowHandle)["Standard"] == null)
                    {
                        e.ErrorText = "Regular rate cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvWorkClasses.GetDataRow(e.RowHandle)["Standard"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Regular rate cannot be negative.";
                            e.Valid = false;
                        }
                    }                    
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvWorkClasses.GetDataRow(e.RowHandle)["OverTime"] == DBNull.Value || gvWorkClasses.GetDataRow(e.RowHandle)["OverTime"] == null)
                    {
                        e.ErrorText = "Overtime rate cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvWorkClasses.GetDataRow(e.RowHandle)["OverTime"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Overtime rate cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvWorkClasses.GetDataRow(e.RowHandle)["DoubleTime"] == DBNull.Value || gvWorkClasses.GetDataRow(e.RowHandle)["DoubleTime"] == null)
                    {
                        e.ErrorText = "Double time rate cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvWorkClasses.GetDataRow(e.RowHandle)["DoubleTime"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Double time rate cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvWorkClasses.GetDataRow(e.RowHandle)["TravelTime"] == DBNull.Value || gvWorkClasses.GetDataRow(e.RowHandle)["TravelTime"] == null)
                    {
                        e.ErrorText = "Travel time rate cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvWorkClasses.GetDataRow(e.RowHandle)["TravelTime"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Travel time rate cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    dRate = 0;

                    if (gvWorkClasses.GetDataRow(e.RowHandle)["CeilingCost"] == DBNull.Value || gvWorkClasses.GetDataRow(e.RowHandle)["CeilingCost"] == null)
                    {
                        e.ErrorText = "Ceiling Cost amount cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvWorkClasses.GetDataRow(e.RowHandle)["CeilingCost"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Ceiling Cost amount cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }


                // validate the row when 'scheduling' is being disabled
                if (e.Valid)
                {
                    object oSchedulingProposed = false;
                    object oScheduling = false;
                    try
                    {
                        oSchedulingProposed = gvWorkClasses.GetDataRow(e.RowHandle)[colsch_enabled.FieldName, DataRowVersion.Proposed];
                    } catch { }
                    try
                    {
                        oScheduling = gvWorkClasses.GetDataRow(e.RowHandle)[colsch_enabled.FieldName, DataRowVersion.Current];
                    } catch { }
                    object cwc_id = -1;

                    if (oSchedulingProposed == null || oSchedulingProposed == DBNull.Value)
                        oSchedulingProposed = false;
                    if (oScheduling == null || oScheduling == DBNull.Value)
                        oScheduling = false;

                    if (gvWorkClasses.GetDataRow(e.RowHandle)[colcwc_id.FieldName] != null)
                    {
                        cwc_id = gvWorkClasses.GetDataRow(e.RowHandle)[colcwc_id.FieldName];
                    }

                    if (Convert.ToBoolean(oSchedulingProposed) == false)
                    {
                        if (IsWorkClassScheduledWithEmployees(Convert.ToInt32(cwc_id)))
                        {
                            string msg = "Employees have been scheduled against the selected work class. By disabling scheduling, note that the existing scheduled employees will be removed. " + Environment.NewLine + "Are you sure you want to continue ?";

                            if (Popups.ShowPopup(msg, "Warning", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                            {
                                // delete all records from the tr.costing_working_class_emp
                                hmConn.SQLExecutor.ExecuteNonQuery("DELETE FROM costing_work_class_emp WHERE cwc_id = " + cwc_id, hmConn.TRConnection);
                            }
                            else
                            {
                                gvWorkClasses.SetFocusedRowCellValue(colsch_enabled, oScheduling);
                            }
                        }
                    }                    
                }
            }

            if (!e.Valid)
                bCustomErrorMsg = true;

            //DataRow dr = gvWorkClasses.GetDataRow(e.RowHandle);
            //if (dr != null)
            //{
            //    double dRate = 0;
            //    object objResult = dr["Standard"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Regular rate cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["OverTime"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Overtime rate cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }


            //    objResult = dr["DoubleTime"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Double time rate cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["TravelTime"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Travel time rate cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }


            //}
        }

        private void gvWorkClasses_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomErrorMsg)
            {
                bCustomErrorMsg = false;
                Popups.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private void gvWorkClasses_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvWorkClasses.GetDataRow(e.RowHandle)["pri_id"] = _pri_id;
            gvWorkClasses.GetDataRow(e.RowHandle)["Standard"] = 0.00;
            gvWorkClasses.GetDataRow(e.RowHandle)["OverTime"] = 0.00;
            gvWorkClasses.GetDataRow(e.RowHandle)["DoubleTime"] = 0.00;
            gvWorkClasses.GetDataRow(e.RowHandle)["TravelTime"] = 0.00;
            gvWorkClasses.GetDataRow(e.RowHandle)["ceilingcost"] = 0.00;
            gvWorkClasses.GetDataRow(e.RowHandle)[colsch_enabled.FieldName] = false;
        }

        private void gvWorkClasses_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (colWC_Code == e.Column)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    string sWC_Code = "";
                    try { sWC_Code = e.Value.ToString(); }
                    catch { }

                    DataTable dtWorkClassData = hmConn.SQLExecutor.ExecuteDataAdapter("Select IsNull(Regular,0.00) [Regular], IsNull(OverTime,0.00) [OverTime], IsNull(DoubleTime,0.00) [DoubleTime], IsNull(Travel,0.00) [Travel], isnull(CeilingCost,0) [CeilingCost] From work_class where wc_code = '" + sWC_Code + "' ", hmConn.TRConnection);
                    if (dtWorkClassData.Rows.Count == 0)
                    {
                        gvWorkClasses.SetFocusedRowCellValue(colStandard, 0.00);
                        gvWorkClasses.SetFocusedRowCellValue(colOverTime, 0.00);
                        gvWorkClasses.SetFocusedRowCellValue(colDoubleTime, 0.00);
                        gvWorkClasses.SetFocusedRowCellValue(colTravelTime, 0.00);
                        gvWorkClasses.SetFocusedRowCellValue(colceilingcost, 0.00);
                    }
                    else
                    {
                        gvWorkClasses.SetFocusedRowCellValue(colStandard, dtWorkClassData.Rows[0]["Regular"]);
                        gvWorkClasses.SetFocusedRowCellValue(colOverTime, dtWorkClassData.Rows[0]["OverTime"]);
                        gvWorkClasses.SetFocusedRowCellValue(colDoubleTime, dtWorkClassData.Rows[0]["DoubleTime"]);
                        gvWorkClasses.SetFocusedRowCellValue(colTravelTime, dtWorkClassData.Rows[0]["Travel"]);
                        gvWorkClasses.SetFocusedRowCellValue(colceilingcost, dtWorkClassData.Rows[0]["CeilingCost"]);
                    }
                }
            }
        }

        #endregion 

        private void gcWorkClasses_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                e.Handled = false;
            }
        }

        private void rilueWorkClasses_Enter(object sender, EventArgs e)
        {
            //Filter Work Classes based on what is not in this list.

            int iCWC_ID = -1;
            try { iCWC_ID = Convert.ToInt32(gvWorkClasses.GetDataRow(gvWorkClasses.FocusedRowHandle)["cwc_id"]); }
            catch { }

            DataTable dtFilteredList = hmConn.SQLExecutor.ExecuteDataAdapter("SELECT wc_co, wc_code, wc_desc FROM work_class Where wc_code not in (Select WC_Code From costing_work_class Where pri_id = " + _pri_id.ToString() + " and cwc_id <> " + iCWC_ID.ToString() + ") ORDER BY wc_code", hmConn.TRConnection);
            ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = dtFilteredList;
        }

        private void btnLoadWorkClasses_Click(object sender, EventArgs e)
        {
            using (frmLoadWorkClasses LoadWorkClasses = new frmLoadWorkClasses(hmConn, hmDevMgr, _pri_id))
            {
                if (LoadWorkClasses.ShowDialog() == DialogResult.OK)
                {
                    dsCostingWorkClass1.Clear();
                    daCostingWorkClass.SelectCommand.Parameters["@priID"].Value = _pri_id;
                    daCostingWorkClass.Fill(dsCostingWorkClass1);
                }
            }
        }

        private bool fGGWorkClass_AllowDelete(object sender, DataRow row)
        {
            bool retval = false;

            // request for deletion permission and validation
            if (CheckAndRemoveExistingWorkClassEmployee())
            {
                retval = true;
            }
            else
            {
                // delete normally
                if (Popups.ShowPopup("Are you sure you wish to delete this work class?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
                {
                    retval = true;
                }
            }

            return retval;
        }

        #region "Helper methods"
        private bool IsWorkClassScheduledWithEmployees(int costingWorkClassID)
        {
            bool isScheduled = false;

            // gets all employees currently assigned to a particular working class
            string cmdText = @" select cwce.* from costing_work_class_emp cwce
                                inner join costing_work_class cwc on cwce.cwc_id = cwc.cwc_id
                                where cwce.cwc_id = " + costingWorkClassID.ToString();

            System.Data.DataTable dt = hmConn.SQLExecutor.ExecuteDataAdapter(cmdText, hmConn.TRConnection);

            if (dt != null && dt.Rows.Count > 0)
            {
                isScheduled = true;
            }

            return isScheduled;
        }

        //private int GetFocusedRowCostingWorkClassID() 
        //{
        //    int cwc_id = -1;

        //    object oCWC_ID = gvWorkClasses.GetRowCellValue(gvWorkClasses.FocusedRowHandle, colcwc_id.FieldName);

        //    if (oCWC_ID != DBNull.Value && oCWC_ID != null)
        //    {
        //        cwc_id = Convert.ToInt32(oCWC_ID);
        //    }

        //    return cwc_id;
        //}


        //private void gcWorkClass_DeleteFocusedRow()
        //{
        //    // asking for permission to delete existing work class employee b
        //    CheckAndRemoveExistingWorkClassEmployee();

        //    // delete focused row
        //    gvWorkClasses.DeleteRow(gvWorkClasses.FocusedRowHandle);
        //    fGGWorkClass.DeleteRecord(gvWorkClasses.FocusedRowHandle);

        //    // refresh the grid
        //    LoadCostingWorkClass(_pri_id, gvWorkClasses.OptionsBehavior.Editable);
        //}

        private bool CheckAndRemoveExistingWorkClassEmployee()
        {
            object cwc_id = -1;
            bool retval = false;

            if (gvWorkClasses.GetDataRow(gvWorkClasses.FocusedRowHandle)[colcwc_id.FieldName] != null)
            {
                cwc_id = gvWorkClasses.GetDataRow(gvWorkClasses.FocusedRowHandle)[colcwc_id.FieldName];
            }

            if (IsWorkClassScheduledWithEmployees(Convert.ToInt32(cwc_id)))
            {
                string msg = "Employees have been scheduled against the selected work class. Deleting this work class will remove the existing scheduled employees." + Environment.NewLine + "Are you sure you want to continue ?";

                if (Popups.ShowPopup(msg, "Warning", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                {
                    // delete all records from the tr.costing_working_class_emp
                    hmConn.SQLExecutor.ExecuteNonQuery("DELETE FROM costing_work_class_emp WHERE cwc_id = " + cwc_id, hmConn.TRConnection);
                    retval = true;
                }
            }

            return retval;
        }

        #endregion

        private void riteCeilingCost_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            // allow up to 999,999,999,999,999.9999
            if (Convert.ToDouble(e.NewValue.ToString()) <= 999999999999999.9999)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}
