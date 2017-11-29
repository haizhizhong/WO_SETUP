namespace WO_Setup
{
    partial class ucSetup_WorkClasses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSetup_WorkClasses));
            this.gcWorkClasses = new DevExpress.XtraGrid.GridControl();
            this.dsCostingWorkClass1 = new WO_Setup.dsCostingWorkClass();
            this.gvWorkClasses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcwc_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWC_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueWorkClasses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.workclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWorkClasses1 = new WO_Setup.dsWorkClasses();
            this.grdColDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStandard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colOverTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDoubleTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTravelTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsch_enabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riceScheduling = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colceilingcost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteCeilingCost = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand_daCostingWorkClass = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand_daCostingWorkClass = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand_daCostingWorkClass = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand_daCostingWorkClass = new System.Data.SqlClient.SqlCommand();
            this.daCostingWorkClass = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daWorkClasses = new System.Data.SqlClient.SqlDataAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadWorkClasses = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostingWorkClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueWorkClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkClasses1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceScheduling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteCeilingCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcWorkClasses
            // 
            this.gcWorkClasses.DataMember = "costing_work_class";
            this.gcWorkClasses.DataSource = this.dsCostingWorkClass1;
            this.gcWorkClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWorkClasses.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcWorkClasses_EmbeddedNavigator_ButtonClick);
            this.gcWorkClasses.Location = new System.Drawing.Point(0, 37);
            this.gcWorkClasses.MainView = this.gvWorkClasses;
            this.gcWorkClasses.Name = "gcWorkClasses";
            this.gcWorkClasses.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riteDecimal,
            this.rilueWorkClasses,
            this.riceScheduling,
            this.riteCeilingCost});
            this.gcWorkClasses.Size = new System.Drawing.Size(1113, 535);
            this.gcWorkClasses.TabIndex = 0;
            this.gcWorkClasses.UseEmbeddedNavigator = true;
            this.gcWorkClasses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkClasses});
            // 
            // dsCostingWorkClass1
            // 
            this.dsCostingWorkClass1.DataSetName = "dsCostingWorkClass";
            this.dsCostingWorkClass1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvWorkClasses
            // 
            this.gvWorkClasses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcwc_id,
            this.colWC_Code,
            this.grdColDesc,
            this.colStandard,
            this.colOverTime,
            this.colDoubleTime,
            this.colTravelTime,
            this.colsch_enabled,
            this.colceilingcost});
            this.gvWorkClasses.GridControl = this.gcWorkClasses;
            this.gvWorkClasses.Name = "gvWorkClasses";
            this.gvWorkClasses.OptionsView.ColumnAutoWidth = false;
            this.gvWorkClasses.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvWorkClasses_CustomUnboundColumnData);
            this.gvWorkClasses.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvWorkClasses_CellValueChanged);
            this.gvWorkClasses.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvWorkClasses_InitNewRow);
            this.gvWorkClasses.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvWorkClasses_InvalidRowException);
            this.gvWorkClasses.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvWorkClasses_ValidateRow);
            // 
            // colcwc_id
            // 
            this.colcwc_id.FieldName = "cwc_id";
            this.colcwc_id.Name = "colcwc_id";
            this.colcwc_id.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colWC_Code
            // 
            this.colWC_Code.Caption = "Code";
            this.colWC_Code.ColumnEdit = this.rilueWorkClasses;
            this.colWC_Code.FieldName = "WC_Code";
            this.colWC_Code.Name = "colWC_Code";
            this.colWC_Code.Visible = true;
            this.colWC_Code.VisibleIndex = 0;
            this.colWC_Code.Width = 100;
            // 
            // rilueWorkClasses
            // 
            this.rilueWorkClasses.AutoHeight = false;
            this.rilueWorkClasses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueWorkClasses.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("wc_code", "Code", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("wc_desc", "Description", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueWorkClasses.DataSource = this.workclassBindingSource;
            this.rilueWorkClasses.DisplayMember = "wc_code";
            this.rilueWorkClasses.Name = "rilueWorkClasses";
            this.rilueWorkClasses.NullText = "";
            this.rilueWorkClasses.PopupWidth = 300;
            this.rilueWorkClasses.ValueMember = "wc_code";
            this.rilueWorkClasses.Enter += new System.EventHandler(this.rilueWorkClasses_Enter);
            // 
            // workclassBindingSource
            // 
            this.workclassBindingSource.DataMember = "work_class";
            this.workclassBindingSource.DataSource = this.dsWorkClasses1;
            // 
            // dsWorkClasses1
            // 
            this.dsWorkClasses1.DataSetName = "dsWorkClasses";
            this.dsWorkClasses1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdColDesc
            // 
            this.grdColDesc.Caption = "Description";
            this.grdColDesc.FieldName = "Description";
            this.grdColDesc.Name = "grdColDesc";
            this.grdColDesc.OptionsColumn.AllowEdit = false;
            this.grdColDesc.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.grdColDesc.Visible = true;
            this.grdColDesc.VisibleIndex = 1;
            this.grdColDesc.Width = 250;
            // 
            // colStandard
            // 
            this.colStandard.Caption = "Regular";
            this.colStandard.ColumnEdit = this.riteDecimal;
            this.colStandard.FieldName = "Standard";
            this.colStandard.Name = "colStandard";
            this.colStandard.Visible = true;
            this.colStandard.VisibleIndex = 2;
            this.colStandard.Width = 100;
            // 
            // riteDecimal
            // 
            this.riteDecimal.AutoHeight = false;
            this.riteDecimal.Mask.EditMask = "n2";
            this.riteDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.riteDecimal.Name = "riteDecimal";
            // 
            // colOverTime
            // 
            this.colOverTime.Caption = "Overtime";
            this.colOverTime.ColumnEdit = this.riteDecimal;
            this.colOverTime.FieldName = "OverTime";
            this.colOverTime.Name = "colOverTime";
            this.colOverTime.Visible = true;
            this.colOverTime.VisibleIndex = 3;
            this.colOverTime.Width = 100;
            // 
            // colDoubleTime
            // 
            this.colDoubleTime.ColumnEdit = this.riteDecimal;
            this.colDoubleTime.FieldName = "DoubleTime";
            this.colDoubleTime.Name = "colDoubleTime";
            this.colDoubleTime.Visible = true;
            this.colDoubleTime.VisibleIndex = 4;
            this.colDoubleTime.Width = 100;
            // 
            // colTravelTime
            // 
            this.colTravelTime.ColumnEdit = this.riteDecimal;
            this.colTravelTime.FieldName = "TravelTime";
            this.colTravelTime.Name = "colTravelTime";
            this.colTravelTime.Visible = true;
            this.colTravelTime.VisibleIndex = 5;
            this.colTravelTime.Width = 100;
            // 
            // colsch_enabled
            // 
            this.colsch_enabled.Caption = "Scheduling";
            this.colsch_enabled.ColumnEdit = this.riceScheduling;
            this.colsch_enabled.FieldName = "sch_enabled";
            this.colsch_enabled.Name = "colsch_enabled";
            this.colsch_enabled.Visible = true;
            this.colsch_enabled.VisibleIndex = 7;
            this.colsch_enabled.Width = 100;
            // 
            // riceScheduling
            // 
            this.riceScheduling.AutoHeight = false;
            this.riceScheduling.Name = "riceScheduling";
            this.riceScheduling.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colceilingcost
            // 
            this.colceilingcost.Caption = "Ceiling Cost";
            this.colceilingcost.ColumnEdit = this.riteCeilingCost;
            this.colceilingcost.FieldName = "ceilingcost";
            this.colceilingcost.Name = "colceilingcost";
            this.colceilingcost.Visible = true;
            this.colceilingcost.VisibleIndex = 6;
            this.colceilingcost.Width = 100;
            // 
            // riteCeilingCost
            // 
            this.riteCeilingCost.AutoHeight = false;
            this.riteCeilingCost.DisplayFormat.FormatString = "{0:n2}";
            this.riteCeilingCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riteCeilingCost.Mask.EditMask = "n2";
            this.riteCeilingCost.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riteCeilingCost.Mask.UseMaskAsDisplayFormat = true;
            this.riteCeilingCost.Name = "riteCeilingCost";
            this.riteCeilingCost.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.riteCeilingCost_EditValueChanging);
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=dev11;Initial Catalog=tr_strike_test10;Persist Security Info=True;Use" +
                "r ID=hmsqlsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand_daCostingWorkClass
            // 
            this.sqlSelectCommand_daCostingWorkClass.CommandText = "SELECT        cwc_id, WC_Code, pri_id, Standard, OverTime, DoubleTime, TravelTime" +
                ", sch_enabled, ceilingcost\r\nFROM            costing_work_class\r\nWHERE        (pr" +
                "i_id = @priID)\r\nORDER BY WC_Code";
            this.sqlSelectCommand_daCostingWorkClass.Connection = this.sqlConnTR;
            this.sqlSelectCommand_daCostingWorkClass.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priID", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlInsertCommand_daCostingWorkClass
            // 
            this.sqlInsertCommand_daCostingWorkClass.CommandText = resources.GetString("sqlInsertCommand_daCostingWorkClass.CommandText");
            this.sqlInsertCommand_daCostingWorkClass.Connection = this.sqlConnTR;
            this.sqlInsertCommand_daCostingWorkClass.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@WC_Code", System.Data.SqlDbType.VarChar, 0, "WC_Code"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Float, 0, "Standard"),
            new System.Data.SqlClient.SqlParameter("@OverTime", System.Data.SqlDbType.Float, 0, "OverTime"),
            new System.Data.SqlClient.SqlParameter("@DoubleTime", System.Data.SqlDbType.Float, 0, "DoubleTime"),
            new System.Data.SqlClient.SqlParameter("@TravelTime", System.Data.SqlDbType.Float, 0, "TravelTime"),
            new System.Data.SqlClient.SqlParameter("@sch_enabled", System.Data.SqlDbType.Bit, 0, "sch_enabled"),
            new System.Data.SqlClient.SqlParameter("@ceilingcost", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "ceilingcost", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand_daCostingWorkClass
            // 
            this.sqlUpdateCommand_daCostingWorkClass.CommandText = resources.GetString("sqlUpdateCommand_daCostingWorkClass.CommandText");
            this.sqlUpdateCommand_daCostingWorkClass.Connection = this.sqlConnTR;
            this.sqlUpdateCommand_daCostingWorkClass.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@WC_Code", System.Data.SqlDbType.VarChar, 0, "WC_Code"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@Standard", System.Data.SqlDbType.Float, 0, "Standard"),
            new System.Data.SqlClient.SqlParameter("@OverTime", System.Data.SqlDbType.Float, 0, "OverTime"),
            new System.Data.SqlClient.SqlParameter("@DoubleTime", System.Data.SqlDbType.Float, 0, "DoubleTime"),
            new System.Data.SqlClient.SqlParameter("@TravelTime", System.Data.SqlDbType.Float, 0, "TravelTime"),
            new System.Data.SqlClient.SqlParameter("@sch_enabled", System.Data.SqlDbType.Bit, 0, "sch_enabled"),
            new System.Data.SqlClient.SqlParameter("@ceilingcost", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "ceilingcost", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_cwc_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cwc_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_WC_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WC_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Standard", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Standard", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OverTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OverTime", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DoubleTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DoubleTime", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TravelTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TravelTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TravelTime", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TravelTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sch_enabled", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sch_enabled", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ceilingcost", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ceilingcost", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ceilingcost", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "ceilingcost", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@cwc_id", System.Data.SqlDbType.Int, 4, "cwc_id")});
            // 
            // sqlDeleteCommand_daCostingWorkClass
            // 
            this.sqlDeleteCommand_daCostingWorkClass.CommandText = resources.GetString("sqlDeleteCommand_daCostingWorkClass.CommandText");
            this.sqlDeleteCommand_daCostingWorkClass.Connection = this.sqlConnTR;
            this.sqlDeleteCommand_daCostingWorkClass.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_cwc_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cwc_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_WC_Code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "WC_Code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Standard", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Standard", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Standard", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Standard", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OverTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OverTime", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DoubleTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DoubleTime", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_TravelTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TravelTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_TravelTime", System.Data.SqlDbType.Float, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TravelTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_sch_enabled", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_sch_enabled", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "sch_enabled", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ceilingcost", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ceilingcost", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ceilingcost", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(19)), ((byte)(4)), "ceilingcost", System.Data.DataRowVersion.Original, null)});
            // 
            // daCostingWorkClass
            // 
            this.daCostingWorkClass.DeleteCommand = this.sqlDeleteCommand_daCostingWorkClass;
            this.daCostingWorkClass.InsertCommand = this.sqlInsertCommand_daCostingWorkClass;
            this.daCostingWorkClass.SelectCommand = this.sqlSelectCommand_daCostingWorkClass;
            this.daCostingWorkClass.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "costing_work_class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cwc_id", "cwc_id"),
                        new System.Data.Common.DataColumnMapping("WC_Code", "WC_Code"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("Standard", "Standard"),
                        new System.Data.Common.DataColumnMapping("OverTime", "OverTime"),
                        new System.Data.Common.DataColumnMapping("DoubleTime", "DoubleTime"),
                        new System.Data.Common.DataColumnMapping("TravelTime", "TravelTime"),
                        new System.Data.Common.DataColumnMapping("sch_enabled", "sch_enabled"),
                        new System.Data.Common.DataColumnMapping("ceilingcost", "ceilingcost")})});
            this.daCostingWorkClass.UpdateCommand = this.sqlUpdateCommand_daCostingWorkClass;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     wc_co, wc_code, wc_desc\r\nFROM         work_class\r\nORDER BY wc_code";
            this.sqlSelectCommand2.Connection = this.sqlConnTR;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnTR;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@wc_co", System.Data.SqlDbType.Int, 0, "wc_co"),
            new System.Data.SqlClient.SqlParameter("@wc_code", System.Data.SqlDbType.VarChar, 0, "wc_code"),
            new System.Data.SqlClient.SqlParameter("@wc_desc", System.Data.SqlDbType.VarChar, 0, "wc_desc")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnTR;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@wc_co", System.Data.SqlDbType.Int, 0, "wc_co"),
            new System.Data.SqlClient.SqlParameter("@wc_code", System.Data.SqlDbType.VarChar, 0, "wc_code"),
            new System.Data.SqlClient.SqlParameter("@wc_desc", System.Data.SqlDbType.VarChar, 0, "wc_desc"),
            new System.Data.SqlClient.SqlParameter("@Original_wc_co", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_co", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_wc_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wc_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wc_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = "DELETE FROM [work_class] WHERE (([wc_co] = @Original_wc_co) AND ([wc_code] = @Ori" +
                "ginal_wc_code) AND ((@IsNull_wc_desc = 1 AND [wc_desc] IS NULL) OR ([wc_desc] = " +
                "@Original_wc_desc)))";
            this.sqlDeleteCommand2.Connection = this.sqlConnTR;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_wc_co", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_co", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_wc_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wc_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wc_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // daWorkClasses
            // 
            this.daWorkClasses.DeleteCommand = this.sqlDeleteCommand2;
            this.daWorkClasses.InsertCommand = this.sqlInsertCommand2;
            this.daWorkClasses.SelectCommand = this.sqlSelectCommand2;
            this.daWorkClasses.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "work_class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("wc_co", "wc_co"),
                        new System.Data.Common.DataColumnMapping("wc_code", "wc_code"),
                        new System.Data.Common.DataColumnMapping("wc_desc", "wc_desc")})});
            this.daWorkClasses.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1113, 37);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnLoadWorkClasses);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(993, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(118, 33);
            this.panelControl2.TabIndex = 1;
            // 
            // btnLoadWorkClasses
            // 
            this.btnLoadWorkClasses.Location = new System.Drawing.Point(3, 6);
            this.btnLoadWorkClasses.Name = "btnLoadWorkClasses";
            this.btnLoadWorkClasses.Size = new System.Drawing.Size(110, 23);
            this.btnLoadWorkClasses.TabIndex = 0;
            this.btnLoadWorkClasses.Text = "Load Work Classes";
            this.btnLoadWorkClasses.Click += new System.EventHandler(this.btnLoadWorkClasses_Click);
            // 
            // ucSetup_WorkClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcWorkClasses);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSetup_WorkClasses";
            this.Size = new System.Drawing.Size(1113, 572);
            this.Load += new System.EventHandler(this.ucSetup_WorkClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostingWorkClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueWorkClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkClasses1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riceScheduling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteCeilingCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcWorkClasses;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkClasses;
        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand_daCostingWorkClass;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand_daCostingWorkClass;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand_daCostingWorkClass;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand_daCostingWorkClass;
        private System.Data.SqlClient.SqlDataAdapter daCostingWorkClass;
        private dsCostingWorkClass dsCostingWorkClass1;
        private DevExpress.XtraGrid.Columns.GridColumn colWC_Code;
        private DevExpress.XtraGrid.Columns.GridColumn colStandard;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteDecimal;
        private DevExpress.XtraGrid.Columns.GridColumn colOverTime;
        private DevExpress.XtraGrid.Columns.GridColumn colDoubleTime;
        private DevExpress.XtraGrid.Columns.GridColumn colTravelTime;
        private DevExpress.XtraGrid.Columns.GridColumn grdColDesc;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daWorkClasses;
        private dsWorkClasses dsWorkClasses1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueWorkClasses;
        private System.Windows.Forms.BindingSource workclassBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadWorkClasses;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riceScheduling;
        private DevExpress.XtraGrid.Columns.GridColumn colsch_enabled;
        private DevExpress.XtraGrid.Columns.GridColumn colcwc_id;
        private DevExpress.XtraGrid.Columns.GridColumn colceilingcost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteCeilingCost;
        private DevExpress.XtraEditors.PanelControl panelControl2;
    }
}
