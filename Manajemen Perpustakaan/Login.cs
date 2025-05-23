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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKeanggotaan.Items.Add("Admin");
            cmbKeanggotaan.Items.Add("User");
            cmbKeanggotaan.Items.Add("Siswa");
            txtPassword.UseSystemPasswordChar = true;
        }
            
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomor_induk = txtNomorInduk.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string keanggotaan = cmbKeanggotaan.SelectedItem?.ToString();

            string connectionString = "Server=localhost;Database=perpustakaan;User ID=root;Password=;SslMode=none;";
            string query = "SELECT * FROM pengguna WHERE nomor_induk = @nomor_induk AND nama_pengguna = @username AND kata_sandi = @password AND keanggotaan = @keanggotaan";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nomor_induk", nomor_induk);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@keanggotaan", keanggotaan);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Login berhasil!");
                            keanggotaan = reader["keanggotaan"].ToString();
                            Dashboard fromDashboard = new Dashboard(keanggotaan);
                            fromDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login gagal! Periksa kembali data Anda.");
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNomorInduk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harap masukkan hanya angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
