using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Latihan_LKS_IT_Software
{
    public partial class manajemenAnggota : Form
    {
        public manajemenAnggota()
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void LoadDataPengguna()
        {
            string query = "SELECT nomor_induk, nama_pengguna, nomor_telepon, email, kata_sandi, keanggotaan FROM pengguna";
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=perpustakaan; uid=root; pwd=;"))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    dataGridView1.Columns["nomor_induk"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView1.Columns["nomor_telepon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView1.Columns["keanggotaan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView1.Columns["nama_pengguna"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dataGridView1.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    dataGridView1.Columns["kata_sandi"].Visible = false;

                    DesainDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mengambil data: " + ex.Message);
                }
            }
        }

        private void KosongkanInput()
        {
            LoadDataPengguna();
            txtNomorInduk.Clear();
            txtNamaPengguna.Clear();
            txtNomorTelepon.Clear();
            txtEmail.Clear();
            txtKataSandi.Clear();
            cmbKeanggotaan.SelectedIndex = -1;
            txtCari.Clear();
        }

        private void manajemenAnggota_Load(object sender, EventArgs e)
        {
            LoadDataPengguna();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNomorInduk.Text = row.Cells["nomor_induk"].Value.ToString();
                txtNamaPengguna.Text = row.Cells["nama_pengguna"].Value.ToString();
                txtNomorTelepon.Text = row.Cells["nomor_telepon"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtKataSandi.Text = row.Cells["kata_sandi"].Value.ToString();
                cmbKeanggotaan.Text = row.Cells["keanggotaan"].Value.ToString();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomorInduk.Text == "" || txtNamaPengguna.Text == "" || txtNomorTelepon.Text == "" || txtEmail.Text == "" || txtKataSandi.Text == "" || cmbKeanggotaan.Text == "")
                {
                    MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "UPDATE pengguna SET nama_pengguna = @nama, nomor_telepon = @telepon, email = @email, " +
                               "kata_sandi = @sandi, keanggotaan = @keanggotaan WHERE nomor_induk = @nomor";

                using (MySqlConnection conn = new MySqlConnection("server=localhost; database=perpustakaan; uid=root; pwd=;"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomor", txtNomorInduk.Text);
                        cmd.Parameters.AddWithValue("@nama", txtNamaPengguna.Text);
                        cmd.Parameters.AddWithValue("@telepon", txtNomorTelepon.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@sandi", txtKataSandi.Text);
                        cmd.Parameters.AddWithValue("@keanggotaan", cmbKeanggotaan.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPengguna();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diperbarui!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            string nomorInduk = txtNomorInduk.Text;

            if (string.IsNullOrEmpty(nomorInduk))
            {
                MessageBox.Show("Pilih anggota yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cekQuery = "SELECT COUNT(*) FROM peminjaman WHERE nomor_induk = @nomorInduk";
            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=perpustakaan; uid=root; pwd=;"))
            {
                conn.Open();
                using (MySqlCommand cmdCek = new MySqlCommand(cekQuery, conn))
                {
                    cmdCek.Parameters.AddWithValue("@nomorInduk", nomorInduk);
                    int jumlahPeminjaman = Convert.ToInt32(cmdCek.ExecuteScalar());

                    if (jumlahPeminjaman > 0)
                    {
                        MessageBox.Show("Anggota ini masih memiliki peminjaman, tidak bisa dihapus!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string deleteQuery = "DELETE FROM pengguna WHERE nomor_induk = @nomorInduk";
                using (MySqlCommand cmdDelete = new MySqlCommand(deleteQuery, conn))
                {
                    cmdDelete.Parameters.AddWithValue("@nomorInduk", nomorInduk);
                    int result = cmdDelete.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Anggota berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataPengguna();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus anggota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefrsh_Click(object sender, EventArgs e)
        {
            KosongkanInput();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string cari = txtCari.Text;
            if (string.IsNullOrEmpty(cari))
            {
                LoadDataPengguna();
                return;
            }

            string searchQuery = "SELECT nomor_induk, nama_pengguna, nomor_telepon, email, kata_sandi, keanggotaan " +
                                 "FROM pengguna WHERE nomor_induk LIKE @cari OR nama_pengguna LIKE @cari OR " +
                                 "nomor_telepon LIKE @cari OR email LIKE @cari";

            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=perpustakaan; uid=root; pwd=;"))
            {
                conn.Open();
                using (MySqlCommand cmdSearch = new MySqlCommand(searchQuery, conn))
                {
                    cmdSearch.Parameters.AddWithValue("@cari", "%" + cari + "%");

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmdSearch))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
