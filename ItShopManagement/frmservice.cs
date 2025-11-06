using MyDataBaseManager;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ItShopManagement
{
    public partial class frmservice : Form
    {
        private DBManager dbManager;
        private BindingSource bsService;
        private SqlDataAdapter daService;

        public frmservice()
        {
            InitializeComponent();
            dbManager = new DBManager();
            LoadService();
        }

        private void LoadService()
        {
            try
            {
                daService = dbManager.CreateDataAdapter("Service");
                DataSet ds = new DataSet();
                daService.Fill(ds, "Service");

                bsService = new BindingSource(ds, "Service");
                dgvService.DataSource = bsService;
                daService = dbManager.CreateDataAdapter
                   ("SELECT s.ServiceID, s.ServiceName, st.StatusName, m.ModeName " + 
                                         "FROM Service s " + 
                                         "JOIN ServiceStatus st ON s.ServiceStatusID = st.StatusID " + 
                             "JOIN ServiceMode m ON s.ServiceModeID = m.ModeID");

                txtServiceID.DataBindings.Add("Text", bsService, "ServiceID");
                txtServiceName.DataBindings.Add("Text", bsService, "ServiceName");
                txtServiceStatusName.DataBindings.Add("Text", bsService, "StatusName");
                txtServiceModeName.DataBindings.Add("Text", bsService, "ModeName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
        }


        private void btnVTsave_Click(object sender, EventArgs e)
        {
            try
            {
                bsService.EndEdit();
                daService.Update((DataSet)bsService.DataSource, "Service");
                MessageBox.Show("Service saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving service: " + ex.Message);
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsService.AddNew();
        }

        private void btnVexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main Main = new main();
            Main.Show();
        }

        private void btnVTdel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bsService.RemoveCurrent();
                daService.Update((DataSet)bsService.DataSource, "Service");
            }
        }

        private void frmservice_Load(object sender, EventArgs e)
        {
          

        }
    }
}
