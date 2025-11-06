using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDataBaseManager;
using ItShopManagement.Reports;

namespace ItShopManagement
{
    public partial class main : Form
    {

        DBManager dbm = new DBManager();
        public main()
        {
            InitializeComponent();
        }


        private void vendorTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VendorTypes vt = new VendorTypes();
                vt.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void vendorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Vendor v = new Vendor();
                v.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductType pt = new ProductType();
                pt.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productCategotyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductCategory pc = new ProductCategory();
                pc.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmvendor v = new frmvendor();
                v.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                frmvendortype vt = new frmvendortype();
                vt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

            try
            {
                frmproducttype pt = new frmproducttype();
                pt.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void productCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmproductcaegroy pc = new frmproductcaegroy();
                pc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmproduct p = new frmproduct();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            try
            {
                frmorderstatus os = new frmorderstatus();
                os.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            try
            {
                frmpaymentmode pm = new frmpaymentmode();
                pm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FrmOrders o = new FrmOrders();
                o.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmuser u = new frmuser();
                u.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("c:/windows/system32/notepad.exe");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Windows/System32/calc.exe");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        { 
            // Close all forms except login form
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form form = Application.OpenForms[i];
                if (form.Name != "frmlogin") // Ensure this matches the actual login form name
                {
                    form.Close();
                }
            }

            // Check if login form is already open
            Form existingLoginForm = Application.OpenForms["frmlogin"];
            if (existingLoginForm != null)
            {
                existingLoginForm.Show();  // Bring the existing login form to the front
            }
            else
            {
                // If it's not open, create a new one
                frmlogin loginForm = new frmlogin();
                loginForm.Show();
            }
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void serviceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                frmservice p = new frmservice();
                p.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void serviceStatusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmservicestatus p = new frmservicestatus();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void serviceModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmservicemode p = new frmservicemode();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        }
    }

