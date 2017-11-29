using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {

        private HMConnection.HMCon hmConn;
        private TUC_HMDevXManager.TUC_HMDevXManager hmDevManager;
        public Form1()
        {

            InitializeComponent();
            LoadUserControls();
            //LoadBurden();
        }
        private void LoadUserControls()
        {
            this.hmDevManager = new TUC_HMDevXManager.TUC_HMDevXManager();
            //hmConn = new HMConnection.HMCon("web_eric", @"dev-sql2014\dev2014", 12, "Eric");
            //   hmConn = new HMConnection.HMCon("web_strike_test", @"dev11", 12, "adam");
            hmConn = new HMConnection.HMCon("web_test_v11", "dev12", 12, "ying");


            WO_Setup.ucSetup_Burden loadBurden = new WO_Setup.ucSetup_Burden(hmConn, hmDevManager);
            loadBurden.Dock = DockStyle.Fill;
            loadBurden.Parent = xtraTabPage1;
            
          loadBurden.LoadBurdens(1, false);

            WO_Setup.ucSetup_WorkClasses workClass = new WO_Setup.ucSetup_WorkClasses(hmConn, hmDevManager);
            workClass.Dock = DockStyle.Fill;
            workClass.Parent = xtraTabPage2;
            workClass.LoadCostingWorkClass(1, false);

            WO_Setup.ucSetup_EqiClasses EqiClasses = new WO_Setup.ucSetup_EqiClasses(hmConn, hmDevManager);
            EqiClasses.Dock = DockStyle.Fill;
            EqiClasses.Parent = xtraTabPage3;
            EqiClasses.LoadCostingEqiClass(443, false);   ///50
         
        }

        private void LoadBurden()
        {
            this.hmDevManager = new TUC_HMDevXManager.TUC_HMDevXManager();
            hmConn = new HMConnection.HMCon("web_eric", @"dev-sql2014\dev2014", 12, "Eric");
            

            WO_Setup.ucSetup_Burden loadBurden = new WO_Setup.ucSetup_Burden(hmConn, hmDevManager);
            loadBurden.Dock = DockStyle.Fill;
            loadBurden.Parent = xtraTabPage1;

            loadBurden.LoadBurdens(2, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hmDevManager.AppInit(hmConn.MLUser);
            hmDevManager.FormInit(this);
        }
    }
}
