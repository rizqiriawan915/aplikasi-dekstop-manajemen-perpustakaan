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
    public partial class pendaftaranPetugas : Form
    {
        public pendaftaranPetugas()
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string nomorIndukStr = txtNomorInduk.Text.Trim();
            string namaPengguna = txtNamaPengguna.Text.Trim();
            string nomorTeleponStr = txtNomorTelepon.Text.Trim();
            string email = txtEmail.Text.Trim();
            string kataSandi = txtKataSandi.Text.Trim();
            string jabatan = cmbJabatan.Text.Trim();

            int nomorInduk;
            if (!int.TryParse(nomorIndukStr, out nomorInduk))
            {
                MessageBox.Show("Nomor Induk harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(nomorTeleponStr, out long nomorTelepon))
            {
                MessageBox.Show("Nomor Telepon harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(namaPengguna) || string.IsNullOrEmpty(kataSandi) ||
                string.IsNullOrEmpty(jabatan) || string.IsNullOrEmpty(nomorTeleponStr) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;database=perpustakaan;user=root;password=";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO pengguna (nomor_induk, nama_pengguna, nomor_telepon, email, kata_sandi, keanggotaan) " +
                                   "VALUES (@nomorInduk, @namaPengguna, @nomorTelepon, @email, @kataSandi, @jabatan)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomorInduk", nomorInduk);
                        cmd.Parameters.AddWithValue("@namaPengguna", namaPengguna);
                        cmd.Parameters.AddWithValue("@nomorTelepon", nomorTelepon);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@kataSandi", kataSandi);
                        cmd.Parameters.AddWithValue("@jabatan", jabatan);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtNomorInduk.Clear();
                        txtNamaPengguna.Clear();
                        txtNomorTelepon.Clear();
                        txtEmail.Clear();
                        txtKataSandi.Clear();
                        cmbJabatan.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pendaftaranPetugas_Load(object sender, EventArgs e)
        {
            cmbJabatan.Items.Add("Admin");
            cmbJabatan.Items.Add("User");
            cmbJabatan.Items.Add("Siswa");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
