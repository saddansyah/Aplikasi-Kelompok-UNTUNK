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
    public partial class Form_Keranjang: Form
    {
        //Membuat Koneksi 
        private SqlCommand cmd;
        private DataSet ds;
        private DataTable dt;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        private string sellerName;
        Koneksi Konn = new Koneksi();
        Form_Nota1 frmNota;

        Form_KelolaBarang frmBarang;
        Form_Kategori frmKategori;
        Form_KelolaKasir frmKasir;
        Form_LaporanPenjualan frmLaporan;
        Form_Login frmLogin;
        Form_Homepage frmHome;
        public Form_Keranjang(string sellerName)
        {
            InitializeComponent();
            this.sellerName = sellerName;
        }
        public void ShowData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT IDBarang, NamaBarang, HargaJual FROM TBL_Barang", conn);
            ds = new DataSet(); da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Barang");
            dgvBarang.DataSource = ds;
            dgvBarang.DataMember = "TBL_Barang";

            //Beri exception
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.Refresh();
        }
        public void ShowSearchData()
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("SELECT IDBarang, NamaBarang, HargaJual FROM TBL_Barang WHERE NamaBarang LIKE '%" + tbSearch.Text + "%'", conn);
            ds = new DataSet(); da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_Barang");
            dgvBarang.DataSource = ds;
            dgvBarang.DataMember = "TBL_Barang";

            //Beri exception
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.Refresh();
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

        private void Form_Keranjang_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Today.Day.ToString() + " - " + DateTime.Today.Month.ToString() + " - " + DateTime.Today.Year.ToString();
            tbIDBarang.Text = "";
            tbNamaBarang.Text = "";
            tbHargaBarang.Text = "";
            udJumlah.Text = "";
            dgvKeranjang.AllowUserToAddRows = false;
            btnBeli.Enabled = false;

            ShowData(); //Menampilkan ke datagridview barang
        }
        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDBarang.Text = dgvKeranjang.CurrentRow.Cells[0].Value.ToString();
            tbNamaBarang.Text = dgvKeranjang.CurrentRow.Cells[1].Value.ToString();
            tbHargaBarang.Text = dgvKeranjang.CurrentRow.Cells[2].Value.ToString();
            udJumlah.Text = dgvKeranjang.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbIDBarang.Text = dgvBarang.CurrentRow.Cells[0].Value.ToString();
            tbNamaBarang.Text = dgvBarang.CurrentRow.Cells[1].Value.ToString();
            tbHargaBarang.Text = dgvBarang.CurrentRow.Cells[2].Value.ToString();
            udJumlah.Text = "1";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNamaBarang.Text == "" || tbIDBarang.Text == "" || tbHargaBarang.Text == "" || udJumlah.Text == "")
            {
                MessageBox.Show("Tidak boleh kosong!");
            }
            else
            {
                int Total = 0;
                bool isFound = false;

                if (dgvKeranjang.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvKeranjang.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == tbIDBarang.Text && Convert.ToString(row.Cells[1].Value) == tbNamaBarang.Text && Convert.ToString(row.Cells[2].Value) == tbHargaBarang.Text)
                        {
                            row.Cells[3].Value = Convert.ToString(Convert.ToInt32(row.Cells[3].Value) + Convert.ToInt32(udJumlah.Text));
                            isFound = true;
                        }
                    }
                    if (!isFound)
                    {
                        dgvKeranjang.Rows.Add(tbIDBarang.Text, tbNamaBarang.Text, tbHargaBarang.Text, udJumlah.Text);
                    }
                }
                else
                {
                    dgvKeranjang.Rows.Add(tbIDBarang.Text, tbNamaBarang.Text, tbHargaBarang.Text, udJumlah.Text);
                }


                foreach (DataGridViewRow row in dgvKeranjang.Rows)
                {
                    row.Cells[dgvKeranjang.Columns[4].Index].Value = (Convert.ToInt32(row.Cells[dgvKeranjang.Columns[2].Index].Value)) * (Convert.ToInt32(row.Cells[dgvKeranjang.Columns[3].Index].Value));
                    Total += (Convert.ToInt32(Convert.ToInt32(row.Cells[4].Value)));
                }

                lblTotal.Text = Total.ToString();
            }

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int Total = 0;

            int deletedIndex = dgvKeranjang.CurrentCell.RowIndex;
            dgvKeranjang.Rows.RemoveAt(deletedIndex);

            foreach (DataGridViewRow row in dgvKeranjang.Rows)
            {
                Total += (Convert.ToInt32(Convert.ToInt32(row.Cells[4].Value)));
            }

            lblTotal.Text = Total.ToString();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                conn.Open();
                cmd = new SqlCommand("INSERT INTO TBL_Transaksi(NamaKasir, TanggalTransaksi, TotalTransaksi) VALUES('" + this.sellerName + "','" + lblTanggal.Text + "','" + lblTotal.Text + "')", conn);
                cmd.ExecuteNonQuery();

                frmNota = new Form_Nota1(lblTotal.Text, tbKeranjangUangDiterima.Text, lblKembalian.Text, this.sellerName, lblTanggal.Text, dgvKeranjang);
                frmNota.ShowDialog();

                dgvKeranjang.Rows.Clear();
                tbIDBarang.Text = "";
                tbNamaBarang.Text = "";
                tbHargaBarang.Text = "";
                udJumlah.Text = "";
            }

        }

        private void tbKeranjangUangDiterima_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (tbKeranjangUangDiterima.Text == "")
                {
                    lblKembalian.Text = "-";
                    btnBeli.Enabled = false;
                }
                else if (Convert.ToInt32(tbKeranjangUangDiterima.Text) >= Convert.ToInt32(lblTotal.Text))
                {
                    lblKembalian.Text = (Convert.ToInt32(tbKeranjangUangDiterima.Text) - Convert.ToInt32(lblTotal.Text)).ToString();
                    btnBeli.Enabled = true;
                }
                else
                {
                    lblKembalian.Text = "Uang tidak cukup!";
                    btnBeli.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUangPas_Click(object sender, EventArgs e)
        {
            tbKeranjangUangDiterima.Text = lblTotal.Text;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ShowSearchData();
        }

        private void btnCartForm_Click(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
