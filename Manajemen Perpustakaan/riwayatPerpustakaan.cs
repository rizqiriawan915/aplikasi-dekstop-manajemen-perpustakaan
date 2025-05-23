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
    public partial class riwayatPerpustakaan : Form
    {
        private MySqlConnection koneksi = new MySqlConnection("server=localhost; database=perpustakaan; uid=root; pwd=;");
        public riwayatPerpustakaan()
        {
            InitializeComponent();
            TampilkanDataPengembalian();
        }

        private void TampilkanDataPengembalian()
        {
            try
            {
                koneksi.Open();
                string query = @"SELECT p.id_peminjaman, p.nomor_induk, u.nama_pengguna AS nama_peminjam, 
                                p.kode_buku, p.tanggal_pinjam, p.tanggal_kembali, p.status_peminjaman
                             FROM peminjaman p
                             JOIN pengguna u ON p.nomor_induk = u.nomor_induk
                             WHERE p.status_peminjaman = 'Dikembalikan'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
            finally
            {
                koneksi.Close(); 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtIdPeminjam.Text = row.Cells["id_peminjaman"].Value.ToString();
                txtNomorInduk.Text = row.Cells["nomor_induk"].Value.ToString();
                txtNama.Text = row.Cells["nama_peminjam"].Value.ToString();
                txtKodeBuku.Text = row.Cells["kode_buku"].Value.ToString();
                dtpPinjam.Value = Convert.ToDateTime(row.Cells["tanggal_pinjam"].Value);
                dtpPengembalian.Value = Convert.ToDateTime(row.Cells["tanggal_kembali"].Value);
                txtPengembalian.Text = row.Cells["status_peminjaman"].Value.ToString();
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtIdPeminjam.Text == "")
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM peminjaman WHERE id_peminjaman = @id_peminjaman";

                    using (MySqlConnection conn = new MySqlConnection("server=localhost;database=perpustakaan;uid=root;pwd=;"))
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_peminjaman", txtIdPeminjam.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TampilkanDataPengembalian(); 
                                dataGridView1.Refresh();
                                txtIdPeminjam.Clear();
                                txtNomorInduk.Clear();
                                txtNama.Clear();
                                txtKodeBuku.Clear();
                                dtpPinjam.Value = DateTime.Now;
                                dtpPengembalian.Value = DateTime.Now;
                                txtPengembalian.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                TampilkanDataPengembalian(); 
                dataGridView1.Refresh();

                txtIdPeminjam.Clear();
                txtNomorInduk.Clear();
                txtKodeBuku.Clear();
                dtpPinjam.Value = DateTime.Now;
                dtpPengembalian.Value = DateTime.Now;
                txtPengembalian.Clear();

                MessageBox.Show("Data telah diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menyegarkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCariData_TextChanged(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                string keyword = txtCariData.Text.Trim();

                string query = @"SELECT p.id_peminjaman, p.nomor_induk, u.nama_pengguna AS nama_peminjam, 
                                p.kode_buku, p.tanggal_pinjam, p.tanggal_kembali, p.status_peminjaman
                         FROM peminjaman p
                         JOIN pengguna u ON p.nomor_induk = u.nomor_induk
                         WHERE p.status_peminjaman = 'Dikembalikan' 
                         AND (p.nomor_induk LIKE @keyword 
                         OR u.nama_pengguna LIKE @keyword 
                         OR p.kode_buku LIKE @keyword)";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi);
                adapter.SelectCommand.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
