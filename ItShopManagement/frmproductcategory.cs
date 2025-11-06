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
    public partial class frmproductcaegroy : Form
    {

        DBManager dbm = new DBManager();
        BindingSource bsPT = new BindingSource();
        BindingSource bsPC = new BindingSource();
        public frmproductcaegroy()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmproductcaegroy_Load(object sender, EventArgs e)
        {

            dbm.CDA_ProductCategory();
            dbm.CDA_ProductType();

            dbm.crProductType_ProductCat();


            bsPC = dbm.bsProductCategory;
            bsPT = dbm.bsProductType;

           


            tbPCid.DataBindings.Add(new Binding("Text", bsPC, "ProductCategoryId", true));
            tbPCname.DataBindings.Add(new Binding("Text", bsPC, "ProductCategoryName", true));

            cmbPCpt.DataSource = bsPT;
            cmbPCpt.DisplayMember = "productTypeName";
            cmbPCpt.ValueMember = "ProductTypeId";

            dataGridView1.DataSource = bsPC;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

       
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbPCid.Text = dbm.AddNewData(bsPC, "ProductCategory", "ProductCategoryId");
            tbPCname.Focus();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsPC, dbm.daProductCategory, "ProductCategory");
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsPC);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
