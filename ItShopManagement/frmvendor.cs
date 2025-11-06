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
    public partial class frmvendor : Form
    {
        DBManager dbm = new DBManager();
        BindingSource bsV = new BindingSource();
        BindingSource bsVT = new BindingSource();
        public frmvendor()
        {
            InitializeComponent();
        }

        private void frmvendor_Load(object sender, EventArgs e)
        {
            dbm.cdaVendorType();
            dbm.cdaVendors();
            dbm.crVendorType_Vendors();


            bsVT = dbm.bsVendorType;
            bsV = dbm.bsVendors;



            tbVid.DataBindings.Add(new Binding("Text", bsV, "VendorId", true));
            tbVname.DataBindings.Add(new Binding("Text", bsV, "VendorName", true));
            tbVadrs.DataBindings.Add(new Binding("Text", bsV, "Address", true));
            tbVcity.DataBindings.Add(new Binding("Text", bsV, "City", true));
            tbVcn.DataBindings.Add(new Binding("Text", bsV, "ContactNo", true));
            tbVmail.DataBindings.Add(new Binding("Text", bsV, "EmailId", true));

            // comboBox1.DataBindings.Add(new Binding("SelectedValue", bsV, "VendorTypeId", true));


            comboBox1.DataSource = bsVT;
            comboBox1.DisplayMember = "VendorTypeName";
            comboBox1.ValueMember = "VendorTypeId";


            dgvV.DataSource = bsV;
            
            dgvV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }

       

        private void btnVadd_Click_1(object sender, EventArgs e)
        {
            tbVid.Text = dbm.AddNewData(bsV, "Vendor", "VendorId");
            tbVname.Focus();
        }

        private void btnVsave_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsV, dbm.daVendor, "Vendor");

        }

        private void btnVdel_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsV);

        }

        private void btnVexit_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tbVid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
