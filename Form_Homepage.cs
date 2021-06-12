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
    public partial class Form_Homepage : Form
    {
        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_LaporanPenjualan frmLaporan;
        Form_Keranjang frmKeranjang;
        Form_Login frmLogin;

        private SqlCommand cmd;
        private SqlDataReader rd;
        Koneksi Konn = new Koneksi();
        string validation_name;
        public Form_Homepage()
        {
            InitializeComponent();
        }
        public void LoginValidation(string valid)
        {
            this.validation_name = valid.ToString();
        }
        private void Form_KelolaKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        private void Form_KelolaBarang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }
        private void Form_Kategori_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKategori = null;
        }
        private void Form_Keranjang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmKeranjang = null;
        }
        private void Form_LaporanPenjualan_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLaporan = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            cmd = new SqlCommand("SELECT NamaKasir, LevelKasir FROM TBL_Kasir WHERE Username = '" + validation_name + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            rd = cmd.ExecuteReader();

            if (rd.Read())
            {
                lblNamaKasir.Text = rd[0].ToString();
                lblLevelKasir.Text = rd[1].ToString();

                if (lblLevelKasir.Text == "Admin")
                {
                    btnInventForm.Enabled = true;
                    btnKasirForm.Enabled = true;
                    btnCartForm.Enabled = true;
                    btnReportForm.Enabled = true;
                    btnLogout.Enabled = true;
                }
                else
                {
                    btnInventForm.Enabled = false;
                    btnKasirForm.Enabled = false;
                    btnCartForm.Enabled = true;
                    btnReportForm.Enabled = true;
                    btnLogout.Enabled = true;
                }
            }
        }
        private void btnKasirForm_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new Form_KelolaKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(Form_KelolaKasir_FormClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void btnCartForm_Click(object sender, EventArgs e)
        {
            if (frmKeranjang == null)
            {
                frmKeranjang = new Form_Keranjang(lblNamaKasir.Text);
                frmKeranjang.FormClosed += new FormClosedEventHandler(Form_Keranjang_FormClosed);
                frmKeranjang.ShowDialog();
            }
            else
            {
                frmKeranjang.Activate();
            }
        }
        private void btnInventForm_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new Form_KelolaBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(Form_KelolaBarang_FormClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void btnCategForm_Click(object sender, EventArgs e)
        {
            if (frmKategori == null)
            {
                frmKategori = new Form_Kategori();
                frmKategori.FormClosed += new FormClosedEventHandler(Form_Kategori_FormClosed);
                frmKategori.ShowDialog();
            }
            else
            {
                frmKategori.Activate();
            }
        }

        private void btnReportForm_Click(object sender, EventArgs e)
        {
            if (frmLaporan == null)
            {
                frmLaporan = new Form_LaporanPenjualan();
                frmLaporan.FormClosed += new FormClosedEventHandler(Form_LaporanPenjualan_FormClosed);
                frmLaporan.ShowDialog();
            }
            else
            {
                frmLaporan.Activate();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin = new Form_Login();
            frmLogin.Show();
            this.Close();
        }

        private void Form_Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
