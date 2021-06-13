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
    public partial class Form_LaporanPenjualan : Form
    {
        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_LaporanPenjualan frmLaporan;
        Form_Login frmLogin;
        Form_Homepage frmHome;

        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        Koneksi Konn = new Koneksi();

        public Form_LaporanPenjualan()
        {
            InitializeComponent();
        }
        private void btnInventForm_Click(object sender, EventArgs e)
        {
            frmBarang = new Form_KelolaBarang();
            frmBarang.ShowDialog();
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
        public void ShowData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM TBL_Transaksi", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Transaksi");
            dgvLaporan.DataSource = ds;
            dgvLaporan.DataMember = "TBL_Transaksi";

            //Beri exception
            dgvLaporan.AllowUserToAddRows = false;
            dgvLaporan.Refresh();

            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            cmd = new SqlCommand("DELETE FROM TBL_Transaksi", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            ShowData();
        }

        private void Form_LaporanPenjualan_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
