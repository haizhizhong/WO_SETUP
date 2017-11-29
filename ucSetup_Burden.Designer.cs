namespace WO_Setup
{
    partial class ucSetup_Burden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSetup_Burden));
            this.gcBurden = new DevExpress.XtraGrid.GridControl();
            this.dsCostingBurden1 = new WO_Setup.dsCostingBurden();
            this.gvBurden = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colburden_type_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luBurdenType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colcalc_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rgCalMethod = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.colreg_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDecimal = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colot_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldt_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgl_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colburden_type_id1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luBurdenDesc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.grdAcctDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luAcctDesc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daCostingBurden = new System.Data.SqlClient.SqlDataAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnLoadBurdens = new DevExpress.XtraEditors.SimpleButton();
            this.colIsCeiling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riCeiling = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.rgCalMethodRO = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gcBurden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostingBurden1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBurden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBurdenType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBurdenDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luAcctDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riCeiling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalMethodRO)).BeginInit();
            this.SuspendLayout();
            // 
            // gcBurden
            // 
            this.gcBurden.DataMember = "costing_burdens";
            this.gcBurden.DataSource = this.dsCostingBurden1;
            this.gcBurden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBurden.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcBurden.Location = new System.Drawing.Point(0, 37);
            this.gcBurden.MainView = this.gvBurden;
            this.gcBurden.Name = "gcBurden";
            this.gcBurden.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtDecimal,
            this.rgCalMethod,
            this.luBurdenType,
            this.luBurdenDesc,
            this.luAcctDesc,
            this.riCeiling,
            this.rgCalMethodRO});
            this.gcBurden.Size = new System.Drawing.Size(1257, 517);
            this.gcBurden.TabIndex = 0;
            this.gcBurden.UseEmbeddedNavigator = true;
            this.gcBurden.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBurden});
            // 
            // dsCostingBurden1
            // 
            this.dsCostingBurden1.DataSetName = "dsCostingBurden";
            this.dsCostingBurden1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBurden
            // 
            this.gvBurden.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colburden_type_id,
            this.colcalc_type,
            this.colreg_rate,
            this.colot_rate,
            this.coldt_rate,
            this.colgl_account,
            this.colburden_type_id1,
            this.grdAcctDesc,
            this.colIsCeiling});
            this.gvBurden.GridControl = this.gcBurden;
            this.gvBurden.Name = "gvBurden";
            this.gvBurden.OptionsView.ColumnAutoWidth = false;
            this.gvBurden.RowHeight = 32;
            this.gvBurden.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvBurden_CustomUnboundColumnData);
            this.gvBurden.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvBurden_InitNewRow);
            this.gvBurden.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvBurden_CustomRowCellEditForEditing);
            this.gvBurden.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gvBurden_InvalidRowException);
            this.gvBurden.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBurden_ValidateRow);
            // 
            // colburden_type_id
            // 
            this.colburden_type_id.Caption = "Burden Type Code";
            this.colburden_type_id.ColumnEdit = this.luBurdenType;
            this.colburden_type_id.FieldName = "burden_type_id";
            this.colburden_type_id.Name = "colburden_type_id";
            this.colburden_type_id.Visible = true;
            this.colburden_type_id.VisibleIndex = 0;
            this.colburden_type_id.Width = 117;
            // 
            // luBurdenType
            // 
            this.luBurdenType.AutoHeight = false;
            this.luBurdenType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luBurdenType.Name = "luBurdenType";
            this.luBurdenType.EditValueChanged += new System.EventHandler(this.luBurdenType_EditValueChanged);
            // 
            // colcalc_type
            // 
            this.colcalc_type.Caption = "Calculation Method";
            this.colcalc_type.ColumnEdit = this.rgCalMethod;
            this.colcalc_type.FieldName = "calc_type";
            this.colcalc_type.Name = "colcalc_type";
            this.colcalc_type.Visible = true;
            this.colcalc_type.VisibleIndex = 2;
            this.colcalc_type.Width = 117;
            // 
            // rgCalMethod
            // 
            this.rgCalMethod.Columns = 1;
            this.rgCalMethod.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Percentage"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Amount / Hour")});
            this.rgCalMethod.Name = "rgCalMethod";
            // 
            // colreg_rate
            // 
            this.colreg_rate.Caption = "Regular Hours";
            this.colreg_rate.ColumnEdit = this.txtDecimal;
            this.colreg_rate.FieldName = "reg_rate";
            this.colreg_rate.Name = "colreg_rate";
            this.colreg_rate.Visible = true;
            this.colreg_rate.VisibleIndex = 3;
            this.colreg_rate.Width = 90;
            // 
            // txtDecimal
            // 
            this.txtDecimal.AutoHeight = false;
            this.txtDecimal.Mask.EditMask = "n2";
            this.txtDecimal.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDecimal.Mask.UseMaskAsDisplayFormat = true;
            this.txtDecimal.Name = "txtDecimal";
            // 
            // colot_rate
            // 
            this.colot_rate.Caption = "Overtime Hours";
            this.colot_rate.ColumnEdit = this.txtDecimal;
            this.colot_rate.FieldName = "ot_rate";
            this.colot_rate.Name = "colot_rate";
            this.colot_rate.Visible = true;
            this.colot_rate.VisibleIndex = 4;
            this.colot_rate.Width = 97;
            // 
            // coldt_rate
            // 
            this.coldt_rate.Caption = "Double Time Hours";
            this.coldt_rate.ColumnEdit = this.txtDecimal;
            this.coldt_rate.FieldName = "dt_rate";
            this.coldt_rate.Name = "coldt_rate";
            this.coldt_rate.Visible = true;
            this.coldt_rate.VisibleIndex = 5;
            this.coldt_rate.Width = 111;
            // 
            // colgl_account
            // 
            this.colgl_account.Caption = "GL Account";
            this.colgl_account.FieldName = "gl_account";
            this.colgl_account.Name = "colgl_account";
            this.colgl_account.Visible = true;
            this.colgl_account.VisibleIndex = 6;
            this.colgl_account.Width = 148;
            // 
            // colburden_type_id1
            // 
            this.colburden_type_id1.Caption = "Burden Description";
            this.colburden_type_id1.ColumnEdit = this.luBurdenDesc;
            this.colburden_type_id1.FieldName = "burden_type_id";
            this.colburden_type_id1.Name = "colburden_type_id1";
            this.colburden_type_id1.OptionsColumn.AllowEdit = false;
            this.colburden_type_id1.Visible = true;
            this.colburden_type_id1.VisibleIndex = 1;
            this.colburden_type_id1.Width = 184;
            // 
            // luBurdenDesc
            // 
            this.luBurdenDesc.AutoHeight = false;
            this.luBurdenDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luBurdenDesc.Name = "luBurdenDesc";
            this.luBurdenDesc.EditValueChanged += new System.EventHandler(this.luBurdenType_EditValueChanged);
            // 
            // grdAcctDesc
            // 
            this.grdAcctDesc.Caption = "Account Description";
            this.grdAcctDesc.FieldName = "grdAcctDesc";
            this.grdAcctDesc.Name = "grdAcctDesc";
            this.grdAcctDesc.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.grdAcctDesc.Visible = true;
            this.grdAcctDesc.VisibleIndex = 7;
            this.grdAcctDesc.Width = 227;
            // 
            // luAcctDesc
            // 
            this.luAcctDesc.AutoHeight = false;
            this.luAcctDesc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luAcctDesc.Name = "luAcctDesc";
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=dev11;Initial Catalog=tr_strike_test10;Persist Security Info=True;Use" +
                "r ID=hmsqlsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        cb_id, pri_id, burden_type_id, calc_type, reg_rate, ot_rate, dt_rat" +
                "e, gl_account, fuel_burden, IsCeiling\r\nFROM            costing_burdens\r\nWHERE   " +
                "     (pri_id = @priID)";
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
            new System.Data.SqlClient.SqlParameter("@burden_type_id", System.Data.SqlDbType.Int, 0, "burden_type_id"),
            new System.Data.SqlClient.SqlParameter("@calc_type", System.Data.SqlDbType.Char, 0, "calc_type"),
            new System.Data.SqlClient.SqlParameter("@reg_rate", System.Data.SqlDbType.Money, 0, "reg_rate"),
            new System.Data.SqlClient.SqlParameter("@ot_rate", System.Data.SqlDbType.Money, 0, "ot_rate"),
            new System.Data.SqlClient.SqlParameter("@dt_rate", System.Data.SqlDbType.Money, 0, "dt_rate"),
            new System.Data.SqlClient.SqlParameter("@gl_account", System.Data.SqlDbType.VarChar, 0, "gl_account"),
            new System.Data.SqlClient.SqlParameter("@fuel_burden", System.Data.SqlDbType.Char, 0, "fuel_burden"),
            new System.Data.SqlClient.SqlParameter("@IsCeiling", System.Data.SqlDbType.Bit, 0, "IsCeiling")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 0, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@burden_type_id", System.Data.SqlDbType.Int, 0, "burden_type_id"),
            new System.Data.SqlClient.SqlParameter("@calc_type", System.Data.SqlDbType.Char, 0, "calc_type"),
            new System.Data.SqlClient.SqlParameter("@reg_rate", System.Data.SqlDbType.Money, 0, "reg_rate"),
            new System.Data.SqlClient.SqlParameter("@ot_rate", System.Data.SqlDbType.Money, 0, "ot_rate"),
            new System.Data.SqlClient.SqlParameter("@dt_rate", System.Data.SqlDbType.Money, 0, "dt_rate"),
            new System.Data.SqlClient.SqlParameter("@gl_account", System.Data.SqlDbType.VarChar, 0, "gl_account"),
            new System.Data.SqlClient.SqlParameter("@fuel_burden", System.Data.SqlDbType.Char, 0, "fuel_burden"),
            new System.Data.SqlClient.SqlParameter("@IsCeiling", System.Data.SqlDbType.Bit, 0, "IsCeiling"),
            new System.Data.SqlClient.SqlParameter("@Original_cb_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cb_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_burden_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_calc_type", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "calc_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_reg_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "reg_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_reg_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "reg_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ot_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ot_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ot_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ot_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_dt_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dt_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_dt_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dt_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_gl_account", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gl_account", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_fuel_burden", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "fuel_burden", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_fuel_burden", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "fuel_burden", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IsCeiling", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IsCeiling", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IsCeiling", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IsCeiling", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@cb_id", System.Data.SqlDbType.Int, 4, "cb_id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_cb_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cb_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_burden_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_calc_type", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "calc_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_reg_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "reg_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_reg_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "reg_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ot_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ot_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ot_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ot_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_dt_rate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "dt_rate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_dt_rate", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "dt_rate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_gl_account", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "gl_account", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_fuel_burden", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "fuel_burden", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_fuel_burden", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "fuel_burden", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_IsCeiling", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IsCeiling", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_IsCeiling", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IsCeiling", System.Data.DataRowVersion.Original, null)});
            // 
            // daCostingBurden
            // 
            this.daCostingBurden.DeleteCommand = this.sqlDeleteCommand1;
            this.daCostingBurden.InsertCommand = this.sqlInsertCommand1;
            this.daCostingBurden.SelectCommand = this.sqlSelectCommand1;
            this.daCostingBurden.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "costing_burdens", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cb_id", "cb_id"),
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("burden_type_id", "burden_type_id"),
                        new System.Data.Common.DataColumnMapping("calc_type", "calc_type"),
                        new System.Data.Common.DataColumnMapping("reg_rate", "reg_rate"),
                        new System.Data.Common.DataColumnMapping("ot_rate", "ot_rate"),
                        new System.Data.Common.DataColumnMapping("dt_rate", "dt_rate"),
                        new System.Data.Common.DataColumnMapping("gl_account", "gl_account"),
                        new System.Data.Common.DataColumnMapping("fuel_burden", "fuel_burden"),
                        new System.Data.Common.DataColumnMapping("IsCeiling", "IsCeiling")})});
            this.daCostingBurden.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnLoadBurdens);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1257, 37);
            this.panelControl1.TabIndex = 2;
            // 
            // btnLoadBurdens
            // 
            this.btnLoadBurdens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadBurdens.Location = new System.Drawing.Point(1139, 7);
            this.btnLoadBurdens.Name = "btnLoadBurdens";
            this.btnLoadBurdens.Size = new System.Drawing.Size(110, 23);
            this.btnLoadBurdens.TabIndex = 0;
            this.btnLoadBurdens.Text = "Load Burdens";
            this.btnLoadBurdens.Click += new System.EventHandler(this.btnLoadBurdens_Click);
            // 
            // colIsCeiling
            // 
            this.colIsCeiling.Caption = "Is Ceiling?";
            this.colIsCeiling.ColumnEdit = this.riCeiling;
            this.colIsCeiling.FieldName = "IsCeiling";
            this.colIsCeiling.Name = "colIsCeiling";
            this.colIsCeiling.OptionsColumn.AllowEdit = false;
            this.colIsCeiling.Visible = true;
            this.colIsCeiling.VisibleIndex = 8;
            // 
            // riCeiling
            // 
            this.riCeiling.AutoHeight = false;
            this.riCeiling.Name = "riCeiling";
            this.riCeiling.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // rgCalMethodRO
            // 
            this.rgCalMethodRO.Columns = 1;
            this.rgCalMethodRO.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Percentage"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("A", "Amount / Hour")});
            this.rgCalMethodRO.Name = "rgCalMethodRO";
            this.rgCalMethodRO.ReadOnly = true;
            // 
            // ucSetup_Burden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcBurden);
            this.Controls.Add(this.panelControl1);
            this.Name = "ucSetup_Burden";
            this.Size = new System.Drawing.Size(1257, 554);
            this.Load += new System.EventHandler(this.ucSetup_Burden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcBurden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCostingBurden1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBurden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBurdenType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDecimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luBurdenDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luAcctDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.riCeiling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCalMethodRO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcBurden;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBurden;
        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daCostingBurden;
        private dsCostingBurden dsCostingBurden1;
        private DevExpress.XtraGrid.Columns.GridColumn colburden_type_id;
        private DevExpress.XtraGrid.Columns.GridColumn colcalc_type;
        private DevExpress.XtraGrid.Columns.GridColumn colreg_rate;
        private DevExpress.XtraGrid.Columns.GridColumn colot_rate;
        private DevExpress.XtraGrid.Columns.GridColumn coldt_rate;
        private DevExpress.XtraGrid.Columns.GridColumn colgl_account;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtDecimal;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup rgCalMethod;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luBurdenType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luBurdenDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colburden_type_id1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luAcctDesc;
        private DevExpress.XtraGrid.Columns.GridColumn grdAcctDesc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLoadBurdens;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCeiling;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit riCeiling;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup rgCalMethodRO;
    }
}
