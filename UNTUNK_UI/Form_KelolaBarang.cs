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
    public partial class Form_KelolaBarang : Form
    {
        //Membuat Koneksi 
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private string sellerName;
        Koneksi Konn = new Koneksi();

        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_Keranjang frmKeranjang;
        Form_LaporanPenjualan frmLaporan;
        Form_Login frmLogin;
        Form_Homepage frmHome;
        public Form_KelolaBarang()
        {
            InitializeComponent();
        }
        private void Form_Kategori_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKategori = null;
        }
        private void btnInventForm_Click(object sender, EventArgs e)
        {
            frmBarang.Show();
            this.Close();
        }

        private void btnKasirForm_Click(object sender, EventArgs e)
        {
            frmKasir.Show();
        }

        private void btnCategForm_Click(object sender, EventArgs e)
        {
            frmKategori.Show();
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
        private void btnCartForm_Click(object sender, EventArgs e)
        {
            frmKeranjang.Show();
        }

        private void Form_KelolaBarang_Load(object sender, EventArgs e)
        {
            tbIDBarang.Text = "";
            tbNamaBarang.Text = "";
            tbHargaJual.Text = "";
            tbHargaBeli.Text = "";
            cbSatuanBarang.Text = "";
            cbKategori.Text = "";

            ShowData();
            FillCombo();

        }
        public void FillCombo()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT IDKategori FROM TBL_Kategori", conn);
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();
            dt = new DataTable();
            //dt.Columns.Add("IDKategori", typeof(int));
            dt.Load(rd);

            cbKategori.ValueMember = "IDKategori";
            cbKategori.DataSource = dt;

            conn.Close();
        }
        private void ShowData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_Barang", conn);
            ds = new DataSet(); da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Barang");
            dgvDataBarang.DataSource = ds;
            dgvDataBarang.DataMember = "TBL_Barang";

            //Beri exception
            dgvDataBarang.AllowUserToAddRows = false;
            dgvDataBarang.Refresh();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbIDBarang.Text == "" || tbNamaBarang.Text == "" || tbHargaJual.Text == "" || tbHargaBeli.Text == "" || cbSatuanBarang.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO TBL_Barang VALUES('" + tbIDBarang.Text + "','" + tbNamaBarang.Text + "','" + tbHargaBeli.Text + "','" + tbHargaJual.Text + "','" + cbSatuanBarang.Text + "','" + cbKategori.Text + "')", conn);

                SqlCommand check_cmd = new SqlCommand("SELECT * FROM TBL_Barang WHERE IDBarang = '" + tbIDBarang.Text + "'", conn);
                check_cmd.ExecuteNonQuery();
                rd = check_cmd.ExecuteReader();

                if (rd.Read() == true && tbIDBarang.Text == rd[0].ToString())
                {
                    MessageBox.Show("ID Barang '" + rd[0].ToString() + "' sudah ada!");
                    rd.Close();
                }
                else
                {
                    rd.Close();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Barang baru telah disimpan");

                    tbIDBarang.Text = "";
                    tbNamaBarang.Text = "";
                    tbHargaBeli.Text = "";
                    tbHargaJual.Text = "";
                    cbSatuanBarang.Text = "";
                    cbKategori.Text = "";

                    ShowData();
                }
            }

        }
        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbKategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter)) //Biar kalo dienter langsung muncul usernamenya tanpa mencet tombol
                {
                    SqlConnection conn = Konn.GetConn();
                    cmd = new SqlCommand("SELECT IDKategori, NamaKategori FROM TBL_Kategori WHERE IDKategori =" + cbKategori.Text + "", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    rd = cmd.ExecuteReader();

                    if (rd.Read())
                    {
                        lblNamaKategori.Text = "Nama Kategori = " + rd[1].ToString();
                    }
                    else
                    {
                        lblNamaKategori.Text = "Not Found";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbIDBarang.Text == "" || tbNamaBarang.Text == "" || tbHargaJual.Text == "" || tbHargaBeli.Text == "" || cbSatuanBarang.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("UPDATE TBL_Barang SET NamaBarang='" + tbNamaBarang.Text + "', HargaBeli='" + tbHargaBeli.Text + "', HargaJual='" + tbHargaJual.Text + "', SatuanBarang='" + cbSatuanBarang.Text + "', IDKategori='" + cbKategori.Text + "' WHERE IDBarang='" + tbIDBarang.Text + "'", conn);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data barang " + tbIDBarang.Text + " telah diedit");

                tbIDBarang.Text = "";
                tbNamaBarang.Text = "";
                tbHargaBeli.Text = "";
                tbHargaJual.Text = "";
                cbSatuanBarang.Text = "";
                cbKategori.Text = "";
                conn.Close();

                ShowData();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDBarang.Text == "" || tbNamaBarang.Text == "" || tbHargaJual.Text == "" || tbHargaBeli.Text == "" || cbSatuanBarang.Text == "" || cbKategori.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("DELETE TBL_Barang WHERE IDBarang ='" + tbIDBarang.Text + "'", conn);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data barang " + tbIDBarang.Text + " telah dihapus");

                tbIDBarang.Text = "";
                tbNamaBarang.Text = "";
                tbHargaBeli.Text = "";
                tbHargaJual.Text = "";
                cbSatuanBarang.Text = "";
                cbKategori.Text = "";
                conn.Close();

                ShowData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM TBL_Barang WHERE IDBarang = '" + tbIDBarang.Text + "' OR NamaBarang = '" + tbNamaBarang.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                tbIDBarang.Text = rd[0].ToString();
                tbNamaBarang.Text = rd[1].ToString();
                tbHargaBeli.Text = rd[2].ToString();
                tbHargaJual.Text = rd[3].ToString();
                cbSatuanBarang.Text = rd[4].ToString();
                cbKategori.Text = rd[5].ToString();

                MessageBox.Show("Data barang ditemukan!");

            }
            else
            {
                MessageBox.Show("Data barang tidak ditemukan!");
            }
        }
        private void tbIDBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSearch_Click(sender, e);
            }
        }
        private void tbNamaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSearch_Click(sender, e);
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (frmKategori == null)
            {
                frmKategori = new Form_Kategori();
                frmKategori.FormClosed += new FormClosedEventHandler(Form_Kategori_FormClosed);
                frmKategori.Show();
            }
            else
            {
                frmKategori.Activate();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIDBarang.Text = "";
            tbNamaBarang.Text = "";
            tbHargaBeli.Text = "";
            tbHargaJual.Text = "";
            cbSatuanBarang.Text = "";
            cbKategori.Text = "";
        }

        private void dgvDataBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDBarang.Text = dgvDataBarang.CurrentRow.Cells[0].Value.ToString();
            tbNamaBarang.Text = dgvDataBarang.CurrentRow.Cells[1].Value.ToString();
            tbHargaBeli.Text = dgvDataBarang.CurrentRow.Cells[2].Value.ToString();
            tbHargaJual.Text = dgvDataBarang.CurrentRow.Cells[3].Value.ToString();
            cbSatuanBarang.Text = dgvDataBarang.CurrentRow.Cells[4].Value.ToString();
            cbKategori.Text = dgvDataBarang.CurrentRow.Cells[5].Value.ToString();
        }
    }  
}
