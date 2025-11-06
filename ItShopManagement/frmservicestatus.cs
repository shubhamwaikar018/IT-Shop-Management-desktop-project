using MyDataBaseManager;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ItShopManagement
{
    public partial class frmservicestatus : Form
    {
        private DBManager dbManager;
        private BindingSource bsServiceStatus;
        private SqlDataAdapter daServiceStatus;

        public frmservicestatus()
        {
            InitializeComponent();
            dbManager = new DBManager();
            LoadServiceStatus();
        }

        private void LoadServiceStatus()
        {
            try
            {
                daServiceStatus = dbManager.CreateDataAdapter("ServiceStatus");
                DataSet ds = new DataSet();
                daServiceStatus.Fill(ds, "ServiceStatus");

                bsServiceStatus = new BindingSource(ds, "ServiceStatus");
                dgvServiceStatus.DataSource = bsServiceStatus;

                txtStatusID.DataBindings.Add("Text", bsServiceStatus, "StatusID");
                txtStatusName.DataBindings.Add("Text", bsServiceStatus, "StatusName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service statuses: " + ex.Message);
            }
        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtStatusID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStatusName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsServiceStatus.AddNew();
        }

        private void btnVTsave_Click(object sender, EventArgs e)
        {
            try
            {
                bsServiceStatus.EndEdit();
                daServiceStatus.Update((DataSet)bsServiceStatus.DataSource, "ServiceStatus");
                MessageBox.Show("Service status saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving service status: " + ex.Message);
            }
        }

        private void btnVTdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bsServiceStatus.RemoveCurrent();
                daServiceStatus.Update((DataSet)bsServiceStatus.DataSource, "ServiceMode");
            }
        }

        private void btnVexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main Main = new main();
            Main.Show();
        }
    }
}
