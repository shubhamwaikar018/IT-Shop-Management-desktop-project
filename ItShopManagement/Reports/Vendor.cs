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
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'itShopManagmentDataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.itShopManagmentDataSet.Vendor);

            this.reportViewer1.RefreshReport();
        }
    }
}
