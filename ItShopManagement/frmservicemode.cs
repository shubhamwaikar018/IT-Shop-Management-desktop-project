using MyDataBaseManager;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ItShopManagement
{
    public partial class frmservicemode : Form
    {
        private DBManager dbManager;
        private BindingSource bsServiceMode;
        private SqlDataAdapter daServiceMode;

        public frmservicemode()
        {
            InitializeComponent();
            dbManager = new DBManager();
            LoadServiceMode();
        }

        private void LoadServiceMode()
        {
            try
            {
                daServiceMode = dbManager.CreateDataAdapter("ServiceMode");
                DataSet ds = new DataSet();
                daServiceMode.Fill(ds, "ServiceMode");

                bsServiceMode = new BindingSource(ds, "ServiceMode");
                dgvServiceMode.DataSource = bsServiceMode;

                txtModeID.DataBindings.Add("Text", bsServiceMode, "ModeID");
                txtModeName.DataBindings.Add("Text", bsServiceMode, "ModeName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service modes: " + ex.Message);
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bsServiceMode.AddNew();
        }

        private void btnVTsave_Click(object sender, EventArgs e)
        {
            try
            {
                bsServiceMode.EndEdit();
                daServiceMode.Update((DataSet)bsServiceMode.DataSource, "ServiceMode");
                MessageBox.Show("Service mode saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving service mode: " + ex.Message);
            }
        }

        private void btnVTdel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bsServiceMode.RemoveCurrent();
                daServiceMode.Update((DataSet)bsServiceMode.DataSource, "ServiceMode");
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
