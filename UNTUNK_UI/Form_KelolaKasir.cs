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
    public partial class Form_KelolaKasir : Form
    {
        //Membuat Koneksi 
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private string sellerName;
        Koneksi Konn = new Koneksi();
        Form_Nota frmNota;

        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_LaporanPenjualan frmLaporan;
        Form_Login frmLogin;
        Form_Homepage frmHome;
        Form_Keranjang frmKeranjang;
        public Form_KelolaKasir()
        {
            InitializeComponent();
        }
        

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void proceed_btn_Click(object sender, EventArgs e)
        {
            Form_Nota proceed = new Form_Nota();
            proceed.ShowDialog();

        }

        private void tbKasirUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCartForm_Click(object sender, EventArgs e)
        {
            frmKeranjang.Show();
        }

        private void btnCategForm_Click(object sender, EventArgs e)
        {
            frmKategori.Show();
        }

        private void btnInventForm_Click(object sender, EventArgs e)
        {
            frmBarang.Show();
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            frmLaporan.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin = new Form_Login();
            frmLogin.Show();
            this.Close();
        }

        private void Form_KelolaKasir_Load(object sender, EventArgs e)
        {
            tbKasirNamaKasir.Text = "";
            tbKasirUsername.Text = "";
            tbKasirPasswordKasir.Text = "";
            cbKasirLevelKasir.Text = "";

            dgvDataKasir.ReadOnly = true;
            ShowData();
        }
        private void ShowData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_Kasir", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Kasir");
            dgvDataKasir.DataSource = ds;
            dgvDataKasir.DataMember = "TBL_Kasir";

            //Beri exception
            dgvDataKasir.AllowUserToAddRows = false;
            dgvDataKasir.Refresh();

            conn.Close();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbKasirUsername.Text == "" || tbKasirNamaKasir.Text == "" || tbKasirPasswordKasir.Text == "" || cbKasirLevelKasir.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("INSERT INTO TBL_Kasir VALUES('" + tbKasirUsername.Text + "','" + tbKasirNamaKasir.Text + "','" + tbKasirPasswordKasir.Text + "','" + cbKasirLevelKasir.Text + "')", conn);
                conn.Open();

                SqlCommand check_cmd = new SqlCommand("SELECT * FROM TBL_Kasir WHERE Username = '" + tbKasirUsername.Text + "'", conn);
                check_cmd.ExecuteNonQuery();
                rd = check_cmd.ExecuteReader();

                if (rd.Read() == true && tbKasirUsername.Text == rd[0].ToString())
                {
                    MessageBox.Show("Username '" + tbKasirUsername.Text + "' sudah ada!");
                    rd.Close();
                }
                else
                {
                    rd.Close();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data kasir baru telah disimpan");

                    tbKasirNamaKasir.Text = "";
                    tbKasirUsername.Text = "";
                    tbKasirPasswordKasir.Text = "";
                    cbKasirLevelKasir.Text = "";

                    ShowData();
                }

                conn.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM TBL_Kasir WHERE Username = '" + tbKasirUsername.Text + "' OR NamaKasir = '" + tbKasirNamaKasir.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            if (rd.Read() == true)
            {
                tbKasirUsername.Text = rd[0].ToString();
                tbKasirNamaKasir.Text = rd[1].ToString();
                tbKasirPasswordKasir.Text = rd[2].ToString();
                cbKasirLevelKasir.Text = rd[3].ToString();

                MessageBox.Show("Data kasir ditemukan!");
            }
            else
            {
                MessageBox.Show("Data kasir tidak ada!");
            }
            conn.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbKasirUsername.Text == "" || tbKasirNamaKasir.Text == "" || tbKasirPasswordKasir.Text == "" || cbKasirLevelKasir.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("UPDATE TBL_Kasir SET NamaKasir='" + tbKasirNamaKasir.Text + "', PasswordKasir='" + tbKasirPasswordKasir.Text + "', LevelKasir='" + cbKasirLevelKasir.Text + "' WHERE Username='" + tbKasirUsername.Text + "'", conn);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kasir " + tbKasirUsername.Text + " telah diedit");

                tbKasirNamaKasir.Text = "";
                tbKasirUsername.Text = "";
                tbKasirPasswordKasir.Text = "";
                cbKasirLevelKasir.Text = "";
                conn.Close();

                ShowData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbKasirUsername.Text == "" || tbKasirNamaKasir.Text == "" || tbKasirPasswordKasir.Text == "" || cbKasirLevelKasir.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("DELETE TBL_Kasir WHERE Username='" + tbKasirUsername.Text + "'", conn);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kasir " + tbKasirUsername.Text + " telah dihapus");

                tbKasirNamaKasir.Text = "";
                tbKasirUsername.Text = "";
                tbKasirPasswordKasir.Text = "";
                cbKasirLevelKasir.Text = "";
                conn.Close();

                ShowData();
            }
        }
        private void tbKasirUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) //Biar kalo dienter langsung muncul usernamenya tanpa mencet tombol
            {
                btnSearch_Click(sender, e);
            }
        }
        private void tbKasirNamaKasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSearch_Click(sender, e);
            }
        }

        private void dgvDataKasir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbKasirUsername.Text = dgvDataKasir.CurrentRow.Cells[0].Value.ToString();
            tbKasirNamaKasir.Text = dgvDataKasir.CurrentRow.Cells[1].Value.ToString();
            tbKasirPasswordKasir.Text = dgvDataKasir.CurrentRow.Cells[2].Value.ToString();
            cbKasirLevelKasir.Text = dgvDataKasir.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbKasirNamaKasir.Text = "";
            tbKasirPasswordKasir.Text = "";
            tbKasirUsername.Text = "";
            cbKasirLevelKasir.Text = "";
        }
        private void tbKasirPasswordKasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("Pencarian hanya bisa lewat username atau nama kasir!");
            }
        }
        private void cbKasirLevelKasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("Pencarian hanya bisa lewat username atau nama kasir!");
            }
        }
    }
}
