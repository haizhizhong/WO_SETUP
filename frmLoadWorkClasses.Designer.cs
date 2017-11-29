namespace WO_Setup
{
    partial class frmLoadWorkClasses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadWorkClasses));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.bntOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.gcSelectableWorkClasses = new DevExpress.XtraGrid.GridControl();
            this.workclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWorkClassSelection1 = new WO_Setup.dsWorkClassSelection();
            this.gvSelectableWorkClasses = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colwc_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwc_desc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlTR = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daWorkClassSelection = new System.Data.SqlClient.SqlDataAdapter();
            this.tcMain = new DevExpress.XtraTab.XtraTabControl();
            this.tpType = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rgType = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.btnOK_Type = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel_Type = new DevExpress.XtraEditors.SimpleButton();
            this.tpBySetup = new DevExpress.XtraTab.XtraTabPage();
            this.tpByProject = new DevExpress.XtraTab.XtraTabPage();
            this.gcWorkClass = new DevExpress.XtraGrid.GridControl();
            this.bsWorkClass = new System.Windows.Forms.BindingSource(this.components);
            this.dsWorkClass1 = new WO_Setup.dsWorkClass();
            this.gvWorkClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceSelProj = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelectAll_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.luProjWO = new DevExpress.XtraEditors.LookUpEdit();
            this.bsProjWO_WC = new System.Windows.Forms.BindingSource(this.components);
            this.dsProjWO_WC1 = new WO_Setup.dsProjWO_WC();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.bntOK_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel_Proj = new DevExpress.XtraEditors.SimpleButton();
            this.daProjWO_WC = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlDeleteCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daWorkClass = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectableWorkClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkClassSelection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectableWorkClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.tpBySetup.SuspendLayout();
            this.tpByProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkClass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luProjWO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjWO_WC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjWO_WC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl8);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(475, 32);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Controls.Add(this.btnSelectAll);
            this.panelControl8.Controls.Add(this.btnSelectNone);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl8.Location = new System.Drawing.Point(311, 2);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(162, 28);
            this.panelControl8.TabIndex = 2;
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
            this.panelControl2.Controls.Add(this.panelControl7);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 348);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(475, 32);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl7
            // 
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.bntOK);
            this.panelControl7.Controls.Add(this.btnCancel);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl7.Location = new System.Drawing.Point(311, 2);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(162, 28);
            this.panelControl7.TabIndex = 2;
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
            // gcSelectableWorkClasses
            // 
            this.gcSelectableWorkClasses.DataSource = this.workclassBindingSource;
            this.gcSelectableWorkClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSelectableWorkClasses.Location = new System.Drawing.Point(0, 32);
            this.gcSelectableWorkClasses.MainView = this.gvSelectableWorkClasses;
            this.gcSelectableWorkClasses.Name = "gcSelectableWorkClasses";
            this.gcSelectableWorkClasses.Size = new System.Drawing.Size(475, 316);
            this.gcSelectableWorkClasses.TabIndex = 2;
            this.gcSelectableWorkClasses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSelectableWorkClasses});
            // 
            // workclassBindingSource
            // 
            this.workclassBindingSource.DataMember = "work_class";
            this.workclassBindingSource.DataSource = this.dsWorkClassSelection1;
            // 
            // dsWorkClassSelection1
            // 
            this.dsWorkClassSelection1.DataSetName = "dsWorkClassSelection";
            this.dsWorkClassSelection1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvSelectableWorkClasses
            // 
            this.gvSelectableWorkClasses.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colwc_code,
            this.colwc_desc,
            this.colSelected});
            this.gvSelectableWorkClasses.GridControl = this.gcSelectableWorkClasses;
            this.gvSelectableWorkClasses.Name = "gvSelectableWorkClasses";
            // 
            // colwc_code
            // 
            this.colwc_code.Caption = "Code";
            this.colwc_code.FieldName = "wc_code";
            this.colwc_code.Name = "colwc_code";
            this.colwc_code.OptionsColumn.AllowEdit = false;
            this.colwc_code.Visible = true;
            this.colwc_code.VisibleIndex = 0;
            this.colwc_code.Width = 111;
            // 
            // colwc_desc
            // 
            this.colwc_desc.Caption = "Description";
            this.colwc_desc.FieldName = "wc_desc";
            this.colwc_desc.Name = "colwc_desc";
            this.colwc_desc.OptionsColumn.AllowEdit = false;
            this.colwc_desc.Visible = true;
            this.colwc_desc.VisibleIndex = 1;
            this.colwc_desc.Width = 223;
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Select";
            this.colSelected.FieldName = "Selected";
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 2;
            this.colSelected.Width = 70;
            // 
            // sqlTR
            // 
            this.sqlTR.ConnectionString = "Data Source=DEV12;Initial Catalog=TR_Test2;Persist Security Info=True;User ID=hms" +
                "qlsa;Password=hmsqlsa";
            this.sqlTR.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT     wc_co, wc_code, wc_desc, Regular, OverTime, DoubleTime, Travel, CONVER" +
                "T(bit, 0) AS Selected\r\nFROM         work_class\r\nWHERE     (1 = 1)\r\nORDER BY wc_c" +
                "ode";
            this.sqlSelectCommand1.Connection = this.sqlTR;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlTR;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@wc_co", System.Data.SqlDbType.Int, 0, "wc_co"),
            new System.Data.SqlClient.SqlParameter("@wc_code", System.Data.SqlDbType.VarChar, 0, "wc_code"),
            new System.Data.SqlClient.SqlParameter("@wc_desc", System.Data.SqlDbType.VarChar, 0, "wc_desc"),
            new System.Data.SqlClient.SqlParameter("@Regular", System.Data.SqlDbType.Money, 0, "Regular"),
            new System.Data.SqlClient.SqlParameter("@OverTime", System.Data.SqlDbType.Money, 0, "OverTime"),
            new System.Data.SqlClient.SqlParameter("@DoubleTime", System.Data.SqlDbType.Money, 0, "DoubleTime"),
            new System.Data.SqlClient.SqlParameter("@Travel", System.Data.SqlDbType.Money, 0, "Travel")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlTR;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@wc_co", System.Data.SqlDbType.Int, 0, "wc_co"),
            new System.Data.SqlClient.SqlParameter("@wc_code", System.Data.SqlDbType.VarChar, 0, "wc_code"),
            new System.Data.SqlClient.SqlParameter("@wc_desc", System.Data.SqlDbType.VarChar, 0, "wc_desc"),
            new System.Data.SqlClient.SqlParameter("@Regular", System.Data.SqlDbType.Money, 0, "Regular"),
            new System.Data.SqlClient.SqlParameter("@OverTime", System.Data.SqlDbType.Money, 0, "OverTime"),
            new System.Data.SqlClient.SqlParameter("@DoubleTime", System.Data.SqlDbType.Money, 0, "DoubleTime"),
            new System.Data.SqlClient.SqlParameter("@Travel", System.Data.SqlDbType.Money, 0, "Travel"),
            new System.Data.SqlClient.SqlParameter("@Original_wc_co", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_co", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_wc_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wc_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wc_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Regular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Regular", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Regular", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Regular", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OverTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OverTime", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DoubleTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DoubleTime", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Travel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Travel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Travel", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Travel", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlTR;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_wc_co", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_co", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_wc_code", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_wc_desc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_wc_desc", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wc_desc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Regular", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Regular", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Regular", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Regular", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_OverTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_OverTime", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OverTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DoubleTime", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DoubleTime", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DoubleTime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Travel", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Travel", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Travel", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Travel", System.Data.DataRowVersion.Original, null)});
            // 
            // daWorkClassSelection
            // 
            this.daWorkClassSelection.DeleteCommand = this.sqlDeleteCommand1;
            this.daWorkClassSelection.InsertCommand = this.sqlInsertCommand1;
            this.daWorkClassSelection.SelectCommand = this.sqlSelectCommand1;
            this.daWorkClassSelection.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "work_class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("wc_co", "wc_co"),
                        new System.Data.Common.DataColumnMapping("wc_code", "wc_code"),
                        new System.Data.Common.DataColumnMapping("wc_desc", "wc_desc"),
                        new System.Data.Common.DataColumnMapping("Regular", "Regular"),
                        new System.Data.Common.DataColumnMapping("OverTime", "OverTime"),
                        new System.Data.Common.DataColumnMapping("DoubleTime", "DoubleTime"),
                        new System.Data.Common.DataColumnMapping("Travel", "Travel"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected")})});
            this.daWorkClassSelection.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // tcMain
            // 
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedTabPage = this.tpType;
            this.tcMain.Size = new System.Drawing.Size(484, 411);
            this.tcMain.TabIndex = 3;
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
            this.tpType.Text = "Type";
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
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rgType
            // 
            this.rgType.Location = new System.Drawing.Point(148, 111);
            this.rgType.Name = "rgType";
            this.rgType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "From Project"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "From Setup")});
            this.rgType.Size = new System.Drawing.Size(189, 91);
            this.rgType.StyleController = this.layoutControl1;
            this.rgType.TabIndex = 8;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.emptySpaceItem4,
            this.emptySpaceItem3,
            this.emptySpaceItem2});
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
            this.layoutControlItem1.Location = new System.Drawing.Point(141, 86);
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
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 206);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(473, 140);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem4";
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(473, 86);
            this.emptySpaceItem4.Text = "emptySpaceItem4";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.CustomizationFormText = "emptySpaceItem3";
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 86);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(141, 120);
            this.emptySpaceItem3.Text = "emptySpaceItem3";
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(341, 86);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(132, 120);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl6);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 348);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(475, 32);
            this.panelControl3.TabIndex = 9;
            // 
            // panelControl6
            // 
            this.panelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl6.Controls.Add(this.btnOK_Type);
            this.panelControl6.Controls.Add(this.btnCancel_Type);
            this.panelControl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl6.Location = new System.Drawing.Point(310, 2);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(163, 28);
            this.panelControl6.TabIndex = 2;
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
            this.tpBySetup.Controls.Add(this.gcSelectableWorkClasses);
            this.tpBySetup.Controls.Add(this.panelControl2);
            this.tpBySetup.Controls.Add(this.panelControl1);
            this.tpBySetup.Name = "tpBySetup";
            this.tpBySetup.Size = new System.Drawing.Size(475, 380);
            this.tpBySetup.Text = "Setup";
            // 
            // tpByProject
            // 
            this.tpByProject.Controls.Add(this.gcWorkClass);
            this.tpByProject.Controls.Add(this.panelControl4);
            this.tpByProject.Controls.Add(this.panelControl5);
            this.tpByProject.Name = "tpByProject";
            this.tpByProject.Size = new System.Drawing.Size(475, 380);
            this.tpByProject.Text = "Project";
            // 
            // gcWorkClass
            // 
            this.gcWorkClass.DataSource = this.bsWorkClass;
            this.gcWorkClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcWorkClass.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcWorkClass.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcWorkClass.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcWorkClass.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcWorkClass.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcWorkClass.Location = new System.Drawing.Point(0, 32);
            this.gcWorkClass.MainView = this.gvWorkClass;
            this.gcWorkClass.Name = "gcWorkClass";
            this.gcWorkClass.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ceSelProj});
            this.gcWorkClass.Size = new System.Drawing.Size(475, 316);
            this.gcWorkClass.TabIndex = 9;
            this.gcWorkClass.UseEmbeddedNavigator = true;
            this.gcWorkClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkClass});
            // 
            // bsWorkClass
            // 
            this.bsWorkClass.DataMember = "work_class";
            this.bsWorkClass.DataSource = this.dsWorkClass1;
            // 
            // dsWorkClass1
            // 
            this.dsWorkClass1.DataSetName = "dsWorkClass";
            this.dsWorkClass1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvWorkClass
            // 
            this.gvWorkClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvWorkClass.GridControl = this.gcWorkClass;
            this.gvWorkClass.Name = "gvWorkClass";
            this.gvWorkClass.OptionsView.ColumnAutoWidth = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.FieldName = "wc_code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 115;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.FieldName = "wc_desc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 218;
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
            this.panelControl4.Controls.Add(this.panelControl10);
            this.panelControl4.Controls.Add(this.labelControl2);
            this.panelControl4.Controls.Add(this.luProjWO);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(0, 0);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(475, 32);
            this.panelControl4.TabIndex = 7;
            // 
            // panelControl10
            // 
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Controls.Add(this.btnSelectAll_Proj);
            this.panelControl10.Controls.Add(this.btnSelectNone_Proj);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl10.Location = new System.Drawing.Point(310, 2);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(163, 28);
            this.panelControl10.TabIndex = 4;
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
            this.luProjWO.Properties.DataSource = this.bsProjWO_WC;
            this.luProjWO.Properties.DisplayMember = "pri_code";
            this.luProjWO.Properties.NullText = "";
            this.luProjWO.Properties.PopupWidth = 280;
            this.luProjWO.Properties.ValueMember = "pri_id";
            this.luProjWO.Size = new System.Drawing.Size(172, 20);
            this.luProjWO.TabIndex = 2;
            this.luProjWO.EditValueChanged += new System.EventHandler(this.luProjWO_EditValueChanged);
            // 
            // bsProjWO_WC
            // 
            this.bsProjWO_WC.DataMember = "PROJ_HEADER";
            this.bsProjWO_WC.DataSource = this.dsProjWO_WC1;
            // 
            // dsProjWO_WC1
            // 
            this.dsProjWO_WC1.DataSetName = "dsProjWO_WC";
            this.dsProjWO_WC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl9);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(0, 348);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(475, 32);
            this.panelControl5.TabIndex = 8;
            // 
            // panelControl9
            // 
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Controls.Add(this.bntOK_Proj);
            this.panelControl9.Controls.Add(this.btnCancel_Proj);
            this.panelControl9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl9.Location = new System.Drawing.Point(310, 2);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(163, 28);
            this.panelControl9.TabIndex = 2;
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
            // daProjWO_WC
            // 
            this.daProjWO_WC.DeleteCommand = this.sqlDeleteCommand;
            this.daProjWO_WC.InsertCommand = this.sqlInsertCommand;
            this.daProjWO_WC.SelectCommand = this.sqlSelectCommand3;
            this.daProjWO_WC.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PROJ_HEADER", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("pri_id", "pri_id"),
                        new System.Data.Common.DataColumnMapping("pri_code", "pri_code"),
                        new System.Data.Common.DataColumnMapping("pri_desc", "pri_desc")})});
            this.daProjWO_WC.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlDeleteCommand
            // 
            this.sqlDeleteCommand.CommandText = "DELETE FROM [PROJ_HEADER] WHERE (([pri_id] = @Original_pri_id) AND ((@IsNull_pri_" +
                "code = 1 AND [pri_code] IS NULL) OR ([pri_code] = @Original_pri_code)))";
            this.sqlDeleteCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = resources.GetString("sqlInsertCommand.CommandText");
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code")});
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        pri_id, pri_code, CASE WHEN is_wo = \'T\' THEN pri_desc1 ELSE pri_nam" +
                "e END AS pri_desc\r\nFROM            PROJ_HEADER\r\nWHERE        (is_wo = @is_wo)\r\nO" +
                "RDER BY pri_code";
            this.sqlSelectCommand3.Connection = this.sqlTR;
            this.sqlSelectCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@is_wo", System.Data.SqlDbType.VarChar, 1, "is_wo")});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_code", System.Data.SqlDbType.Int, 0, "pri_code"),
            new System.Data.SqlClient.SqlParameter("@Original_pri_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_id", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pri_code", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pri_code", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4, "pri_id")});
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = resources.GetString("sqlSelectCommand2.CommandText");
            this.sqlSelectCommand2.Connection = this.sqlTR;
            this.sqlSelectCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@pri_id_sel", System.Data.SqlDbType.Int, 4, "pri_id"),
            new System.Data.SqlClient.SqlParameter("@pri_id", System.Data.SqlDbType.Int, 4)});
            // 
            // daWorkClass
            // 
            this.daWorkClass.SelectCommand = this.sqlSelectCommand2;
            this.daWorkClass.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "work_class", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("cwc_id", "cwc_id"),
                        new System.Data.Common.DataColumnMapping("wc_code", "wc_code"),
                        new System.Data.Common.DataColumnMapping("wc_desc", "wc_desc"),
                        new System.Data.Common.DataColumnMapping("Selected", "Selected")})});
            // 
            // frmLoadWorkClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoadWorkClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Work Classes";
            this.Load += new System.EventHandler(this.frmLoadWorkClasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSelectableWorkClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkClassSelection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSelectableWorkClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcMain)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.tpBySetup.ResumeLayout(false);
            this.tpByProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorkClass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSelProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luProjWO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjWO_WC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProjWO_WC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton bntOK;
        private DevExpress.XtraGrid.GridControl gcSelectableWorkClasses;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSelectableWorkClasses;
        private System.Data.SqlClient.SqlConnection sqlTR;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daWorkClassSelection;
        private dsWorkClassSelection dsWorkClassSelection1;
        private System.Windows.Forms.BindingSource workclassBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colwc_code;
        private DevExpress.XtraGrid.Columns.GridColumn colwc_desc;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
        private DevExpress.XtraTab.XtraTabControl tcMain;
        private DevExpress.XtraTab.XtraTabPage tpType;
        private DevExpress.XtraTab.XtraTabPage tpBySetup;
        private DevExpress.XtraTab.XtraTabPage tpByProject;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCancel_Type;
        private DevExpress.XtraEditors.SimpleButton btnOK_Type;
        private DevExpress.XtraEditors.RadioGroup rgType;
        private DevExpress.XtraGrid.GridControl gcWorkClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkClass;
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
        private System.Data.SqlClient.SqlDataAdapter daProjWO_WC;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private dsProjWO_WC dsProjWO_WC1;
        private System.Windows.Forms.BindingSource bsProjWO_WC;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlDataAdapter daWorkClass;
        private dsWorkClass dsWorkClass1;
        private System.Windows.Forms.BindingSource bsWorkClass;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}