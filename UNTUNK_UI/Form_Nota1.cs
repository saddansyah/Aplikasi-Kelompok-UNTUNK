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
using Microsoft.Reporting.WinForms;

namespace DashboardUNTUNK
{
    public partial class Form_Nota1 : Form
    {

        private List<Receipt> purchasedItem = new List<Receipt>();
        private DataGridView dgvCart;
        private string total, uangDiterima, uangKembalian, namaKasir, tanggalTransaksi;
        ReportDataSource rs = new ReportDataSource();

        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_LaporanPenjualan frmLaporan;
        Form_Login frmLogin;
        Form_Homepage frmHome;

        public Form_Nota1(string total, string uangDiterima, string uangKembalian, string namaKasir, string tanggalTransaksi, DataGridView dgv)
        {
            this.dgvCart = dgv;
            this.total = total;
            this.uangDiterima = uangDiterima;
            this.uangKembalian = uangKembalian;
            this.namaKasir = namaKasir;
            this.tanggalTransaksi = tanggalTransaksi;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin = new Form_Login();
            frmLogin.Show();
            this.Close();
        }

        private void Form_Nota1_Load(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in this.dgvCart.Rows)
            {
                purchasedItem.Add(new Receipt()
                {
                    ItemName = item.Cells[1].Value.ToString(),
                    Price = item.Cells[2].Value.ToString(),
                    Qty = item.Cells[3].Value.ToString(),
                    Total = item.Cells[4].Value.ToString()
                });
            }

            rs.Name = "ds";
            rs.Value = purchasedItem;

            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("pTotal", total),
                new ReportParameter("pUang", uangDiterima),
                new ReportParameter("pKembalian", uangKembalian),
                new ReportParameter("pKasir", namaKasir),
                new ReportParameter("pTanggal", tanggalTransaksi)
            };

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rs);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DashboardUNTUNK.Nota.rdlc";
            this.reportViewer1.LocalReport.SetParameters(para);

        }
    }
}
