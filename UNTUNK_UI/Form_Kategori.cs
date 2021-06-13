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
    public partial class Form_Kategori : Form
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
        public Form_Kategori()
        {
            InitializeComponent();
        }
        private void Form_Kategori_Load(object sender, EventArgs e)
        {
            tbIDKategori.Text = "";
            tbNamaKategori.Text = "";
            rtbDeskripsi.Text = "";

            ShowData();
        }
        private void kasir_btn_Click(object sender, EventArgs e)
        {
            frmKasir = new Form_KelolaKasir();
            frmKasir.ShowDialog();
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            frmKeranjang = new Form_Keranjang(sellerName);
            frmKeranjang.ShowDialog();
        }
        private void btnInventForm_Click(object sender, EventArgs e)
        {
            frmBarang = new Form_KelolaBarang();
            frmBarang.ShowDialog();
            this.Close();
        }

        private void btnKasirForm_Click(object sender, EventArgs e)
        {
            frmKasir = new Form_KelolaKasir();
            frmKasir.ShowDialog();
        }

        private void btnCategForm_Click(object sender, EventArgs e)
        {
            frmKategori = new Form_Kategori();
            frmKategori.ShowDialog();
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            frmLaporan = new Form_LaporanPenjualan();
            frmLaporan.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin = new Form_Login();
            frmLogin.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInput_Click(object sender, EventArgs e)
        {

            if (tbIDKategori.Text == "" || tbNamaKategori.Text == "" || rtbDeskripsi.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO TBL_Kategori VALUES('" + tbIDKategori.Text + "', '" + tbNamaKategori.Text + "','" + rtbDeskripsi.Text + "')", conn);

                SqlCommand check_cmd = new SqlCommand("SELECT * FROM TBL_Kategori WHERE idKategori = '" + tbIDKategori.Text + "'", conn);
                check_cmd.ExecuteNonQuery();
                rd = check_cmd.ExecuteReader();

                if (rd.Read() == true && tbIDKategori.Text == rd[0].ToString())
                {
                    MessageBox.Show("ID kATEGORI '" + rd[0].ToString() + "' sudah ada!");
                    rd.Close();
                }
                else
                {
                    rd.Close();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori baru telah disimpan");

                    tbIDKategori.Text = "";
                    tbNamaKategori.Text = "";
                    rtbDeskripsi.Text = "";

                    ShowData();
                }
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbIDKategori.Text == "" || tbNamaKategori.Text == "" || rtbDeskripsi.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("UPDATE TBL_Kategori SET IDKategori='" + tbIDKategori.Text + "', NamaKategori='" + tbNamaKategori.Text + "', DeskripsiKategori='" + rtbDeskripsi.Text + "')", conn);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kategori " + tbNamaKategori.Text + " telah diedit");

                tbIDKategori.Text = "";
                tbNamaKategori.Text = "";
                rtbDeskripsi.Text = "";
                conn.Close();

                ShowData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbIDKategori.Text == "" || tbNamaKategori.Text == "" || rtbDeskripsi.Text == "")
            {
                MessageBox.Show("Semua form harus diisi!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                cmd = new SqlCommand("DELETE TBL_Kategori WHERE IDKategori ='" + tbIDKategori.Text + "'", conn);
                conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data kategori " + tbIDKategori.Text + " telah dihapus");

                tbIDKategori.Text = "";
                tbNamaKategori.Text = "";
                rtbDeskripsi.Text = "";
                conn.Close();

                ShowData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            cmd = new SqlCommand("SELECT * FROM TBL_Kategori WHERE IDKategori = '" + tbIDKategori.Text + "'OR NamaKategori = '" + tbNamaKategori.Text + "' OR DeskripsiKategori = '" + rtbDeskripsi.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                tbIDKategori.Text = rd[0].ToString();
                tbNamaKategori.Text = rd[1].ToString();
                rtbDeskripsi.Text = rd[2].ToString();

                MessageBox.Show("Data kategori ditemukan!");

            }
            else
            {
                MessageBox.Show("Data kategori tidak ditemukan!");
            }
        }
        private void dgvKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDKategori.Text = dgvKategori.CurrentRow.Cells[0].Value.ToString();
            tbNamaKategori.Text = dgvKategori.CurrentRow.Cells[1].Value.ToString();
            rtbDeskripsi.Text = dgvKategori.CurrentRow.Cells[2].Value.ToString();
        }
        private void ShowData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_Kategori", conn);
            ds = new DataSet(); da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Kategori");

            dgvKategori.DataSource = ds;
            dgvKategori.DataMember = "TBL_Kategori";

            //Beri exception
            dgvKategori.AllowUserToAddRows = false;
            dgvKategori.Refresh();
        }

        
    }
}
