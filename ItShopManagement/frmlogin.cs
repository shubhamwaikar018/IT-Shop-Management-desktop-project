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
using ItShopManagement.Reports;

namespace ItShopManagement
{
    public partial class frmlogin : Form
    {
        String cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ItShopManagement-20240722T064145Z-001\ItShopManagement\ItShopManagement\bin\Debug\ItShopManagment.mdf;Integrated Security=True;Connect Timeout=30;";
        public frmlogin()
        {
            InitializeComponent();
        }

     
        

        private void frmlogin_Load(object sender, EventArgs e)
        {
            //tbusernmae.SetWatermark("Enter User Name");
            //tbpwd.SetWatermark("Enter User Name");
        }

        private void cbshow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbshow.Checked == true)
            {
                tbpwd.UseSystemPasswordChar = false;
            }
            else
            {
                tbpwd.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (tbusernmae.Text == "" || tbpwd.Text == "")
            {
                MessageBox.Show("Please Enter Valid Username And Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbusernmae.Focus();
                return;
            }
            try
            {
                SqlConnection mycon = default(SqlConnection);
                mycon = new SqlConnection(cn);
                SqlCommand cmd = new SqlCommand("select UserName,Password from Users where UserName=@UserName and Password=@Password", mycon);
                cmd.Parameters.AddWithValue("@UserName", tbusernmae.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", tbpwd.Text.Trim());
                mycon.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                mycon.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    //MessageBox.Show("Login Successfull!!","Login Messge",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
            
                    main mdi = new main();
                    mdi.Show();
                }
                else
                {
                    MessageBox.Show("Login Fail");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void splitContainer4_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer5_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbusernmae_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
