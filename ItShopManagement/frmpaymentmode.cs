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
    public partial class frmpaymentmode : Form
    {
        DBManager dbm = new DBManager();
        BindingSource bsPM = new BindingSource();

        public frmpaymentmode()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmpaymentmode_Load(object sender, EventArgs e)
        {
            dbm.CDA_Payment_Mode();

            bsPM = dbm.bsPaymentMode;

            tbPMid.DataBindings.Add(new Binding("Text", bsPM, "PaymentModeId", true));
            tbPMname.DataBindings.Add(new Binding("Text", bsPM, "PaymentModeName", true));
            dgvPM.DataSource = bsPM;
        }

       

        

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbPMid.Text = dbm.AddNewData(bsPM, "PaymentMode", "PaymentModeId");
            tbPMname.Focus();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsPM, dbm.daPaymentMode, "PaymentMode");

        }

        private void btndel_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsPM);

        }

        private void btnVexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
