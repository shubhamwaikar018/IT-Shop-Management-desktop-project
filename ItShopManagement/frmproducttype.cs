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
    public partial class frmproducttype : Form
    {
        DBManager dbm = new DBManager();
        BindingSource bsPt = new BindingSource();
        public frmproducttype()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmproducttype_Load(object sender, EventArgs e)
        {
            dbm.CDA_ProductType();
            bsPt = dbm.bsProductType;

            tbPTid.DataBindings.Add(new Binding("Text", bsPt, "ProductTypeId", true));
            tbPTname.DataBindings.Add(new Binding("Text", bsPt, "ProductTypeName", true));
            tbPTcgst.DataBindings.Add(new Binding("Text", bsPt, "CGST", true));
            tbPTsgst.DataBindings.Add(new Binding("Text", bsPt, "SGST", true));

            dgvPT.DataSource = bsPt;
        }

       
        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbPTid.Text = dbm.AddNewData(bsPt, "ProductType", "ProductTypeId");
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsPt, dbm.daProductType, "ProductType");
        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsPt);
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
