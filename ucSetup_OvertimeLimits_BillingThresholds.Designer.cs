namespace WO_Setup
{
    partial class ucSetup_OvertimeLimits_BillingThresholds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSetup_OvertimeLimits_BillingThresholds));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpBillingThreshold = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gcBillingThreshold = new DevExpress.XtraGrid.GridControl();
            this.dsBillThresh1 = new WO_Setup.dsBillThresh();
            this.gvBillingThreshold = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpbt_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.icbType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colpbt_ot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colpbt_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpbt_week_ot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpbt_week_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ceBillThresh = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcOvertimeLimits = new DevExpress.XtraGrid.GridControl();
            this.dsOvertimeLimits1 = new WO_Setup.dsOvertimeLimits();
            this.gvOvertimeLimits = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colol_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rilueOTLCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.otlimitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOverTimeLimitsList1 = new WO_Setup.dsOverTimeLimitsList();
            this.colol_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colol_ot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDecimal2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colol_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colol_week_ot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colol_week_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.sqlConnTR1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daOvertimeLimits = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daBillThresh = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daOverTimeLimitsList = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpBillingThreshold.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBillingThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillThresh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBillingThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceBillThresh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOvertimeLimits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOvertimeLimits1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOvertimeLimits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOTLCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otlimitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOverTimeLimitsList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal2)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.HideImmediatelyOnAutoHide = true;
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpBillingThreshold});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpBillingThreshold
            // 
            this.dpBillingThreshold.Controls.Add(this.dockPanel1_Container);
            this.dpBillingThreshold.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dpBillingThreshold.ID = new System.Guid("ee4a0045-878e-4570-a6e9-00809cd6a59b");
            this.dpBillingThreshold.Location = new System.Drawing.Point(0, 328);
            this.dpBillingThreshold.Name = "dpBillingThreshold";
            this.dpBillingThreshold.Size = new System.Drawing.Size(823, 248);
            this.dpBillingThreshold.Text = "Billing Threshold";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.gcBillingThreshold);
            this.dockPanel1_Container.Controls.Add(this.panelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(817, 220);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // gcBillingThreshold
            // 
            this.gcBillingThreshold.DataMember = "proj_bill_thresh";
            this.gcBillingThreshold.DataSource = this.dsBillThresh1;
            this.gcBillingThreshold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBillingThreshold.Location = new System.Drawing.Point(0, 42);
            this.gcBillingThreshold.MainView = this.gvBillingThreshold;
            this.gcBillingThreshold.Name = "gcBillingThreshold";
            this.gcBillingThreshold.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDecimal,
            this.icbType});
            this.gcBillingThreshold.Size = new System.Drawing.Size(817, 178);
            this.gcBillingThreshold.TabIndex = 0;
            this.gcBillingThreshold.UseEmbeddedNavigator = true;
            this.gcBillingThreshold.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBillingThreshold});
            // 
            // dsBillThresh1
            // 
            this.dsBillThresh1.DataSetName = "dsBillThresh";
            this.dsBillThresh1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBillingThreshold
            // 
            this.gvBillingThreshold.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpbt_type,
            this.colpbt_ot,
            this.colpbt_dt,
            this.colpbt_week_ot,
            this.colpbt_week_dt});
            this.gvBillingThreshold.GridControl = this.gcBillingThreshold;
            this.gvBillingThreshold.Name = "gvBillingThreshold";
            this.gvBillingThreshold.OptionsView.ColumnAutoWidth = false;
            this.gvBillingThreshold.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvBillingThreshold_InitNewRow);
            this.gvBillingThreshold.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvBillingThreshold_InvalidRowException);
            this.gvBillingThreshold.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBillingThreshold_ValidateRow);
            // 
            // colpbt_type
            // 
            this.colpbt_type.Caption = "Type";
            this.colpbt_type.ColumnEdit = this.icbType;
            this.colpbt_type.FieldName = "pbt_type";
            this.colpbt_type.Name = "colpbt_type";
            this.colpbt_type.Visible = true;
            this.colpbt_type.VisibleIndex = 0;
            this.colpbt_type.Width = 109;
            // 
            // icbType
            // 
            this.icbType.AutoHeight = false;
            this.icbType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbType.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Saturday", "S", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Sunday", "U", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Weekday", "W", -1)});
            this.icbType.Name = "icbType";
            // 
            // colpbt_ot
            // 
            this.colpbt_ot.Caption = "Daily Overtime";
            this.colpbt_ot.ColumnEdit = this.txtDecimal;
            this.colpbt_ot.FieldName = "pbt_ot";
            this.colpbt_ot.Name = "colpbt_ot";
            this.colpbt_ot.Visible = true;
            this.colpbt_ot.VisibleIndex = 1;
            this.colpbt_ot.Width = 92;
            // 
            // txtDecimal
            // 
            this.txtDecimal.AutoHeight = false;
            this.txtDecimal.Mask.EditMask = "n2";
            this.txtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.txtDecimal.Name = "txtDecimal";
            // 
            // colpbt_dt
            // 
            this.colpbt_dt.Caption = "Daily Double Time";
            this.colpbt_dt.ColumnEdit = this.txtDecimal;
            this.colpbt_dt.FieldName = "pbt_dt";
            this.colpbt_dt.Name = "colpbt_dt";
            this.colpbt_dt.Visible = true;
            this.colpbt_dt.VisibleIndex = 2;
            this.colpbt_dt.Width = 106;
            // 
            // colpbt_week_ot
            // 
            this.colpbt_week_ot.Caption = "Weekly Overtime";
            this.colpbt_week_ot.ColumnEdit = this.txtDecimal;
            this.colpbt_week_ot.FieldName = "pbt_week_ot";
            this.colpbt_week_ot.Name = "colpbt_week_ot";
            this.colpbt_week_ot.Visible = true;
            this.colpbt_week_ot.VisibleIndex = 3;
            this.colpbt_week_ot.Width = 104;
            // 
            // colpbt_week_dt
            // 
            this.colpbt_week_dt.Caption = "Weekly Double Time";
            this.colpbt_week_dt.ColumnEdit = this.txtDecimal;
            this.colpbt_week_dt.FieldName = "pbt_week_dt";
            this.colpbt_week_dt.Name = "colpbt_week_dt";
            this.colpbt_week_dt.Visible = true;
            this.colpbt_week_dt.VisibleIndex = 4;
            this.colpbt_week_dt.Width = 118;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ceBillThresh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(817, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // ceBillThresh
            // 
            this.ceBillThresh.Location = new System.Drawing.Point(17, 12);
            this.ceBillThresh.Name = "ceBillThresh";
            this.ceBillThresh.Properties.Caption = "Enable Billing Thresholds";
            this.ceBillThresh.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.ceBillThresh.Properties.ValueChecked = "T";
            this.ceBillThresh.Properties.ValueUnchecked = "F";
            this.ceBillThresh.Size = new System.Drawing.Size(224, 19);
            this.ceBillThresh.TabIndex = 0;
            this.ceBillThresh.CheckedChanged += new System.EventHandler(this.ceBillThresh_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gcOvertimeLimits);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(823, 328);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Overtime Limits";
            // 
            // gcOvertimeLimits
            // 
            this.gcOvertimeLimits.DataMember = "ot_limit";
            this.gcOvertimeLimits.DataSource = this.dsOvertimeLimits1;
            this.gcOvertimeLimits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOvertimeLimits.Location = new System.Drawing.Point(2, 20);
            this.gcOvertimeLimits.MainView = this.gvOvertimeLimits;
            this.gcOvertimeLimits.Name = "gcOvertimeLimits";
            this.gcOvertimeLimits.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDecimal2,
            this.rilueOTLCode});
            this.gcOvertimeLimits.Size = new System.Drawing.Size(819, 306);
            this.gcOvertimeLimits.TabIndex = 0;
            this.gcOvertimeLimits.UseEmbeddedNavigator = true;
            this.gcOvertimeLimits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOvertimeLimits});
            // 
            // dsOvertimeLimits1
            // 
            this.dsOvertimeLimits1.DataSetName = "dsOvertimeLimits";
            this.dsOvertimeLimits1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvOvertimeLimits
            // 
            this.gvOvertimeLimits.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colol_code,
            this.colol_desc,
            this.colol_ot,
            this.colol_dt,
            this.colol_week_ot,
            this.colol_week_dt});
            this.gvOvertimeLimits.GridControl = this.gcOvertimeLimits;
            this.gvOvertimeLimits.Name = "gvOvertimeLimits";
            this.gvOvertimeLimits.OptionsView.ColumnAutoWidth = false;
            this.gvOvertimeLimits.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvOvertimeLimits_CellValueChanged);
            this.gvOvertimeLimits.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvOvertimeLimits_InitNewRow);
            this.gvOvertimeLimits.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvOvertimeLimits_InvalidRowException);
            this.gvOvertimeLimits.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvOvertimeLimits_ValidateRow);
            // 
            // colol_code
            // 
            this.colol_code.Caption = "Code";
            this.colol_code.ColumnEdit = this.rilueOTLCode;
            this.colol_code.FieldName = "ol_code";
            this.colol_code.Name = "colol_code";
            this.colol_code.Visible = true;
            this.colol_code.VisibleIndex = 0;
            this.colol_code.Width = 90;
            // 
            // rilueOTLCode
            // 
            this.rilueOTLCode.AutoHeight = false;
            this.rilueOTLCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rilueOTLCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ol_code", "Code", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ol_desc", "Description", 250, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.rilueOTLCode.DataSource = this.otlimitBindingSource;
            this.rilueOTLCode.DisplayMember = "ol_code";
            this.rilueOTLCode.Name = "rilueOTLCode";
            this.rilueOTLCode.NullText = "";
            this.rilueOTLCode.PopupWidth = 300;
            this.rilueOTLCode.ValueMember = "ol_code";
            this.rilueOTLCode.Enter += new System.EventHandler(this.rilueOTLCode_Enter);
            // 
            // otlimitBindingSource
            // 
            this.otlimitBindingSource.DataMember = "ot_limit";
            this.otlimitBindingSource.DataSource = this.dsOverTimeLimitsList1;
            // 
            // dsOverTimeLimitsList1
            // 
            this.dsOverTimeLimitsList1.DataSetName = "dsOverTimeLimitsList";
            this.dsOverTimeLimitsList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colol_desc
            // 
            this.colol_desc.Caption = "Description";
            this.colol_desc.FieldName = "ol_desc";
            this.colol_desc.Name = "colol_desc";
            this.colol_desc.OptionsColumn.AllowEdit = false;
            this.colol_desc.Visible = true;
            this.colol_desc.VisibleIndex = 1;
            this.colol_desc.Width = 161;
            // 
            // colol_ot
            // 
            this.colol_ot.Caption = "Daily Overtime";
            this.colol_ot.ColumnEdit = this.txtDecimal2;
            this.colol_ot.FieldName = "ol_ot";
            this.colol_ot.Name = "colol_ot";
            this.colol_ot.Visible = true;
            this.colol_ot.VisibleIndex = 2;
            this.colol_ot.Width = 92;
            // 
            // txtDecimal2
            // 
            this.txtDecimal2.AutoHeight = false;
            this.txtDecimal2.Mask.EditMask = "n2";
            this.txtDecimal2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDecimal2.Mask.UseMaskAsDisplayFormat = true;
            this.txtDecimal2.Name = "txtDecimal2";
            // 
            // colol_dt
            // 
            this.colol_dt.Caption = "Daily Double Time";
            this.colol_dt.ColumnEdit = this.txtDecimal2;
            this.colol_dt.FieldName = "ol_dt";
            this.colol_dt.Name = "colol_dt";
            this.colol_dt.Visible = true;
            this.colol_dt.VisibleIndex = 3;
            this.colol_dt.Width = 106;
            // 
            // colol_week_ot
            // 
            this.colol_week_ot.Caption = "Weekly Overtime";
            this.colol_week_ot.ColumnEdit = this.txtDecimal2;
            this.colol_week_ot.FieldName = "ol_week_ot";
            this.colol_week_ot.Name = "colol_week_ot";
            this.colol_week_ot.Visible = true;
            this.colol_week_ot.VisibleIndex = 4;
            this.colol_week_ot.Width = 104;
            // 
            // colol_week_dt
            // 
            this.colol_week_dt.Caption = "Weekly Double Time";
            this.colol_week_dt.ColumnEdit = this.txtDecimal2;
            this.colol_week_dt.FieldName = "ol_week_dt";
            this.colol_week_dt.Name = "colol_week_dt";
            this.colol_week_dt.Visible = true;
            this.colol_week_dt.VisibleIndex = 5;
            this.colol_week_dt.Width = 118;
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=DEV4;Initial Catalog=TR_COMCO;Persist Security Info=True;User ID=hmsq" +
                "lsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlConnTR1
            // 
            this.sqlConnTR1.ConnectionString = "Data Source=DEV4;Initial Catalog=TR_COMCO;Persist Security Info=True;User ID=hmsq" +
                "lsa;Password=hmsqlsa";
            this.sqlConnTR1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     ol_id, ol_code, pri_id, ol_desc, ol_ot, ol_dt, ol_week_ot, ol_week_dt," +
                " no_shopfloor_ot\r\nFROM         ot_limit\r\nWHERE     (ISNULL(pri_id, 0) <> 0) AND " +
                "(pri_id = @priID)\r\nORDER BY ol_code";
            this.sqlSelectCommand1.Connection = this.sqlConnTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priID", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ol_code", System.Data.SqlDbType.Char, 0, "ol_code"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@ol_desc", System.Data.SqlDbType.Char, 0, "ol_desc"),
            new System.Data.SqlClient.SqlParameter("@ol_ot", System.Data.SqlDbType.Money, 0, "ol_ot"),
            new System.Data.SqlClient.SqlParameter("@ol_dt", System.Data.SqlDbType.Money, 0, "ol_dt"),
            new System.Data.SqlClient.SqlParameter("@ol_week_ot", System.Data.SqlDbType.Money, 0, "ol_week_ot"),
            new System.Data.SqlClient.SqlParameter("@ol_week_dt", System.Data.SqlDbType.Money, 0, "ol_week_dt"),
            new System.Data.SqlClient.SqlParameter("@no_shopfloor_ot", System.Data.SqlDbType.VarChar, 0, "no_shopfloor_ot")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ol_code", System.Data.SqlDbType.Char, 0, "ol_code"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@ol_desc", System.Data.SqlDbType.Char, 0, "ol_desc"),
            new System.Data.SqlClient.SqlParameter("@ol_ot", System.Data.SqlDbType.Money, 0, "ol_ot"),
            new System.Data.SqlClient.SqlParameter("@ol_dt", System.Data.SqlDbType.Money, 0, "ol_dt"),
            new System.Data.SqlClient.SqlParameter("@ol_week_ot", System.Data.SqlDbType.Money, 0, "ol_week_ot"),
            new System.Data.SqlClient.SqlParameter("@ol_week_dt", System.Data.SqlDbType.Money, 0, "ol_week_dt"),
            new System.Data.SqlClient.SqlParameter("@no_shopfloor_ot", System.Data.SqlDbType.VarChar, 0, "no_shopfloor_ot"),
            new System.Data.SqlClient.SqlParameter("@Original_ol_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ol_code", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_desc", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_week_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_week_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_week_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_week_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_week_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_week_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_week_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_week_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_no_shopfloor_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "no_shopfloor_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_no_shopfloor_ot", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "no_shopfloor_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ol_id", System.Data.SqlDbType.Int, 4, "ol_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ol_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ol_code", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_desc", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_week_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_week_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_week_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_week_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_week_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_week_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_week_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_week_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_no_shopfloor_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "no_shopfloor_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_no_shopfloor_ot", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "no_shopfloor_ot", System.Data.DataRowVersion.Original, null)});
            // 
            // daOvertimeLimits
            // 
            this.daOvertimeLimits.DeleteCommand = this.sqlDeleteCommand1;
            this.daOvertimeLimits.InsertCommand = this.sqlInsertCommand1;
            this.daOvertimeLimits.SelectCommand = this.sqlSelectCommand1;
            this.daOvertimeLimits.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ot_limit", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ol_id", "ol_id"),
                        new System.Data.Common.DataColumnMapping("ol_code", "ol_code"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("ol_desc", "ol_desc"),
                        new System.Data.Common.DataColumnMapping("ol_ot", "ol_ot"),
                        new System.Data.Common.DataColumnMapping("ol_dt", "ol_dt"),
                        new System.Data.Common.DataColumnMapping("ol_week_ot", "ol_week_ot"),
                        new System.Data.Common.DataColumnMapping("ol_week_dt", "ol_week_dt"),
                        new System.Data.Common.DataColumnMapping("no_shopfloor_ot", "no_shopfloor_ot")})});
            this.daOvertimeLimits.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT     pbt_id, pri_id, pbt_type, pbt_ot, pbt_dt, pbt_week_ot, pbt_week_dt\r\nFR" +
                "OM         proj_bill_thresh\r\nWHERE     (ISNULL(pri_id, 0) <> 0) AND (pri_id = @p" +
                "riID)";
            this.sqlSelectCommand2.Connection = this.sqlConnTR1;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@priID", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.sqlConnTR1;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pbt_type", System.Data.SqlDbType.VarChar, 0, "pbt_type"),
            new System.Data.SqlClient.SqlParameter("@pbt_ot", System.Data.SqlDbType.Money, 0, "pbt_ot"),
            new System.Data.SqlClient.SqlParameter("@pbt_dt", System.Data.SqlDbType.Money, 0, "pbt_dt"),
            new System.Data.SqlClient.SqlParameter("@pbt_week_ot", System.Data.SqlDbType.Money, 0, "pbt_week_ot"),
            new System.Data.SqlClient.SqlParameter("@pbt_week_dt", System.Data.SqlDbType.Money, 0, "pbt_week_dt")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.sqlConnTR1;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pbt_type", System.Data.SqlDbType.VarChar, 0, "pbt_type"),
            new System.Data.SqlClient.SqlParameter("@pbt_ot", System.Data.SqlDbType.Money, 0, "pbt_ot"),
            new System.Data.SqlClient.SqlParameter("@pbt_dt", System.Data.SqlDbType.Money, 0, "pbt_dt"),
            new System.Data.SqlClient.SqlParameter("@pbt_week_ot", System.Data.SqlDbType.Money, 0, "pbt_week_ot"),
            new System.Data.SqlClient.SqlParameter("@pbt_week_dt", System.Data.SqlDbType.Money, 0, "pbt_week_dt"),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_week_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_week_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_week_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_week_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_week_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_week_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_week_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_week_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pbt_id", System.Data.SqlDbType.Int, 4, "pbt_id")});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.sqlConnTR1;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pbt_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_dt", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_week_ot", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_week_ot", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_week_ot", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_week_ot", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pbt_week_dt", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pbt_week_dt", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pbt_week_dt", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pbt_week_dt", System.Data.DataRowVersion.Original, null)});
            // 
            // daBillThresh
            // 
            this.daBillThresh.DeleteCommand = this.sqlDeleteCommand2;
            this.daBillThresh.InsertCommand = this.sqlInsertCommand2;
            this.daBillThresh.SelectCommand = this.sqlSelectCommand2;
            this.daBillThresh.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "proj_bill_thresh", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pbt_id", "pbt_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pbt_type", "pbt_type"),
                        new System.Data.Common.DataColumnMapping("pbt_ot", "pbt_ot"),
                        new System.Data.Common.DataColumnMapping("pbt_dt", "pbt_dt"),
                        new System.Data.Common.DataColumnMapping("pbt_week_ot", "pbt_week_ot"),
                        new System.Data.Common.DataColumnMapping("pbt_week_dt", "pbt_week_dt")})});
            this.daBillThresh.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT     ol_id, ol_code, ol_desc\r\nFROM         ot_limit\r\nWHERE     (pri_id = 0)" +
                "\r\nORDER BY ol_code";
            this.sqlSelectCommand3.Connection = this.sqlConnTR;
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.sqlConnTR;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ol_code", System.Data.SqlDbType.Char, 0, "ol_code"),
            new System.Data.SqlClient.SqlParameter("@ol_desc", System.Data.SqlDbType.Char, 0, "ol_desc"),
            new System.Data.SqlClient.SqlParameter("@Original_ol_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ol_code", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_desc", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ol_id", System.Data.SqlDbType.Int, 4, "ol_id")});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = "DELETE FROM [ot_limit] WHERE (([ol_id] = @Original_ol_id) AND ([ol_code] = @Origi" +
                "nal_ol_code) AND ((@IsNull_ol_desc = 1 AND [ol_desc] IS NULL) OR ([ol_desc] = @O" +
                "riginal_ol_desc)))";
            this.sqlDeleteCommand3.Connection = this.sqlConnTR;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ol_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ol_code", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ol_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ol_desc", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ol_desc", System.Data.DataRowVersion.Original, null)});
            // 
            // daOverTimeLimitsList
            // 
            this.daOverTimeLimitsList.DeleteCommand = this.sqlDeleteCommand3;
            this.daOverTimeLimitsList.SelectCommand = this.sqlSelectCommand3;
            this.daOverTimeLimitsList.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ot_limit", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ol_id", "ol_id"),
                        new System.Data.Common.DataColumnMapping("ol_code", "ol_code"),
                        new System.Data.Common.DataColumnMapping("ol_desc", "ol_desc")})});
            this.daOverTimeLimitsList.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // ucSetup_OvertimeLimits_BillingThresholds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dpBillingThreshold);
            this.Name = "ucSetup_OvertimeLimits_BillingThresholds";
            this.Size = new System.Drawing.Size(823, 576);
            this.Load += new System.EventHandler(this.ucSetup_OvertimeLimits_BillingThresholds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpBillingThreshold.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBillingThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBillThresh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBillingThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceBillThresh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOvertimeLimits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOvertimeLimits1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOvertimeLimits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rilueOTLCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otlimitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOverTimeLimitsList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpBillingThreshold;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcOvertimeLimits;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOvertimeLimits;
        private DevExpress.XtraGrid.GridControl gcBillingThreshold;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBillingThreshold;
        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private System.Data.SqlClient.SqlConnection sqlConnTR1;
        private dsOvertimeLimits dsOvertimeLimits1;
        private DevExpress.XtraGrid.Columns.GridColumn colol_code;
        private DevExpress.XtraGrid.Columns.GridColumn colol_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colol_ot;
        private DevExpress.XtraGrid.Columns.GridColumn colol_dt;
        private DevExpress.XtraGrid.Columns.GridColumn colol_week_ot;
        private DevExpress.XtraGrid.Columns.GridColumn colol_week_dt;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daOvertimeLimits;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDecimal2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daBillThresh;
        private dsBillThresh dsBillThresh1;
        private DevExpress.XtraGrid.Columns.GridColumn colpbt_type;
        private DevExpress.XtraGrid.Columns.GridColumn colpbt_ot;
        private DevExpress.XtraGrid.Columns.GridColumn colpbt_dt;
        private DevExpress.XtraGrid.Columns.GridColumn colpbt_week_ot;
        private DevExpress.XtraGrid.Columns.GridColumn colpbt_week_dt;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox icbType;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDecimal;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit ceBillThresh;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter daOverTimeLimitsList;
        private dsOverTimeLimitsList dsOverTimeLimitsList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rilueOTLCode;
        private System.Windows.Forms.BindingSource otlimitBindingSource;
    }
}
