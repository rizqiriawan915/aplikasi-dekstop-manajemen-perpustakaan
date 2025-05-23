using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_LKS_IT_Software
{
    public partial class peminjamanBuku : Form
    {
        private MySqlConnection koneksi = new MySqlConnection("server=localhost;database=perpustakaan;uid=root;pwd=;");
        public peminjamanBuku()
        {
            InitializeComponent();
            DesainForm();
        }

        private void DesainForm()
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }

        private void DesainDataGridView()
        {
            dgvBuku.AllowUserToAddRows = false;
            dgvBuku.BorderStyle = BorderStyle.None;
            dgvBuku.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvBuku.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBuku.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvBuku.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvBuku.BackgroundColor = Color.White;
            dgvBuku.EnableHeadersVisualStyles = false;
            dgvBuku.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBuku.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvBuku.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBuku.RowTemplate.Height = 30;
            dgvBuku.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        public bool CekPeminjamTerdaftar(string nomorInduk)
        {
            bool isTerdaftar = false;
            string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM pengguna WHERE nomor_induk = @nomorInduk";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomorInduk", nomorInduk);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            isTerdaftar = true;  
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return isTerdaftar;
        }

        private void TampilkanDataBuku()
        {
            string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT 
                            kode_buku AS 'Kode Buku', 
                            judul_buku AS 'Judul Buku', 
                            penulis_buku AS 'Penulis', 
                            tahun_terbit AS 'Tahun Terbit', 
                            stok_buku AS 'Stok' 
                         FROM buku 
                         ORDER BY judul_buku ASC";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBuku.DataSource = dt;
                    dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    DesainDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void FormatDataGridViewBuku()
        {
            dgvBuku.Columns["kode_buku"].HeaderText = "Kode Buku";
            dgvBuku.Columns["judul_buku"].HeaderText = "Judul Buku";
            dgvBuku.Columns["penulis_buku"].HeaderText = "Penulis";
            dgvBuku.Columns["tahun_terbit"].HeaderText = "Tahun Terbit";
            dgvBuku.Columns["stok_buku"].HeaderText = "Stok";

            dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }


        private void peminjamanBuku_Load(object sender, EventArgs e)
        {
            cmbJabatan.Items.Add("Guru");
            cmbJabatan.Items.Add("Siswa/Siswi");
            cmbJabatan.Items.Add("Lainnya");
            TampilkanDataBuku();
        }

        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBuku.Rows[e.RowIndex];

                txtKodeBuku.Text = row.Cells["Kode Buku"].Value != null ? row.Cells["Kode Buku"].Value.ToString() : "";
                txtJudulBuku.Text = row.Cells["Judul Buku"].Value != null ? row.Cells["Judul Buku"].Value.ToString() : "";
                txtPenulisBuku.Text = row.Cells["Penulis"].Value != null ? row.Cells["Penulis"].Value.ToString() : "";
            }
        }

        private void CariBuku(string keyword)
        {
            string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT kode_buku, judul_buku, penulis_buku, tahun_terbit, stok_buku " +
                                   "FROM buku " +
                                   "WHERE judul_buku LIKE @keyword OR penulis_buku LIKE @keyword";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBuku.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            CariBuku(txtCari.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TampilkanDataBuku();

            txtCari.Text = "";  
            txtKodeBuku.Text = "";
            txtJudulBuku.Text = "";
            txtPenulisBuku.Text = "";
            dtpPinjam.Value = DateTime.Now;
            dtpPengembalian.Value = DateTime.Now;
        }

        private void LoadDataPeminjaman()
        {
            try
            {
                koneksi.Open();
                string query = "SELECT * FROM peminjaman";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBuku.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        public void SimpanPeminjaman(string nomorInduk, string kodeBuku, DateTime tanggalPinjam, DateTime tanggalKembali)
        {
            string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO peminjaman (nomor_induk, kode_buku, tanggal_pinjam, tanggal_kembali, status_peminjaman) " +
                                   "VALUES (@nomorInduk, @kodeBuku, @tanggalPinjam, @tanggalKembali, 'Dipinjam')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomorInduk", nomorInduk);
                        cmd.Parameters.AddWithValue("@kodeBuku", kodeBuku);
                        cmd.Parameters.AddWithValue("@tanggalPinjam", tanggalPinjam);
                        cmd.Parameters.AddWithValue("@tanggalKembali", tanggalKembali);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Peminjaman berhasil disimpan!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menyimpan peminjaman: " + ex.Message);
                }
            }
        }


        private void btnKirim_Click(object sender, EventArgs e)
        {
            string nomorInduk = txtNomorInduk.Text; 
            string kodeBuku = txtKodeBuku.Text; 
            DateTime tanggalPinjam = dtpPinjam.Value;
            DateTime tanggalKembali = dtpPengembalian.Value;

            if (CekPeminjamTerdaftar(nomorInduk))
            {
                SimpanPeminjaman(nomorInduk, kodeBuku, tanggalPinjam, tanggalKembali);
            }
            else
            {
                MessageBox.Show("Peminjam tidak terdaftar! Mohon periksa kembali.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            txtNomorInduk.Clear();
            txtNama.Clear();
            txtRuangan.Clear();
            txtNomorTelepon.Clear();
            cmbJabatan.SelectedIndex = -1;
        }
    }
}
