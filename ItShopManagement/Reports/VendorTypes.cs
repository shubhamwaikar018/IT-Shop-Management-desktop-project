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
    public partial class VendorTypes : Form
    {
        public VendorTypes()
        {
            InitializeComponent();
        }

        private void VendorTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itShopManagmentDataSet1.VendorType' table. You can move, or remove it, as needed.
            this.vendorTypeTableAdapter.Fill(this.itShopManagmentDataSet1.VendorType);
            // TODO: This line of code loads data into the 'itShopManagmentDataSet1.VendorType' table. You can move, or remove it, as needed.


            // this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
