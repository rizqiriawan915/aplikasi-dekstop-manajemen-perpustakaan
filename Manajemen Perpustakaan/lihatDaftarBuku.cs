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
    public partial class lihatDaftarBuku : Form
    {
        private string connectionString = "server=localhost;database=perpustakaan;uid=root;pwd=;";
        public lihatDaftarBuku()
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

        private void lihatDaftarBuku_Load(object sender, EventArgs e)
        {
            TampilkanData(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            TampilkanData();
        }
    }
}
