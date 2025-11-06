using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyDataBaseManager;



namespace ItShopManagement
{
    public partial class frmvendortype : Form
    {
        DBManager dbm = new DBManager();
        BindingSource bsVT = new BindingSource();
        public frmvendortype()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

      

        private void frmvendortype_Load(object sender, EventArgs e)
        {
            dbm.cdaVendorType();
            bsVT = dbm.bsVendorType;

           tbVTid.DataBindings.Add(new Binding("Text", bsVT, "VendorTypeId", true));
           tbVTname.DataBindings.Add(new Binding("Text", bsVT, "VendorTypeName", true));

            dgvVT.DataSource = bsVT;
        }

       
        
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbVTid.Text = dbm.AddNewData(bsVT, "VendorType", "VendorTypeId");
            tbVTname.Focus();
        }

        private void btnVTsave_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsVT, dbm.daVendorType, "VendorType");

        }

        private void btnVTdel_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsVT);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main Main = new main();
            Main.Show();
        }
    }
}
