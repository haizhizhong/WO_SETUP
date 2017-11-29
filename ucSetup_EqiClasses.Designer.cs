namespace WO_Setup
{
    partial class ucSetup_EqiClasses
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSetup_EqiClasses));
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.gcEqiClass = new DevExpress.XtraGrid.GridControl();
            this.dsCostingEqiClass1 = new WO_Setup.dsCostingEqiClass();
            this.gvEqiClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coleqi_Class = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueEquipClasses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.faclassBindingSource = new System.Windows.Forms.BindingSource();
            this.dsEquipClasses1 = new WO_Setup.dsEquipClasses();
            this.colrate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCostRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUseEquipOverride = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceUseEqiOverride = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colrate_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsch_enabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceScheduling = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colcer_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilue_UOM = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.unittimemeasurementBindingSource = new System.Windows.Forms.BindingSource();
            this.dsUnitTimeMeasurement1 = new WO_Setup.dsUnitTimeMeasurement();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daCostingEqiClass = new System.Data.SqlClient.SqlDataAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadEqiClasses = new DevExpress.XtraEditors.SimpleButton();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daEquipClasses = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand_daUnitTimeMeasurement = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand_daUnitTimeMeasurement = new System.Data.SqlClient.SqlCommand();
            this.daUnitTimeMeasurement = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcRateSchedule = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcEqiClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostingEqiClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEqiClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEquipClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquipClasses1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUseEqiOverride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceScheduling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilue_UOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unittimemeasurementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitTimeMeasurement1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRateSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=dev12;Initial Catalog=TR_Test_V11;Persist Security Info=True;User ID=" +
    "hmsqlsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // gcEqiClass
            // 
            this.gcEqiClass.DataMember = "costing_equipment_class";
            this.gcEqiClass.DataSource = this.dsCostingEqiClass1;
            this.gcEqiClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEqiClass.Location = new System.Drawing.Point(0, 37);
            this.gcEqiClass.MainView = this.gvEqiClass;
            this.gcEqiClass.Name = "gcEqiClass";
            this.gcEqiClass.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDecimal,
            this.ceUseEqiOverride,
            this.rilueEquipClasses,
            this.riceScheduling,
            this.rilue_UOM});
            this.gcEqiClass.Size = new System.Drawing.Size(769, 495);
            this.gcEqiClass.TabIndex = 0;
            this.gcEqiClass.UseEmbeddedNavigator = true;
            this.gcEqiClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEqiClass});
            // 
            // dsCostingEqiClass1
            // 
            this.dsCostingEqiClass1.DataSetName = "dsCostingEqiClass";
            this.dsCostingEqiClass1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEqiClass
            // 
            this.gvEqiClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coleqi_Class,
            this.colrate,
            this.colCostRate,
            this.colUseEquipOverride,
            this.colrate_desc,
            this.colsch_enabled,
            this.colcer_id,
            this.colUOM});
            this.gvEqiClass.GridControl = this.gcEqiClass;
            this.gvEqiClass.Name = "gvEqiClass";
            this.gvEqiClass.OptionsView.ColumnAutoWidth = false;
            this.gvEqiClass.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvEqiClass_InitNewRow);
            this.gvEqiClass.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvEqiClass_FocusedRowChanged);
            this.gvEqiClass.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvEqiClass_CellValueChanged);
            this.gvEqiClass.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvEqiClass_InvalidRowException);
            this.gvEqiClass.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvEqiClass_ValidateRow);
            this.gvEqiClass.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvEqiClass_RowUpdated);
            // 
            // coleqi_Class
            // 
            this.coleqi_Class.Caption = "Class";
            this.coleqi_Class.ColumnEdit = this.rilueEquipClasses;
            this.coleqi_Class.FieldName = "eqi_Class";
            this.coleqi_Class.Name = "coleqi_Class";
            this.coleqi_Class.Visible = true;
            this.coleqi_Class.VisibleIndex = 0;
            this.coleqi_Class.Width = 82;
            // 
            // rilueEquipClasses
            // 
            this.rilueEquipClasses.AutoHeight = false;
            this.rilueEquipClasses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueEquipClasses.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("facl_code", "Code", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("facl_desc", "Description", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueEquipClasses.DataSource = this.faclassBindingSource;
            this.rilueEquipClasses.DisplayMember = "facl_code";
            this.rilueEquipClasses.Name = "rilueEquipClasses";
            this.rilueEquipClasses.NullText = "";
            this.rilueEquipClasses.PopupWidth = 300;
            this.rilueEquipClasses.ValueMember = "facl_code";
            this.rilueEquipClasses.Enter += new System.EventHandler(this.rilueEquipClasses_Enter);
            // 
            // faclassBindingSource
            // 
            this.faclassBindingSource.DataMember = "fa_class";
            this.faclassBindingSource.DataSource = this.dsEquipClasses1;
            // 
            // dsEquipClasses1
            // 
            this.dsEquipClasses1.DataSetName = "dsEquipClasses";
            this.dsEquipClasses1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colrate
            // 
            this.colrate.Caption = "Billing Rate";
            this.colrate.ColumnEdit = this.txtDecimal;
            this.colrate.FieldName = "rate";
            this.colrate.Name = "colrate";
            this.colrate.Visible = true;
            this.colrate.VisibleIndex = 2;
            this.colrate.Width = 74;
            // 
            // txtDecimal
            // 
            this.txtDecimal.AutoHeight = false;
            this.txtDecimal.Mask.EditMask = "n2";
            this.txtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.txtDecimal.Name = "txtDecimal";
            // 
            // colCostRate
            // 
            this.colCostRate.Caption = "Cost Rate";
            this.colCostRate.ColumnEdit = this.txtDecimal;
            this.colCostRate.FieldName = "CostRate";
            this.colCostRate.Name = "colCostRate";
            this.colCostRate.Visible = true;
            this.colCostRate.VisibleIndex = 3;
            this.colCostRate.Width = 64;
            // 
            // colUseEquipOverride
            // 
            this.colUseEquipOverride.Caption = "Use Equipment Override";
            this.colUseEquipOverride.ColumnEdit = this.ceUseEqiOverride;
            this.colUseEquipOverride.FieldName = "UseEquipOverride";
            this.colUseEquipOverride.Name = "colUseEquipOverride";
            this.colUseEquipOverride.Visible = true;
            this.colUseEquipOverride.VisibleIndex = 4;
            this.colUseEquipOverride.Width = 126;
            // 
            // ceUseEqiOverride
            // 
            this.ceUseEqiOverride.AutoHeight = false;
            this.ceUseEqiOverride.Name = "ceUseEqiOverride";
            this.ceUseEqiOverride.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.ceUseEqiOverride.ValueChecked = "T";
            this.ceUseEqiOverride.ValueUnchecked = "F";
            // 
            // colrate_desc
            // 
            this.colrate_desc.Caption = "Description";
            this.colrate_desc.FieldName = "rate_desc";
            this.colrate_desc.Name = "colrate_desc";
            this.colrate_desc.OptionsColumn.AllowEdit = false;
            this.colrate_desc.Visible = true;
            this.colrate_desc.VisibleIndex = 1;
            this.colrate_desc.Width = 211;
            // 
            // colsch_enabled
            // 
            this.colsch_enabled.Caption = "Scheduling";
            this.colsch_enabled.ColumnEdit = this.riceScheduling;
            this.colsch_enabled.FieldName = "sch_enabled";
            this.colsch_enabled.Name = "colsch_enabled";
            this.colsch_enabled.Visible = true;
            this.colsch_enabled.VisibleIndex = 5;
            this.colsch_enabled.Width = 82;
            // 
            // riceScheduling
            // 
            this.riceScheduling.AutoHeight = false;
            this.riceScheduling.Name = "riceScheduling";
            this.riceScheduling.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colcer_id
            // 
            this.colcer_id.FieldName = "cer_id";
            this.colcer_id.Name = "colcer_id";
            this.colcer_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colUOM
            // 
            this.colUOM.Caption = "UOM";
            this.colUOM.ColumnEdit = this.rilue_UOM;
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 6;
            // 
            // rilue_UOM
            // 
            this.rilue_UOM.AutoHeight = false;
            this.rilue_UOM.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.rilue_UOM.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.rilue_UOM.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TimeDescription", "UOM", 88, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilue_UOM.DataSource = this.unittimemeasurementBindingSource;
            this.rilue_UOM.DisplayMember = "TimeDescription";
            this.rilue_UOM.Name = "rilue_UOM";
            this.rilue_UOM.NullText = "";
            this.rilue_UOM.ValueMember = "Id";
            this.rilue_UOM.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rilue_UOM_ButtonClick);
            // 
            // unittimemeasurementBindingSource
            // 
            this.unittimemeasurementBindingSource.DataMember = "unit_time_measurement";
            this.unittimemeasurementBindingSource.DataSource = this.dsUnitTimeMeasurement1;
            // 
            // dsUnitTimeMeasurement1
            // 
            this.dsUnitTimeMeasurement1.DataSetName = "dsUnitTimeMeasurement";
            this.dsUnitTimeMeasurement1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priID", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@eqi_Class", System.Data.SqlDbType.VarChar, 0, "eqi_Class"),
            new System.Data.SqlClient.SqlParameter("@rate", System.Data.SqlDbType.Money, 0, "rate"),
            new System.Data.SqlClient.SqlParameter("@ber_type", System.Data.SqlDbType.Char, 0, "ber_type"),
            new System.Data.SqlClient.SqlParameter("@rate_desc", System.Data.SqlDbType.VarChar, 0, "rate_desc"),
            new System.Data.SqlClient.SqlParameter("@CostRate", System.Data.SqlDbType.Money, 0, "CostRate"),
            new System.Data.SqlClient.SqlParameter("@UseEquipOverride", System.Data.SqlDbType.Char, 0, "UseEquipOverride"),
            new System.Data.SqlClient.SqlParameter("@sch_enabled", System.Data.SqlDbType.Bit, 0, "sch_enabled"),
            new System.Data.SqlClient.SqlParameter("@sch_bud_hrs_reg", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "sch_bud_hrs_reg", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@UOM", System.Data.SqlDbType.Int, 0, "UOM")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@eqi_Class", System.Data.SqlDbType.VarChar, 0, "eqi_Class"),
            new System.Data.SqlClient.SqlParameter("@rate", System.Data.SqlDbType.Money, 0, "rate"),
            new System.Data.SqlClient.SqlParameter("@ber_type", System.Data.SqlDbType.Char, 0, "ber_type"),
            new System.Data.SqlClient.SqlParameter("@rate_desc", System.Data.SqlDbType.VarChar, 0, "rate_desc"),
            new System.Data.SqlClient.SqlParameter("@CostRate", System.Data.SqlDbType.Money, 0, "CostRate"),
            new System.Data.SqlClient.SqlParameter("@UseEquipOverride", System.Data.SqlDbType.Char, 0, "UseEquipOverride"),
            new System.Data.SqlClient.SqlParameter("@sch_enabled", System.Data.SqlDbType.Bit, 0, "sch_enabled"),
            new System.Data.SqlClient.SqlParameter("@sch_bud_hrs_reg", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "sch_bud_hrs_reg", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@UOM", System.Data.SqlDbType.Int, 0, "UOM"),
            new System.Data.SqlClient.SqlParameter("@Original_cer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cer_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_eqi_Class", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "eqi_Class", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ber_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ber_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ber_type", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ber_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rate_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rate_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rate_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rate_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostRate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostRate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostRate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostRate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UseEquipOverride", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UseEquipOverride", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UseEquipOverride", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseEquipOverride", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sch_enabled", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sch_enabled", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sch_bud_hrs_reg", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sch_bud_hrs_reg", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sch_bud_hrs_reg", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "sch_bud_hrs_reg", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UOM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UOM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UOM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UOM", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@cer_id", System.Data.SqlDbType.Int, 4, "cer_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_cer_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cer_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_eqi_Class", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "eqi_Class", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ber_type", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ber_type", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ber_type", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ber_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_rate_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "rate_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_rate_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "rate_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CostRate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CostRate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CostRate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CostRate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UseEquipOverride", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UseEquipOverride", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UseEquipOverride", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UseEquipOverride", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sch_enabled", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sch_enabled", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sch_bud_hrs_reg", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sch_bud_hrs_reg", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sch_bud_hrs_reg", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "sch_bud_hrs_reg", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_UOM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "UOM", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_UOM", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UOM", System.Data.DataRowVersion.Original, null)});
            // 
            // daCostingEqiClass
            // 
            this.daCostingEqiClass.DeleteCommand = this.sqlDeleteCommand1;
            this.daCostingEqiClass.InsertCommand = this.sqlInsertCommand1;
            this.daCostingEqiClass.SelectCommand = this.sqlSelectCommand1;
            this.daCostingEqiClass.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "costing_equipment_class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cer_id", "cer_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("eqi_Class", "eqi_Class"),
                        new System.Data.Common.DataColumnMapping("rate", "rate"),
                        new System.Data.Common.DataColumnMapping("ber_type", "ber_type"),
                        new System.Data.Common.DataColumnMapping("rate_desc", "rate_desc"),
                        new System.Data.Common.DataColumnMapping("CostRate", "CostRate"),
                        new System.Data.Common.DataColumnMapping("UseEquipOverride", "UseEquipOverride"),
                        new System.Data.Common.DataColumnMapping("sch_enabled", "sch_enabled"),
                        new System.Data.Common.DataColumnMapping("sch_bud_hrs_reg", "sch_bud_hrs_reg"),
                        new System.Data.Common.DataColumnMapping("UOM", "UOM")})});
            this.daCostingEqiClass.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadEqiClasses);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(769, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // btnLoadEqiClasses
            // 
            this.btnLoadEqiClasses.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoadEqiClasses.Location = new System.Drawing.Point(632, 2);
            this.btnLoadEqiClasses.Name = "btnLoadEqiClasses";
            this.btnLoadEqiClasses.Size = new System.Drawing.Size(135, 33);
            this.btnLoadEqiClasses.TabIndex = 1;
            this.btnLoadEqiClasses.Text = "Load Equipment Classes";
            this.btnLoadEqiClasses.Click += new System.EventHandler(this.btnLoadEqiClasses_Click);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     facl_code, facl_desc\r\nFROM         fa_class\r\nORDER BY facl_code";
            this.sqlSelectCommand2.Connection = this.sqlConnTR;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = "INSERT INTO [fa_class] ([facl_code], [facl_desc]) VALUES (@facl_code, @facl_desc)" +
    ";\r\nSELECT facl_code, facl_desc FROM fa_class WHERE (facl_code = @facl_code) ORDE" +
    "R BY facl_code";
            this.sqlInsertCommand2.Connection = this.sqlConnTR;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@facl_code", System.Data.SqlDbType.VarChar, 0, "facl_code"),
            new System.Data.SqlClient.SqlParameter("@facl_desc", System.Data.SqlDbType.VarChar, 0, "facl_desc")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnTR;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@facl_code", System.Data.SqlDbType.VarChar, 0, "facl_code"),
            new System.Data.SqlClient.SqlParameter("@facl_desc", System.Data.SqlDbType.VarChar, 0, "facl_desc"),
            new System.Data.SqlClient.SqlParameter("@Original_facl_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "facl_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_facl_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "facl_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_facl_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "facl_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [fa_class] WHERE (([facl_code] = @Original_facl_code) AND ((@IsNull_f" +
    "acl_desc = 1 AND [facl_desc] IS NULL) OR ([facl_desc] = @Original_facl_desc)))";
            this.sqlDeleteCommand2.Connection = this.sqlConnTR;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_facl_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "facl_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_facl_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "facl_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_facl_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "facl_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // daEquipClasses
            // 
            this.daEquipClasses.DeleteCommand = this.sqlDeleteCommand2;
            this.daEquipClasses.InsertCommand = this.sqlInsertCommand2;
            this.daEquipClasses.SelectCommand = this.sqlSelectCommand2;
            this.daEquipClasses.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "fa_class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("facl_code", "facl_code"),
                        new System.Data.Common.DataColumnMapping("facl_desc", "facl_desc")})});
            this.daEquipClasses.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand_daUnitTimeMeasurement
            // 
            this.sqlSelectCommand_daUnitTimeMeasurement.CommandText = "SELECT        Id, TimeCode, TimeDescription\r\nFROM            unit_time_measuremen" +
    "t\r\nORDER BY TimeDescription";
            this.sqlSelectCommand_daUnitTimeMeasurement.Connection = this.sqlConnTR;
            // 
            // sqlInsertCommand_daUnitTimeMeasurement
            // 
            this.sqlInsertCommand_daUnitTimeMeasurement.CommandText = "INSERT INTO [unit_time_measurement] ([TimeCode], [TimeDescription]) VALUES (@Time" +
    "Code, @TimeDescription)";
            this.sqlInsertCommand_daUnitTimeMeasurement.Connection = this.sqlConnTR;
            this.sqlInsertCommand_daUnitTimeMeasurement.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@TimeCode", System.Data.SqlDbType.VarChar, 0, "TimeCode"),
            new System.Data.SqlClient.SqlParameter("@TimeDescription", System.Data.SqlDbType.VarChar, 0, "TimeDescription")});
            // 
            // daUnitTimeMeasurement
            // 
            this.daUnitTimeMeasurement.InsertCommand = this.sqlInsertCommand_daUnitTimeMeasurement;
            this.daUnitTimeMeasurement.SelectCommand = this.sqlSelectCommand_daUnitTimeMeasurement;
            this.daUnitTimeMeasurement.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "unit_time_measurement", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Id", "Id"),
                        new System.Data.Common.DataColumnMapping("TimeCode", "TimeCode"),
                        new System.Data.Common.DataColumnMapping("TimeDescription", "TimeDescription")})});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand3;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand3;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand3;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcEqiClass);
            this.splitContainerControl1.Panel1.Controls.Add(this.panelControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcRateSchedule);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1202, 532);
            this.splitContainerControl1.SplitterPosition = 769;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcRateSchedule
            // 
            this.gcRateSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcRateSchedule.Location = new System.Drawing.Point(0, 0);
            this.gcRateSchedule.Name = "gcRateSchedule";
            this.gcRateSchedule.Size = new System.Drawing.Size(428, 258);
            this.gcRateSchedule.TabIndex = 0;
            this.gcRateSchedule.Text = "Detail Rate Schedule";
            // 
            // ucSetup_EqiClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucSetup_EqiClasses";
            this.Size = new System.Drawing.Size(1202, 532);
            this.Load += new System.EventHandler(this.ucSetup_EqiClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEqiClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostingEqiClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEqiClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueEquipClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEquipClasses1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUseEqiOverride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceScheduling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilue_UOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unittimemeasurementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsUnitTimeMeasurement1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRateSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private DevExpress.XtraGrid.GridControl gcEqiClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEqiClass;
        private dsCostingEqiClass dsCostingEqiClass1;
        private DevExpress.XtraGrid.Columns.GridColumn coleqi_Class;
        private DevExpress.XtraGrid.Columns.GridColumn colrate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDecimal;
        private DevExpress.XtraGrid.Columns.GridColumn colCostRate;
        private DevExpress.XtraGrid.Columns.GridColumn colUseEquipOverride;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daCostingEqiClass;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceUseEqiOverride;
        private DevExpress.XtraGrid.Columns.GridColumn colrate_desc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadEqiClasses;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueEquipClasses;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daEquipClasses;
        private dsEquipClasses dsEquipClasses1;
        private System.Windows.Forms.BindingSource faclassBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colsch_enabled;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceScheduling;
        private DevExpress.XtraGrid.Columns.GridColumn colcer_id;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilue_UOM;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand_daUnitTimeMeasurement;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand_daUnitTimeMeasurement;
        private System.Data.SqlClient.SqlDataAdapter daUnitTimeMeasurement;
        private dsUnitTimeMeasurement dsUnitTimeMeasurement1;
        private System.Windows.Forms.BindingSource unittimemeasurementBindingSource;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl gcRateSchedule;
    }
}
