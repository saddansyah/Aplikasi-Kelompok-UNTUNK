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

namespace DashboardUNTUNK
{
    public partial class Form_Login : Form
    {
        //Membuat Koneksi 
        private SqlCommand cmd;
        Koneksi Konn = new Koneksi();
        string validation_name;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM TBL_Kasir WHERE Username='" + tbUsername.Text + "' AND PasswordKasir='" + tbPassword.Text + "'");
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    validation_name = tbUsername.Text;
                    Form_Homepage homepage = new Form_Homepage();
                    homepage.LoginValidation(validation_name.ToString());
                    homepage.Show();
                    this.Hide();
                }
                else if (tbPassword.Text == "" || tbUsername.Text == "")
                {
                    MessageBox.Show("Username dan/atau Password tidak boleh kosong");
                }
                else
                {
                    MessageBox.Show("Username dan/atau Password salah");
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
