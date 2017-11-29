namespace WO_Setup
{
    partial class frmLoadBurdens
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadBurdens));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.bntOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcSelectableBurdens = new DevExpress.XtraGrid.GridControl();
            this.dsBurdenSelection1 = new WO_Setup.dsBurdenSelection();
            this.gvSelectableBurdens = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colburden_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colburden_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sqlConnTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daBurdenSelection = new System.Data.SqlClient.SqlDataAdapter();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpType = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.btnOK_Type = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel_Type = new DevExpress.XtraEditors.SimpleButton();
            this.tpBySetup = new DevExpress.XtraTab.XtraTabPage();
            this.tpByProject = new DevExpress.XtraTab.XtraTabPage();
            this.gcBurden = new DevExpress.XtraGrid.GridControl();
            this.bsBurdenSelection_ProjWO = new System.Windows.Forms.BindingSource(this.components);
            this.dsBurdenSelection_ProjWO1 = new WO_Setup.dsBurdenSelection_ProjWO();
            this.gvBurden = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceSelProj = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectAll_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.luProjWO = new DevExpress.XtraEditors.LookUpEdit();
            this.bsProjWO = new System.Windows.Forms.BindingSource(this.components);
            this.dsProjWO1 = new WO_Setup.dsProjWO();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.bntOK_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daBurdenSelection_ProjWO = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.daProjWO = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectableBurdens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBurdenSelection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectableBurdens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            this.tpBySetup.SuspendLayout();
            this.tpByProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBurden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBurdenSelection_ProjWO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBurdenSelection_ProjWO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBurden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luProjWO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjWO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjWO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(475, 32);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl7
            // 
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.btnSelectAll);
            this.panelControl7.Controls.Add(this.btnSelectNone);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl7.Location = new System.Drawing.Point(311, 2);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(162, 28);
            this.panelControl7.TabIndex = 3;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(3, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(84, 3);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 0;
            this.btnSelectNone.Text = "Select None";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl6);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 348);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(475, 32);
            this.panelControl2.TabIndex = 2;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.bntOK);
            this.panelControl6.Controls.Add(this.btnCancel);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(311, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(162, 28);
            this.panelControl6.TabIndex = 2;
            // 
            // bntOK
            // 
            this.bntOK.Location = new System.Drawing.Point(3, 3);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(75, 23);
            this.bntOK.TabIndex = 0;
            this.bntOK.Text = "OK";
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(84, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gcSelectableBurdens
            // 
            this.gcSelectableBurdens.DataMember = "working_burden_type";
            this.gcSelectableBurdens.DataSource = this.dsBurdenSelection1;
            this.gcSelectableBurdens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelectableBurdens.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSelectableBurdens.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSelectableBurdens.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSelectableBurdens.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSelectableBurdens.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcSelectableBurdens.Location = new System.Drawing.Point(0, 32);
            this.gcSelectableBurdens.MainView = this.gvSelectableBurdens;
            this.gcSelectableBurdens.Name = "gcSelectableBurdens";
            this.gcSelectableBurdens.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ceSelected});
            this.gcSelectableBurdens.Size = new System.Drawing.Size(475, 316);
            this.gcSelectableBurdens.TabIndex = 3;
            this.gcSelectableBurdens.UseEmbeddedNavigator = true;
            this.gcSelectableBurdens.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelectableBurdens});
            // 
            // dsBurdenSelection1
            // 
            this.dsBurdenSelection1.DataSetName = "dsBurdenSelection";
            this.dsBurdenSelection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSelectableBurdens
            // 
            this.gvSelectableBurdens.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colburden_type,
            this.colburden_desc,
            this.colSelected});
            this.gvSelectableBurdens.GridControl = this.gcSelectableBurdens;
            this.gvSelectableBurdens.Name = "gvSelectableBurdens";
            this.gvSelectableBurdens.OptionsView.ColumnAutoWidth = false;
            // 
            // colburden_type
            // 
            this.colburden_type.Caption = "Code";
            this.colburden_type.FieldName = "burden_type";
            this.colburden_type.Name = "colburden_type";
            this.colburden_type.Visible = true;
            this.colburden_type.VisibleIndex = 0;
            this.colburden_type.Width = 115;
            // 
            // colburden_desc
            // 
            this.colburden_desc.Caption = "Description";
            this.colburden_desc.FieldName = "burden_desc";
            this.colburden_desc.Name = "colburden_desc";
            this.colburden_desc.Visible = true;
            this.colburden_desc.VisibleIndex = 1;
            this.colburden_desc.Width = 253;
            // 
            // colSelected
            // 
            this.colSelected.ColumnEdit = this.ceSelected;
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 2;
            this.colSelected.Width = 63;
            // 
            // ceSelected
            // 
            this.ceSelected.AutoHeight = false;
            this.ceSelected.Name = "ceSelected";
            this.ceSelected.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.ceSelected.ValueChecked = "T";
            this.ceSelected.ValueUnchecked = "F";
            // 
            // sqlConnTR
            // 
            this.sqlConnTR.ConnectionString = "Data Source=DEV12;Initial Catalog=TR_Test2;Persist Security Info=True;User ID=hms" +
                "qlsa;Password=hmsqlsa";
            this.sqlConnTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        id, username, burden_type_id, burden_type, burden_desc, Selected\r\nF" +
                "ROM            working_burden_type\r\nWHERE        (username = @username)\r\nORDER B" +
                "Y burden_type, burden_desc";
            this.sqlSelectCommand1.Connection = this.sqlConnTR;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 250, "username")});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@burden_type_id", System.Data.SqlDbType.Int, 0, "burden_type_id"),
            new System.Data.SqlClient.SqlParameter("@burden_type", System.Data.SqlDbType.VarChar, 0, "burden_type"),
            new System.Data.SqlClient.SqlParameter("@burden_desc", System.Data.SqlDbType.VarChar, 0, "burden_desc"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.VarChar, 0, "Selected")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@username", System.Data.SqlDbType.VarChar, 0, "username"),
            new System.Data.SqlClient.SqlParameter("@burden_type_id", System.Data.SqlDbType.Int, 0, "burden_type_id"),
            new System.Data.SqlClient.SqlParameter("@burden_type", System.Data.SqlDbType.VarChar, 0, "burden_type"),
            new System.Data.SqlClient.SqlParameter("@burden_desc", System.Data.SqlDbType.VarChar, 0, "burden_desc"),
            new System.Data.SqlClient.SqlParameter("@Selected", System.Data.SqlDbType.VarChar, 0, "Selected"),
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_burden_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_burden_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_burden_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "burden_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_burden_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@id", System.Data.SqlDbType.Int, 4, "id")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_username", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_username", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "username", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_burden_type_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_type_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_burden_type", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_type", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_burden_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "burden_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_burden_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "burden_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Selected", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Selected", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Selected", System.Data.DataRowVersion.Original, null)});
            // 
            // daBurdenSelection
            // 
            this.daBurdenSelection.DeleteCommand = this.sqlDeleteCommand1;
            this.daBurdenSelection.InsertCommand = this.sqlInsertCommand1;
            this.daBurdenSelection.SelectCommand = this.sqlSelectCommand1;
            this.daBurdenSelection.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "working_burden_type", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("id", "id"),
                        new System.Data.Common.DataColumnMapping("username", "username"),
                        new System.Data.Common.DataColumnMapping("burden_type_id", "burden_type_id"),
                        new System.Data.Common.DataColumnMapping("burden_type", "burden_type"),
                        new System.Data.Common.DataColumnMapping("burden_desc", "burden_desc"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected")})});
            this.daBurdenSelection.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpType;
            this.tcMain.Size = new System.Drawing.Size(484, 411);
            this.tcMain.TabIndex = 4;
            this.tcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpType,
            this.tpBySetup,
            this.tpByProject});
            // 
            // tpType
            // 
            this.tpType.Controls.Add(this.layoutControl1);
            this.tpType.Controls.Add(this.panelControl3);
            this.tpType.Name = "tpType";
            this.tpType.Size = new System.Drawing.Size(475, 380);
            this.tpType.Text = "Types";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutGroupCaption.Options.UseForeColor = true;
            this.layoutControl1.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControl1.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.layoutControl1.Controls.Add(this.rgType);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(475, 348);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(148, 110);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "From Project"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "From Setup")});
            this.rgType.Size = new System.Drawing.Size(189, 91);
            this.rgType.StyleController = this.layoutControl1;
            this.rgType.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(475, 348);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgType;
            this.layoutControlItem1.CustomizationFormText = "Please select a type:";
            this.layoutControlItem1.Location = new System.Drawing.Point(141, 85);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(200, 120);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(200, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(200, 120);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Please select a type:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(100, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 205);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(473, 141);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(341, 85);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(132, 120);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(473, 85);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 85);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(141, 120);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl10);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 348);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(475, 32);
            this.panelControl3.TabIndex = 3;
            // 
            // panelControl10
            // 
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Controls.Add(this.btnOK_Type);
            this.panelControl10.Controls.Add(this.btnCancel_Type);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl10.Location = new System.Drawing.Point(310, 2);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(163, 28);
            this.panelControl10.TabIndex = 2;
            // 
            // btnOK_Type
            // 
            this.btnOK_Type.Location = new System.Drawing.Point(3, 3);
            this.btnOK_Type.Name = "btnOK_Type";
            this.btnOK_Type.Size = new System.Drawing.Size(75, 23);
            this.btnOK_Type.TabIndex = 0;
            this.btnOK_Type.Text = "OK";
            this.btnOK_Type.Click += new System.EventHandler(this.btnOK_Type_Click);
            // 
            // btnCancel_Type
            // 
            this.btnCancel_Type.Location = new System.Drawing.Point(84, 3);
            this.btnCancel_Type.Name = "btnCancel_Type";
            this.btnCancel_Type.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_Type.TabIndex = 1;
            this.btnCancel_Type.Text = "Cancel";
            this.btnCancel_Type.Click += new System.EventHandler(this.btnCancel_Type_Click);
            // 
            // tpBySetup
            // 
            this.tpBySetup.Controls.Add(this.gcSelectableBurdens);
            this.tpBySetup.Controls.Add(this.panelControl1);
            this.tpBySetup.Controls.Add(this.panelControl2);
            this.tpBySetup.Name = "tpBySetup";
            this.tpBySetup.Size = new System.Drawing.Size(475, 380);
            this.tpBySetup.Text = "Setup";
            // 
            // tpByProject
            // 
            this.tpByProject.Controls.Add(this.gcBurden);
            this.tpByProject.Controls.Add(this.panelControl4);
            this.tpByProject.Controls.Add(this.panelControl5);
            this.tpByProject.Name = "tpByProject";
            this.tpByProject.Size = new System.Drawing.Size(475, 380);
            this.tpByProject.Text = "Project";
            // 
            // gcBurden
            // 
            this.gcBurden.DataSource = this.bsBurdenSelection_ProjWO;
            this.gcBurden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBurden.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcBurden.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcBurden.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcBurden.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcBurden.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcBurden.Location = new System.Drawing.Point(0, 32);
            this.gcBurden.MainView = this.gvBurden;
            this.gcBurden.Name = "gcBurden";
            this.gcBurden.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ceSelProj});
            this.gcBurden.Size = new System.Drawing.Size(475, 316);
            this.gcBurden.TabIndex = 6;
            this.gcBurden.UseEmbeddedNavigator = true;
            this.gcBurden.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBurden});
            // 
            // bsBurdenSelection_ProjWO
            // 
            this.bsBurdenSelection_ProjWO.DataMember = "WO_LoadSelectedBurdens_ByProjectWO";
            this.bsBurdenSelection_ProjWO.DataSource = this.dsBurdenSelection_ProjWO1;
            // 
            // dsBurdenSelection_ProjWO1
            // 
            this.dsBurdenSelection_ProjWO1.DataSetName = "dsBurdenSelection_ProjWO";
            this.dsBurdenSelection_ProjWO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBurden
            // 
            this.gvBurden.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvBurden.GridControl = this.gcBurden;
            this.gvBurden.Name = "gvBurden";
            this.gvBurden.OptionsView.ColumnAutoWidth = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "burden_type";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 115;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "burden_desc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 253;
            // 
            // gridColumn3
            // 
            this.gridColumn3.ColumnEdit = this.ceSelProj;
            this.gridColumn3.FieldName = "Selected";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 63;
            // 
            // ceSelProj
            // 
            this.ceSelProj.AutoHeight = false;
            this.ceSelProj.Name = "ceSelProj";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.panelControl9);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.luProjWO);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(475, 32);
            this.panelControl4.TabIndex = 4;
            // 
            // panelControl9
            // 
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Controls.Add(this.btnSelectAll_Proj);
            this.panelControl9.Controls.Add(this.btnSelectNone_Proj);
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl9.Location = new System.Drawing.Point(309, 2);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(164, 28);
            this.panelControl9.TabIndex = 4;
            // 
            // btnSelectAll_Proj
            // 
            this.btnSelectAll_Proj.Location = new System.Drawing.Point(3, 3);
            this.btnSelectAll_Proj.Name = "btnSelectAll_Proj";
            this.btnSelectAll_Proj.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll_Proj.TabIndex = 1;
            this.btnSelectAll_Proj.Text = "Select All";
            this.btnSelectAll_Proj.Click += new System.EventHandler(this.btnSelectAll_Proj_Click);
            // 
            // btnSelectNone_Proj
            // 
            this.btnSelectNone_Proj.Location = new System.Drawing.Point(84, 3);
            this.btnSelectNone_Proj.Name = "btnSelectNone_Proj";
            this.btnSelectNone_Proj.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone_Proj.TabIndex = 0;
            this.btnSelectNone_Proj.Text = "Select None";
            this.btnSelectNone_Proj.Click += new System.EventHandler(this.btnSelectNone_Proj_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Project/ WO";
            // 
            // luProjWO
            // 
            this.luProjWO.Location = new System.Drawing.Point(73, 6);
            this.luProjWO.Name = "luProjWO";
            this.luProjWO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luProjWO.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_id", "pri_id", 49, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_code", "Code", 80, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("pri_desc", "Description", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luProjWO.Properties.DataSource = this.bsProjWO;
            this.luProjWO.Properties.DisplayMember = "pri_code";
            this.luProjWO.Properties.NullText = "";
            this.luProjWO.Properties.PopupWidth = 280;
            this.luProjWO.Properties.ValueMember = "pri_id";
            this.luProjWO.Size = new System.Drawing.Size(172, 20);
            this.luProjWO.TabIndex = 2;
            this.luProjWO.EditValueChanged += new System.EventHandler(this.luProjWO_EditValueChanged);
            // 
            // bsProjWO
            // 
            this.bsProjWO.DataMember = "PROJ_HEADER";
            this.bsProjWO.DataSource = this.dsProjWO1;
            // 
            // dsProjWO1
            // 
            this.dsProjWO1.DataSetName = "dsProjWO";
            this.dsProjWO1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl8);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(0, 348);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(475, 32);
            this.panelControl5.TabIndex = 5;
            // 
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Controls.Add(this.bntOK_Proj);
            this.panelControl8.Controls.Add(this.btnCancel_Proj);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl8.Location = new System.Drawing.Point(309, 2);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(164, 28);
            this.panelControl8.TabIndex = 2;
            // 
            // bntOK_Proj
            // 
            this.bntOK_Proj.Location = new System.Drawing.Point(3, 3);
            this.bntOK_Proj.Name = "bntOK_Proj";
            this.bntOK_Proj.Size = new System.Drawing.Size(75, 23);
            this.bntOK_Proj.TabIndex = 0;
            this.bntOK_Proj.Text = "OK";
            this.bntOK_Proj.Click += new System.EventHandler(this.bntOK_Proj_Click);
            // 
            // btnCancel_Proj
            // 
            this.btnCancel_Proj.Location = new System.Drawing.Point(84, 3);
            this.btnCancel_Proj.Name = "btnCancel_Proj";
            this.btnCancel_Proj.Size = new System.Drawing.Size(75, 23);
            this.btnCancel_Proj.TabIndex = 1;
            this.btnCancel_Proj.Text = "Cancel";
            this.btnCancel_Proj.Click += new System.EventHandler(this.btnCancel_Proj_Click);
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "dbo.WO_LoadSelectedBurdens_ByProjectWO";
            this.sqlSelectCommand2.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand2.Connection = this.sqlConnTR;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4),
            new System.Data.SqlClient.SqlParameter("@pri_id_sel", System.Data.SqlDbType.Int, 4)});
            // 
            // daBurdenSelection_ProjWO
            // 
            this.daBurdenSelection_ProjWO.SelectCommand = this.sqlSelectCommand2;
            this.daBurdenSelection_ProjWO.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "WO_LoadSelectedBurdens_ByProjectWO", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("burden_type_id", "burden_type_id"),
                        new System.Data.Common.DataColumnMapping("cb_id", "cb_id"),
                        new System.Data.Common.DataColumnMapping("burden_type", "burden_type"),
                        new System.Data.Common.DataColumnMapping("burden_desc", "burden_desc"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected")}),
            new System.Data.Common.DataTableMapping("Table1", "Table1", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("burden_type_id", "burden_type_id"),
                        new System.Data.Common.DataColumnMapping("cb_id", "cb_id"),
                        new System.Data.Common.DataColumnMapping("burden_type", "burden_type"),
                        new System.Data.Common.DataColumnMapping("burden_desc", "burden_desc"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected")})});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        pri_id, pri_code, CASE WHEN is_wo = \'T\' THEN pri_desc1 ELSE pri_nam" +
                "e END AS pri_desc\r\nFROM            PROJ_HEADER\r\nWHERE        (is_wo = @is_wo)\r\nO" +
                "RDER BY pri_code";
            this.sqlSelectCommand3.Connection = this.sqlConnTR;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@is_wo", System.Data.SqlDbType.VarChar, 1, "is_wo")});
            // 
            // daProjWO
            // 
            this.daProjWO.DeleteCommand = this.sqlDeleteCommand;
            this.daProjWO.InsertCommand = this.sqlInsertCommand;
            this.daProjWO.SelectCommand = this.sqlSelectCommand3;
            this.daProjWO.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_HEADER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_desc", "pri_desc")})});
            this.daProjWO.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = "DELETE FROM [PROJ_HEADER] WHERE (([pri_id] = @Original_pri_id) AND ((@IsNull_pri_" +
                "code = 1 AND [pri_code] IS NULL) OR ([pri_code] = @Original_pri_code)))";
            this.sqlDeleteCommand.Connection = this.sqlConnTR;
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Connection = this.sqlConnTR;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code")});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConnTR;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // frmLoadBurdens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoadBurdens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Burdens";
            this.Load += new System.EventHandler(this.frmLoadBurdens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectableBurdens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBurdenSelection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectableBurdens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            this.tpBySetup.ResumeLayout(false);
            this.tpByProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBurden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBurdenSelection_ProjWO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBurdenSelection_ProjWO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBurden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luProjWO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjWO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjWO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton bntOK;
        private DevExpress.XtraGrid.GridControl gcSelectableBurdens;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelectableBurdens;
        private System.Data.SqlClient.SqlConnection sqlConnTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daBurdenSelection;
        private dsBurdenSelection dsBurdenSelection1;
        private DevExpress.XtraGrid.Columns.GridColumn colburden_type;
        private DevExpress.XtraGrid.Columns.GridColumn colburden_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceSelected;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpType;
        private DevExpress.XtraTab.XtraTabPage tpBySetup;
        private DevExpress.XtraTab.XtraTabPage tpByProject;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancel_Type;
        private DevExpress.XtraEditors.SimpleButton btnOK_Type;
        private DevExpress.XtraGrid.GridControl gcBurden;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBurden;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ceSelProj;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit luProjWO;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll_Proj;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone_Proj;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCancel_Proj;
        private DevExpress.XtraEditors.SimpleButton bntOK_Proj;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daBurdenSelection_ProjWO;
        private dsBurdenSelection_ProjWO dsBurdenSelection_ProjWO1;
        private System.Windows.Forms.BindingSource bsBurdenSelection_ProjWO;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlDataAdapter daProjWO;
        private dsProjWO dsProjWO1;
        private System.Windows.Forms.BindingSource bsProjWO;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
    }
}