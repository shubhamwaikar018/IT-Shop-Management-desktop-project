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
    public partial class frmuser : Form
    {

        DBManager dbm = new DBManager();
        BindingSource bsU = new BindingSource();

        public frmuser()
        {
            InitializeComponent();
        }

        private void frmuser_Load(object sender, EventArgs e)
        {
            dbm.CDA_Users();
            bsU = dbm.bsuser;

            tbUid.DataBindings.Add(new Binding("Text", bsU, "UserId", true));
            tbUname.DataBindings.Add(new Binding("Text", bsU, "UserName", true));
            tbUpwd.DataBindings.Add(new Binding("Text", bsU, "Password", true));

            dgvUser.DataSource = bsU;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

      
       

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            tbUid.Text = dbm.AddNewData(bsU, "Users", "UserId");
            tbUname.Focus();
        }

        private void btnVTsave_Click(object sender, EventArgs e)
        {
           
            dbm.SaveData(bsU, dbm.dausers, "Users");
        }

        private void btnVTdel_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsU);
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVexit_Click(object sender, EventArgs e)
        {
            this.Hide();
            main Main = new main();
            Main.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
