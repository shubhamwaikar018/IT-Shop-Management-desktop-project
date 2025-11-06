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




namespace ItShopManagement
{
    public partial class frmproduct : Form
    {
        DBManager dbm = new DBManager();
        BindingSource bsPT = new BindingSource();
        BindingSource bsPC = new BindingSource();
        BindingSource bsP = new BindingSource();

        public frmproduct()
        {
            InitializeComponent();
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {
            dbm.CDA_ProductType();
            dbm.CDA_ProductCategory();
            dbm.CDA_Products();

            
            dbm.crProductType_ProductCat();
            dbm.crProductcat_Products();
            bsPT = dbm.bsProductType;
            bsPC = dbm.bsProductCategory;
            bsP = dbm.bsProducts;

            tbPid.DataBindings.Add(new Binding("Text", bsP, "ProductId", true));
            tbPname.DataBindings.Add(new Binding("Text", bsP, "ProductName", true));
            tbPdesc.DataBindings.Add(new Binding("Text", bsP, "ProductDescription", true));
            tbPquantity.DataBindings.Add(new Binding("Text", bsP, "Quantity", true));
            tbPprice.DataBindings.Add(new Binding("Text", bsP, "UnitPrice", true));
            tbPmargin.DataBindings.Add(new Binding("Text", bsP, "Margin", true));
            tbPreorder.DataBindings.Add(new Binding("Text", bsP, "ReOrderLevel", true));

            cmbPpt.DataSource = bsPT;
            cmbPpt.DisplayMember = "ProductTypeName";
            cmbPpt.ValueMember = "ProductTypeId";

            comboBox2.DataSource = bsPC;
            comboBox2.DisplayMember = "ProductCategoryName";
            comboBox2.ValueMember = "ProductCategoryId";

            dataGridView1.DataSource = bsP;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

       

      

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbPid.Text = dbm.AddNewData(bsP, "Products", "ProductId");
            tbPname.Focus();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsP, dbm.daProducts, "Products");

        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsP);
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
