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
    public partial class pengembalianBuku : Form
    {
        private void LoadData()
        {
            try
            {
                string query = @"
                        SELECT 
                        p.kode_buku AS 'Kode Buku', 
                        b.judul_buku AS 'Judul Buku', 
                        u.nama_pengguna AS 'Nama Peminjam', 
                        p.nomor_induk AS 'Nomor Induk', 
                        p.tanggal_pinjam AS 'Tanggal Pinjam', 
                        p.tanggal_kembali AS 'Tanggal Kembali', 
                        p.status_peminjaman AS 'Status Peminjaman'
                        FROM peminjaman p
                        JOIN buku b ON p.kode_buku = b.kode_buku
                        JOIN pengguna u ON p.nomor_induk = u.nomor_induk
                        WHERE p.status_peminjaman = 'Dipinjam';
                        ";

                using (MySqlConnection conn = new MySqlConnection("server=localhost; database=perpustakaan; uid=root; pwd=;"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvPengembalian.DataSource = dt;
                        dgvPengembalian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        // Mengubah header kolom agar lebih rapi
                        dgvPengembalian.Columns["Kode Buku"].HeaderText = "Kode Buku";
                        dgvPengembalian.Columns["Judul Buku"].HeaderText = "Judul Buku";
                        dgvPengembalian.Columns["Nama Peminjam"].HeaderText = "Nama Peminjam";
                        dgvPengembalian.Columns["Nomor Induk"].HeaderText = "Nomor Induk";
                        dgvPengembalian.Columns["Tanggal Pinjam"].HeaderText = "Tanggal Pinjam";
                        dgvPengembalian.Columns["Tanggal Kembali"].HeaderText = "Tanggal Kembali";
                        dgvPengembalian.Columns["Status Peminjaman"].HeaderText = "Status Peminjaman";

                        DesainDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }


        public pengembalianBuku()
        {
            InitializeComponent();
            LoadData();
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
            dgvPengembalian.AllowUserToAddRows = false;
            dgvPengembalian.BorderStyle = BorderStyle.None;
            dgvPengembalian.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvPengembalian.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPengembalian.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvPengembalian.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvPengembalian.BackgroundColor = Color.White;
            dgvPengembalian.EnableHeadersVisualStyles = false;
            dgvPengembalian.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPengembalian.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvPengembalian.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPengembalian.RowTemplate.Height = 30;
            dgvPengembalian.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    
                    string kodeBuku = txtKodeBuku.Text;
                    string nomorInduk = txtNomorIndukPeminjam.Text;
                    DateTime tanggalPengembalian = dtpPengembalian.Value; 
                    DateTime tanggalPinjam = Convert.ToDateTime(txtTanggalPinjam.Text);

                    int selisihHari = (tanggalPengembalian - tanggalPinjam).Days;
                    int denda = selisihHari > 7 ? (selisihHari - 7) * 2500 : 0; 

                    string updateQuery = "UPDATE peminjaman SET status_peminjaman = 'Dikembalikan' WHERE kode_buku = @kodeBuku AND nomor_induk = @nomorInduk";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@kodeBuku", kodeBuku);
                        cmd.Parameters.AddWithValue("@nomorInduk", nomorInduk);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Buku berhasil dikembalikan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtDenda.Text = denda > 0 ? "Rp " + denda.ToString("N0") : "Tidak ada denda";
                        }
                        else
                        {
                            MessageBox.Show("Buku tidak ditemukan atau sudah dikembalikan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPengembalian_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPengembalian.Rows[e.RowIndex];

                txtKodeBuku.Text = row.Cells["Kode Buku"].Value != null ? row.Cells["Kode Buku"].Value.ToString() : "";
                txtJudulBuku.Text = row.Cells["Judul Buku"].Value != null ? row.Cells["Judul Buku"].Value.ToString() : "";
                txtNamaPeminjam.Text = row.Cells["Nama Peminjam"].Value != null ? row.Cells["Nama Peminjam"].Value.ToString() : "";
                txtNomorIndukPeminjam.Text = row.Cells["Nomor Induk"].Value != null ? row.Cells["Nomor Induk"].Value.ToString() : "";
                txtTanggalPinjam.Text = row.Cells["Tanggal Pinjam"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["Tanggal Pinjam"].Value).ToString("yyyy-MM-dd")
                    : "";
                dtpPengembalian.Value = row.Cells["Tanggal Kembali"].Value != DBNull.Value
                    ? Convert.ToDateTime(row.Cells["Tanggal Kembali"].Value)
                    : DateTime.Now;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            txtKodeBuku.Clear();
            txtJudulBuku.Clear();
            txtNamaPeminjam.Clear();
            txtNomorIndukPeminjam.Clear();
            txtTanggalPinjam.Clear();
            dtpPengembalian.Value = DateTime.Now;
            txtDenda.Clear();
        }
    }
}
