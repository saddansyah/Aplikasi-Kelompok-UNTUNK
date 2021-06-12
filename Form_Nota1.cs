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
    public partial class Form_Nota1 : Form
    {
        //Membuat Koneksi 
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private string sellerName;
        Koneksi Konn = new Koneksi();
        Form_Nota1 frmNotaa;

        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_LaporanPenjualan frmLaporan;
        Form_Login frmLogin;
        Form_Homepage frmHome;
        public Form_Nota1(string total, string uangDiterima, string uangKembalian)
        {
            InitializeComponent();
        }
        private void btnInventForm_Click(object sender, EventArgs e)
        {
            frmBarang.Show();
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

        private void Form_Nota1_Load(object sender, EventArgs e)
        {

        }
    }
}
