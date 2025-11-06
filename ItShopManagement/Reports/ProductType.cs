using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItShopManagement.Reports
{
    public partial class ProductType : Form
    {
        public ProductType()
        {
            InitializeComponent();
        }

        private void ProductType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itShopManagmentDataSet3.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.itShopManagmentDataSet3.ProductType);
            // TODO: This line of code loads data into the 'itShopManagmentDataSet3.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.itShopManagmentDataSet3.ProductType);

            this.reportViewer1.RefreshReport();
        }
    }
}
