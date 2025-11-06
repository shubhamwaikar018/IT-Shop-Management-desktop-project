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
    public partial class ProductCategory : Form
    {
        public ProductCategory()
        {
            InitializeComponent();
        }

        private void ProductCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itShopManagmentDataSet5.ProductCategory' table. You can move, or remove it, as needed.
            this.productCategoryTableAdapter.Fill(this.itShopManagmentDataSet5.ProductCategory);

            // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
