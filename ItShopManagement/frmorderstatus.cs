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
    public partial class frmorderstatus : Form
    {

        DBManager dbm = new DBManager();
        BindingSource bsOS = new BindingSource();

        public frmorderstatus()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmorderstatus_Load(object sender, EventArgs e)
        {
            dbm.CDA_OrderStatus();
            bsOS = dbm.bsOrderStatus;

            tbOSid.DataBindings.Add(new Binding("Text", bsOS, "OrderStatusId", true));
            tbOSname.DataBindings.Add(new Binding("Text", bsOS, "OrderStatusName", true));

            dgvOS.DataSource = bsOS;
        }

       

        

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbOSid.Text = dbm.AddNewData(bsOS, "OrderStatus", "OrderStatusId");
            tbOSname.Focus();
        }

        private void btnVTsave_Click(object sender, EventArgs e)
        {
            dbm.SaveData(bsOS, dbm.daOrderStatus, "OrderStatus");
        }

        private void btnVTdel_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsOS);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
