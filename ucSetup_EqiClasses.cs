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
    public partial class ucSetup_EqiClasses : DevExpress.XtraEditors.XtraUserControl
    {
        public ucSetup_EqiClasses(HMConnection.HMCon pConn, TUC_HMDevXManager.TUC_HMDevXManager pDevMg)
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
        private WS_Popups.frmPopup Popups;
        private TUC_GridG.GridG fGGEqiClass;
        private FAPayRateSchedule.ucRateSchedule_EquipClass eqiClassRateSchedule;

        private bool bCustomErrorMsg = false;
        private int _pri_id = 0;


        #endregion Local Variables

        private void ucSetup_EqiClasses_Load(object sender, EventArgs e)
        {
            hmDevMgr.FormInit(this);

            daUnitTimeMeasurement.Fill(dsUnitTimeMeasurement1.unit_time_measurement);
        }

        private void LoadUserControls()
        {
            fGGEqiClass = new TUC_GridG.GridG(hmConn.CompanyServer, hmConn.TRDB, gvEqiClass, daCostingEqiClass, dsCostingEqiClass1);
            fGGEqiClass.AskBeforeDelete = false;
            fGGEqiClass.AllowTabCreateNewRecord = true;
            fGGEqiClass.AllowDelete += new TUC_GridG.GridG.AllowDeleteDelegate(fGGEqiClass_AllowDelete);

            fGGEqiClass.AfterUpdate += FGGEqiClass_AfterUpdate;
            Popups = new WS_Popups.frmPopup(hmDevMgr);

            eqiClassRateSchedule = new FAPayRateSchedule.ucRateSchedule_EquipClass(hmConn, hmDevMgr);
            eqiClassRateSchedule.Reload_EqiClass_Schedul += EqiClassRateSchedule_Reload_EqiClass_Schedul;
            eqiClassRateSchedule.Dock = DockStyle.Fill;
            eqiClassRateSchedule.Parent = gcRateSchedule;
        }

        private void FGGEqiClass_AfterUpdate(object sender, TUC_GridG.UpdateType UType)
        {
            DataRow dr = gvEqiClass.GetDataRow(gvEqiClass.FocusedRowHandle);
            if (dr != null)
            {
                int cer_id = -1;
                if (dr["cer_id"] != null && dr["cer_id"] != DBNull.Value)
                    cer_id = Convert.ToInt32(dr["cer_id"]);
                                

                if (UType == TUC_GridG.UpdateType.Add || UType == TUC_GridG.UpdateType.Update)
                {
                    LoadRateSchedule(cer_id);
                    daCostingEqiClass.Fill(dsCostingEqiClass1);
                }

            }
        }

     

        private void EqiClassRateSchedule_Reload_EqiClass_Schedul()
        {
            daCostingEqiClass.Fill(dsCostingEqiClass1);
        }

        public void LoadCostingEqiClass(int pPriID, bool bReadOnly)
        {
            _pri_id = pPriID;

            dsEquipClasses1.Clear();
            daEquipClasses.Fill(dsEquipClasses1);

            try
            {
               dsCostingEqiClass1.Clear();
                daCostingEqiClass.SelectCommand.Parameters["@priID"].Value = pPriID;
                daCostingEqiClass.Fill(dsCostingEqiClass1);
            }
            catch(Exception ex)
            {
               MessageBox.Show("exception found:" + ex.StackTrace.ToString());
            }
            if (bReadOnly)
            {
                gvEqiClass.OptionsBehavior.Editable = false;
                fGGEqiClass.Event_ProcessGridKey_Enabled = false;
                btnLoadEqiClasses.Enabled = false;

            }
            else
            {
                gvEqiClass.OptionsBehavior.Editable = true;
                fGGEqiClass.Event_ProcessGridKey_Enabled = true;
                btnLoadEqiClasses.Enabled = true;
            }
        }

        private void gvEqiClass_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gvEqiClass.GetDataRow(e.RowHandle)["pri_id"] = _pri_id;
            gvEqiClass.GetDataRow(e.RowHandle)["rate"] = 0.00;
            gvEqiClass.GetDataRow(e.RowHandle)["CostRate"] = 0.00;
            gvEqiClass.GetDataRow(e.RowHandle)["UseEquipOverride"] = false;
            LoadRateSchedule(-1);
        }

        private void rilueEquipClasses_Enter(object sender, EventArgs e)
        {
            string sfa_class = "";
            try { sfa_class = gvEqiClass.GetDataRow(gvEqiClass.FocusedRowHandle)["eqi_Class"].ToString(); }
            catch { }

            DataTable dtFilteredList = hmConn.SQLExecutor.ExecuteDataAdapter("SELECT facl_code, facl_desc FROM fa_class Where facl_code not in (Select eqi_Class From costing_equipment_class where pri_id = " + _pri_id.ToString() + " and eqi_Class <> '" + sfa_class + "') ORDER BY facl_code", hmConn.TRConnection);
            ((DevExpress.XtraEditors.LookUpEdit)sender).Properties.DataSource = dtFilteredList;
        }

        private void gvEqiClass_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (coleqi_Class == e.Column)
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    string sEqi_Class = "";
                    try { sEqi_Class = e.Value.ToString(); }
                    catch { }

                    DataTable dtWorkClassData = hmConn.SQLExecutor.ExecuteDataAdapter("Select IsNull(facl_desc,'') [facl_desc], IsNull(fac_bill_out,0) [fac_bill_out], IsNull(fac_cost_rate,0) [fac_cost_rate] from fa_class where facl_code = '" + sEqi_Class + "' ", hmConn.TRConnection);
                    if (dtWorkClassData.Rows.Count == 0)
                    {
                        gvEqiClass.SetFocusedRowCellValue(colrate, 0.00);
                        gvEqiClass.SetFocusedRowCellValue(colCostRate, 0.00);
                        gvEqiClass.SetFocusedRowCellValue(colUseEquipOverride, "F");
                    }
                    else
                    {
                        gvEqiClass.SetFocusedRowCellValue(colrate_desc, dtWorkClassData.Rows[0]["facl_desc"]);
                        gvEqiClass.SetFocusedRowCellValue(colrate, dtWorkClassData.Rows[0]["fac_bill_out"]);
                        gvEqiClass.SetFocusedRowCellValue(colCostRate, dtWorkClassData.Rows[0]["fac_cost_rate"]);
                        gvEqiClass.SetFocusedRowCellValue(colUseEquipOverride, "F");
                    }
                }
            }
        }

        private void gvEqiClass_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (gvEqiClass.GetDataRow(e.RowHandle) != null)
            {
                if (gvEqiClass.GetDataRow(e.RowHandle)["eqi_Class"] == DBNull.Value || gvEqiClass.GetDataRow(e.RowHandle)["eqi_Class"] == null)
                {
                    e.Valid = false;
                    e.ErrorText = "Code cannot be blank.";
                }

                double dRate = 0;

                if (e.Valid)
                {
                    if (gvEqiClass.GetDataRow(e.RowHandle)["rate"] == DBNull.Value || gvEqiClass.GetDataRow(e.RowHandle)["rate"] == null)
                    {
                        e.ErrorText = "Billing rate cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvEqiClass.GetDataRow(e.RowHandle)["rate"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Billing rate cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                if (e.Valid)
                {
                    if (gvEqiClass.GetDataRow(e.RowHandle)["CostRate"] == DBNull.Value || gvEqiClass.GetDataRow(e.RowHandle)["CostRate"] == null)
                    {
                        e.ErrorText = "Cost rate cannot be blank.";
                        e.Valid = false;
                    }
                    else
                    {
                        try { dRate = Convert.ToDouble(gvEqiClass.GetDataRow(e.RowHandle)["CostRate"]); }
                        catch { }

                        if (dRate < 0)
                        {
                            e.ErrorText = "Cost rate cannot be negative.";
                            e.Valid = false;
                        }
                    }
                }

                // validation on 'Scheduled' column value
                if (e.Valid)
                {
                    object oSchedulingProposed = false;
                    object oScheduling = false;
                    try
                    {
                        oSchedulingProposed = gvEqiClass.GetDataRow(e.RowHandle)[colsch_enabled.FieldName, DataRowVersion.Proposed];
                    } catch { }
                    try
                    {
                        oScheduling = gvEqiClass.GetDataRow(e.RowHandle)[colsch_enabled.FieldName, DataRowVersion.Current];
                    } catch { }

                    object cer_id = -1;

                    if (oSchedulingProposed == null || oSchedulingProposed == DBNull.Value)
                        oSchedulingProposed = false;
                    if (oScheduling == null || oScheduling == DBNull.Value)
                        oScheduling = false;


                    if (gvEqiClass.GetDataRow(e.RowHandle)[colcer_id.FieldName] != null)
                    {
                        cer_id = gvEqiClass.GetDataRow(e.RowHandle)[colcer_id.FieldName];
                    }

                    if (Convert.ToBoolean(oSchedulingProposed) == false)
                    {
                        if (IsCostingClassScheduledWithEquipment(Convert.ToInt32(cer_id)))
                        {
                            string msg = "Equipment have been scheduled against the selected equipment class. By disabling scheduling, note that the existing scheduled equipment will be removed. " + Environment.NewLine + "Are you sure you want to continue ?";

                            if (Popups.ShowPopup(msg, "Warning", WS_Popups.frmPopup.PopupType.OK_Cancel) == WS_Popups.frmPopup.PopupResult.OK)
                            {
                                // delete all records from the tr.costing_equipment_class_equip
                                hmConn.SQLExecutor.ExecuteNonQuery("DELETE FROM costing_equipment_class_equip WHERE cer_id = " + cer_id, hmConn.TRConnection);
                            }
                            else
                            {
                                gvEqiClass.SetFocusedRowCellValue(colsch_enabled, oScheduling);
                            }

                        }
                    }
                }



            }

            if (!e.Valid)
                bCustomErrorMsg = true;

            //DataRow dr = gvEqiClass.GetDataRow(e.RowHandle);
            //if (dr != null)
            //{
            //    double dRate = 0;
            //    object objResult = dr["rate"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Billing Rate cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }
            //    objResult = dr["costrate"];
            //    if (objResult != null && objResult != DBNull.Value)
            //    {
            //        dRate = Convert.ToDouble(objResult);

            //    }
            //    if (dRate < 0)
            //    {
            //        Popups.ShowPopup("Cost Rate cannot be negative.");
            //        e.Valid = false;
            //        return;
            //    }


            //}
        }

        private void gvEqiClass_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //daCostingEqiClass.Update(dsCostingEqiClass1.costing_equipment_class);
        }

        private void gvEqiClass_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (bCustomErrorMsg)
            {
                bCustomErrorMsg = false;
                Popups.ShowPopup(e.ErrorText);
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
        }

        private bool fGGEqiClass_AllowDelete(object sender, DataRow row)
        {
            //May need to add more validation for delete verification
            if (Popups.ShowPopup("Are you sure you wish to delete this equipment class?", WS_Popups.frmPopup.PopupType.Yes_No) == WS_Popups.frmPopup.PopupResult.Yes)
            {
                if (eqiClassRateSchedule != null)
                    eqiClassRateSchedule.DeleteRateSchedule();

                return true;
            }
            return false;
        }

      

        private void btnLoadEqiClasses_Click(object sender, EventArgs e)
        {
            using (frmLoadEquiClasses LoadEquipClasses = new frmLoadEquiClasses(hmConn, hmDevMgr, _pri_id))
            {
                if (LoadEquipClasses.ShowDialog() == DialogResult.OK)
                {
                    dsCostingEqiClass1.Clear();
                    daCostingEqiClass.SelectCommand.Parameters["@priID"].Value = _pri_id;
                    daCostingEqiClass.Fill(dsCostingEqiClass1);
                }
            }
        }

        private bool IsCostingClassScheduledWithEquipment(int costingEquipmentClassID)
        {
            bool isScheduled = false;

            string cmdText = @" select cece.* from costing_equipment_class_equip cece
                                inner join costing_equipment_class cec on cece.cer_id = cec.cer_id
                                where cece.cer_id = " + costingEquipmentClassID.ToString();

            System.Data.DataTable dt = hmConn.SQLExecutor.ExecuteDataAdapter(cmdText, hmConn.TRConnection);

            if (dt != null && dt.Rows.Count > 0)
            {
                isScheduled = true;
            }

            return isScheduled;
        }

        private void rilue_UOM_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                gvEqiClass.SetFocusedRowCellValue(colUOM, null);
                gvEqiClass.UpdateCurrentRow();
            }
        }

        private void gvEqiClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int cer_id = -1;
            DataRow dr = gvEqiClass.GetDataRow(e.FocusedRowHandle);
            if ( dr != null)
            {
                if (e.FocusedRowHandle >= 0)
                {
                    if (dr["cer_id"] != null && dr["cer_id"] != DBNull.Value)
                        cer_id = Convert.ToInt32(dr["cer_id"]);
                }
            }
            LoadRateSchedule(cer_id);
        }

        private void LoadRateSchedule(int cer_id)
        {
            if (eqiClassRateSchedule != null)
            {
                eqiClassRateSchedule.LoadRateSchedule(cer_id);
                try
                {
                    if (cer_id > 0)
                        daCostingEqiClass.Fill(dsCostingEqiClass1);
                }
                catch
                {

                }
            }
            
        }

        



        //
    }
}
