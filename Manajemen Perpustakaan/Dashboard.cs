using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manajemen_Perpustakaan.Properties;

namespace Latihan_LKS_IT_Software
{
    public partial class Dashboard : Form
    {
        private string keanggotaan;
        private Form activeForm = null;
        public Dashboard(string level)
        {
            InitializeComponent();
            keanggotaan = level;
            this.IsMdiContainer = true;
            SetupMenuStrip();
        }
        private void SetupMenuStrip()
        {
            menuStrip1.Items.Clear();
            MenuStrip menuStrip = new MenuStrip();
            if (keanggotaan == "Admin")
            {
                // Manajemen Buku
                ToolStripMenuItem manajemenBuku = CreateMenu("Manajemen Buku", manajemenBukuToolStripMenuItem_Click);
                manajemenBuku.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_books_501;
                manajemenBuku.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(manajemenBuku);

                // Lihat Daftar Buku (sebelumnya "Cek Ketersediaan Buku")
                ToolStripMenuItem lihatDaftarBuku = CreateMenu("Lihat Daftar Buku", lihatDaftarBukuToolStripMenuItem_Click);
                lihatDaftarBuku.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
                lihatDaftarBuku.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(lihatDaftarBuku);

                // Peminjaman dan pengembalian (perubahan format dari "Peminjaman & Pengembalian")
                ToolStripMenuItem peminjamanPengembalianMenu = new ToolStripMenuItem("Peminjaman dan pengembalian");
                peminjamanPengembalianMenu.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_book_philosophy_50;
                peminjamanPengembalianMenu.ImageScaling = ToolStripItemImageScaling.None;

                ToolStripMenuItem pinjamBukuItem = CreateMenu("Pinjam Buku", peminjamanBukuToolStripMenuItem_Click);
                pinjamBukuItem.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_add_book_48;
                pinjamBukuItem.ImageScaling = ToolStripItemImageScaling.None;

                ToolStripMenuItem kembaliBukuItem = CreateMenu("Kembalikan Buku", pengembalianBukuToolStripMenuItem_Click);
                kembaliBukuItem.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_return_book_50;
                kembaliBukuItem.ImageScaling = ToolStripItemImageScaling.None;

                peminjamanPengembalianMenu.DropDownItems.Add(pinjamBukuItem);
                peminjamanPengembalianMenu.DropDownItems.Add(kembaliBukuItem);
                menuStrip1.Items.Add(peminjamanPengembalianMenu);

                // Pendaftaran Petugas (nama sudah sesuai)
                ToolStripMenuItem pendaftaranPetugas = CreateMenu("Pendaftaran Petugas", pendaftaranPetugasToolStripMenuItem_Click);
                pendaftaranPetugas.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_add_user_male_50;
                pendaftaranPetugas.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(pendaftaranPetugas);

                // Manajemen Anggota (nama sudah sesuai)
                ToolStripMenuItem manajemenAnggota = CreateMenu("Manajemen Anggota", manajemenAnggotaToolStripMenuItem_Click);
                manajemenAnggota.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_student_male_50;
                manajemenAnggota.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(manajemenAnggota);

                // Riwayat (sebelumnya "History")
                ToolStripMenuItem riwayat = CreateMenu("Riwayat", riwayatToolStripMenuItem_Click);
                riwayat.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
                riwayat.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(riwayat);

                // Logout (nama sudah sesuai)
                ToolStripMenuItem logout = CreateMenu("Logout", logoutToolStripMenuItem_Click);
                logout.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_exit_sign_50;
                logout.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(logout);
            }
            else if (keanggotaan == "User")
            {
                // Manajemen Buku
                ToolStripMenuItem manajemenBuku = CreateMenu("Manajemen Buku", manajemenBukuToolStripMenuItem_Click);
                manajemenBuku.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_books_501;
                manajemenBuku.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(manajemenBuku);

                // Lihat Daftar Buku (sebelumnya "Cek Ketersediaan Buku")
                ToolStripMenuItem lihatDaftarBuku = CreateMenu("Lihat Daftar Buku", lihatDaftarBukuToolStripMenuItem_Click);
                lihatDaftarBuku.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
                lihatDaftarBuku.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(lihatDaftarBuku);

                // Peminjaman dan pengembalian (perubahan format dari "Peminjaman & Pengembalian")
                ToolStripMenuItem peminjamanPengembalianMenu = new ToolStripMenuItem("Peminjaman dan pengembalian");
                peminjamanPengembalianMenu.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_book_philosophy_50;
                peminjamanPengembalianMenu.ImageScaling = ToolStripItemImageScaling.None;

                ToolStripMenuItem pinjamBukuItem = CreateMenu("Pinjam Buku", peminjamanBukuToolStripMenuItem_Click);
                pinjamBukuItem.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_add_book_48;
                pinjamBukuItem.ImageScaling = ToolStripItemImageScaling.None;

                ToolStripMenuItem kembaliBukuItem = CreateMenu("Kembalikan Buku", pengembalianBukuToolStripMenuItem_Click);
                kembaliBukuItem.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_return_book_50;
                kembaliBukuItem.ImageScaling = ToolStripItemImageScaling.None;

                peminjamanPengembalianMenu.DropDownItems.Add(pinjamBukuItem);
                peminjamanPengembalianMenu.DropDownItems.Add(kembaliBukuItem);
                menuStrip1.Items.Add(peminjamanPengembalianMenu);

                // Manajemen Anggota (nama sudah sesuai)
                ToolStripMenuItem manajemenAnggota = CreateMenu("Manajemen Anggota", manajemenAnggotaToolStripMenuItem_Click);
                manajemenAnggota.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_student_male_50;
                manajemenAnggota.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(manajemenAnggota);

                // Riwayat (sebelumnya "History")
                ToolStripMenuItem riwayat = CreateMenu("Riwayat", riwayatToolStripMenuItem_Click);
                riwayat.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
                riwayat.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(riwayat);

                // Logout (nama sudah sesuai)
                ToolStripMenuItem logout = CreateMenu("Logout", logoutToolStripMenuItem_Click);
                logout.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_exit_sign_50;
                logout.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(logout);
            }
            else if (keanggotaan == "Siswa")
            {
                // Lihat Daftar Buku (sebelumnya "Cek Ketersediaan Buku")
                ToolStripMenuItem lihatDaftarBuku = CreateMenu("Lihat Daftar Buku", lihatDaftarBukuToolStripMenuItem_Click);
                lihatDaftarBuku.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
                lihatDaftarBuku.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(lihatDaftarBuku);

                // Peminjaman dan pengembalian (perubahan format dari "Peminjaman & Pengembalian")
                ToolStripMenuItem peminjamanPengembalianMenu = new ToolStripMenuItem("Peminjaman dan pengembalian");
                peminjamanPengembalianMenu.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_book_philosophy_50;
                peminjamanPengembalianMenu.ImageScaling = ToolStripItemImageScaling.None;

                ToolStripMenuItem pinjamBukuItem = CreateMenu("Pinjam Buku", peminjamanBukuToolStripMenuItem_Click);
                pinjamBukuItem.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_add_book_48;
                pinjamBukuItem.ImageScaling = ToolStripItemImageScaling.None;

                ToolStripMenuItem kembaliBukuItem = CreateMenu("Kembalikan Buku", pengembalianBukuToolStripMenuItem_Click);
                kembaliBukuItem.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_return_book_50;
                kembaliBukuItem.ImageScaling = ToolStripItemImageScaling.None;

                peminjamanPengembalianMenu.DropDownItems.Add(pinjamBukuItem);
                peminjamanPengembalianMenu.DropDownItems.Add(kembaliBukuItem);
                menuStrip1.Items.Add(peminjamanPengembalianMenu);

                // Menambahkan menu Riwayat untuk konsistensi (tidak ada di kode asli untuk Siswa)
                ToolStripMenuItem riwayat = CreateMenu("Riwayat", riwayatToolStripMenuItem_Click);
                riwayat.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
                riwayat.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(riwayat);

                // Logout (nama sudah sesuai)
                ToolStripMenuItem logout = CreateMenu("Logout", logoutToolStripMenuItem_Click);
                logout.Image = Manajemen_Perpustakaan.Properties.Resources.icons8_exit_sign_50;
                logout.ImageScaling = ToolStripItemImageScaling.None;
                menuStrip1.Items.Add(logout);
            }
        }

        private void OpenForm(Type formType)
        {
            if (activeForm != null)
            {
                MessageBox.Show("Tutup form yang sedang terbuka terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            activeForm = (Form)Activator.CreateInstance(formType);
            activeForm.MdiParent = this;
            activeForm.StartPosition = FormStartPosition.CenterScreen;
            activeForm.FormClosed += (s, args) => { activeForm = null; }; 
            activeForm.Show();
        }

        private ToolStripMenuItem CreateMenu(string text, EventHandler clickHandler, Image image = null)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(text);
            menuItem.Click += clickHandler;

            if (image != null)
            {
                menuItem.Image = image;
            }

            return menuItem;
        }

        private void manajemenBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(manajemenBuku));
        }

        private void pendaftaranPetugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(pendaftaranPetugas));
        }

        private void pengembalianBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(pengembalianBuku));
        }

        private void manajemenAnggotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(manajemenAnggota));
        }

        private void lihatDaftarBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(lihatDaftarBuku));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login formLogin = new Login();
                formLogin.Show();
            }
        }

        private void peminjamanBukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(peminjamanBuku));
        }

        private void riwayatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(riwayatPerpustakaan));
        }
    }
}
