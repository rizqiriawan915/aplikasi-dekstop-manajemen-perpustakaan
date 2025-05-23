using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Latihan_LKS_IT_Software
{
    public partial class manajemenBuku : Form
    {
        private string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;";

        public manajemenBuku()
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
            daftarBuku.AllowUserToAddRows = false;
            daftarBuku.BorderStyle = BorderStyle.None;
            daftarBuku.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            daftarBuku.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            daftarBuku.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            daftarBuku.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            daftarBuku.BackgroundColor = Color.White;
            daftarBuku.EnableHeadersVisualStyles = false;
            daftarBuku.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            daftarBuku.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            daftarBuku.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            daftarBuku.RowTemplate.Height = 30;
            daftarBuku.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void TampilkanData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM buku";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    daftarBuku.DataSource = dt;
                    daftarBuku.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Header ke tengah
                    daftarBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolom menyesuaikan lebar
                    daftarBuku.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Data rata kiri

                    DesainDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void manajemenBuku_Load(object sender, EventArgs e)
        {
            TampilkanData(); // Menampilkan data saat form dibuka
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Validasi input tidak kosong
            if (string.IsNullOrEmpty(txtKodeBuku.Text) || string.IsNullOrEmpty(txtJudulBuku.Text) ||
                string.IsNullOrEmpty(txtPenulisBuku.Text) || string.IsNullOrEmpty(txtStokBuku.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input numerik
            if (!int.TryParse(txtKodeBuku.Text, out int kodeBuku))
            {
                MessageBox.Show("Kode buku harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStokBuku.Text, out int stokBuku))
            {
                MessageBox.Show("Stok buku harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string judulBuku = txtJudulBuku.Text.Trim();
            string penulisBuku = txtPenulisBuku.Text.Trim();
            DateTime tahunTerbit = dtpTahunTerbitBuku.Value;

            // Simpan ke database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO buku (kode_buku, judul_buku, penulis_buku, tahun_terbit, stok_buku) " +
                                   "VALUES (@kode, @judul, @penulis, @tahun, @stok)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", kodeBuku);
                        cmd.Parameters.AddWithValue("@judul", judulBuku);
                        cmd.Parameters.AddWithValue("@penulis", penulisBuku);
                        cmd.Parameters.AddWithValue("@tahun", tahunTerbit); // Gunakan full datetime
                        cmd.Parameters.AddWithValue("@stok", stokBuku);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TampilkanData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menyimpan data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            // Reset form
            txtKodeBuku.Clear();
            txtJudulBuku.Clear();
            txtPenulisBuku.Clear();
            dtpTahunTerbitBuku.Value = DateTime.Now;
            txtStokBuku.Clear();
        }

        private void daftarBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = daftarBuku.Rows[e.RowIndex];

                txtKodeBuku.Text = row.Cells["kode_buku"].Value.ToString();
                txtJudulBuku.Text = row.Cells["judul_buku"].Value.ToString();
                txtPenulisBuku.Text = row.Cells["penulis_buku"].Value.ToString();

                // Tangani nilai datetime dengan benar
                if (DateTime.TryParse(row.Cells["tahun_terbit"].Value.ToString(), out DateTime tahunTerbit))
                {
                    dtpTahunTerbitBuku.Value = tahunTerbit;
                }
                else
                {
                    dtpTahunTerbitBuku.Value = DateTime.Now;
                }

                txtStokBuku.Text = row.Cells["stok_buku"].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Validasi input tidak kosong
            if (string.IsNullOrEmpty(txtKodeBuku.Text) || string.IsNullOrEmpty(txtJudulBuku.Text) ||
                string.IsNullOrEmpty(txtPenulisBuku.Text) || string.IsNullOrEmpty(txtStokBuku.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input numerik
            if (!int.TryParse(txtKodeBuku.Text, out int kodeBuku))
            {
                MessageBox.Show("Kode buku harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStokBuku.Text, out int stokBuku))
            {
                MessageBox.Show("Stok buku harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string judulBuku = txtJudulBuku.Text.Trim();
            string penulisBuku = txtPenulisBuku.Text.Trim();
            DateTime tahunTerbit = dtpTahunTerbitBuku.Value;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE buku SET judul_buku = @judul, penulis_buku = @penulis, " +
                                   "tahun_terbit = @tahun, stok_buku = @stok WHERE kode_buku = @kode";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", kodeBuku);
                        cmd.Parameters.AddWithValue("@judul", judulBuku);
                        cmd.Parameters.AddWithValue("@penulis", penulisBuku);
                        cmd.Parameters.AddWithValue("@tahun", tahunTerbit); // Gunakan full datetime
                        cmd.Parameters.AddWithValue("@stok", stokBuku);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TampilkanData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            // Reset form
            txtKodeBuku.Clear();
            txtJudulBuku.Clear();
            txtPenulisBuku.Clear();
            dtpTahunTerbitBuku.Value = DateTime.Now;
            txtStokBuku.Clear();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKodeBuku.Text))
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtKodeBuku.Text, out int kodeBuku))
            {
                MessageBox.Show("Kode buku tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus buku ini?",
                                                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM buku WHERE kode_buku = @kode";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@kode", kodeBuku);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TampilkanData();
                            }
                            else
                            {
                                MessageBox.Show("Data tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM buku WHERE " +
                                   "kode_buku LIKE @keyword OR " +
                                   "judul_buku LIKE @keyword OR " +
                                   "penulis_buku LIKE @keyword";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        daftarBuku.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCari.Text = "";
            txtKodeBuku.Text = "";
            txtJudulBuku.Text = "";
            txtPenulisBuku.Text = "";
            dtpTahunTerbitBuku.Value = DateTime.Now;
            txtStokBuku.Text = "";
            TampilkanData();
        }
    }
}
