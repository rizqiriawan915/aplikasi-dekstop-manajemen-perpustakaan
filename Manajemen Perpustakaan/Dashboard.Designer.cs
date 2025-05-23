namespace Latihan_LKS_IT_Software
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manajemenBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatDaftarBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanDanPengembalianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengembalianBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendaftaranPetugasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manajemenAnggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manajemenBukuToolStripMenuItem,
            this.lihatDaftarBukuToolStripMenuItem,
            this.peminjamanDanPengembalianToolStripMenuItem,
            this.pendaftaranPetugasToolStripMenuItem,
            this.manajemenAnggotaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.riwayatToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manajemenBukuToolStripMenuItem
            // 
            this.manajemenBukuToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_books_501;
            this.manajemenBukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manajemenBukuToolStripMenuItem.Name = "manajemenBukuToolStripMenuItem";
            this.manajemenBukuToolStripMenuItem.Size = new System.Drawing.Size(162, 54);
            this.manajemenBukuToolStripMenuItem.Text = "Manajemen Buku";
            this.manajemenBukuToolStripMenuItem.Click += new System.EventHandler(this.manajemenBukuToolStripMenuItem_Click);
            // 
            // lihatDaftarBukuToolStripMenuItem
            // 
            this.lihatDaftarBukuToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.lihatDaftarBukuToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_view_501;
            this.lihatDaftarBukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lihatDaftarBukuToolStripMenuItem.Name = "lihatDaftarBukuToolStripMenuItem";
            this.lihatDaftarBukuToolStripMenuItem.Size = new System.Drawing.Size(160, 54);
            this.lihatDaftarBukuToolStripMenuItem.Text = "Lihat Daftar Buku";
            this.lihatDaftarBukuToolStripMenuItem.Click += new System.EventHandler(this.lihatDaftarBukuToolStripMenuItem_Click);
            // 
            // peminjamanDanPengembalianToolStripMenuItem
            // 
            this.peminjamanDanPengembalianToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanBukuToolStripMenuItem,
            this.pengembalianBukuToolStripMenuItem});
            this.peminjamanDanPengembalianToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_book_philosophy_50;
            this.peminjamanDanPengembalianToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peminjamanDanPengembalianToolStripMenuItem.Name = "peminjamanDanPengembalianToolStripMenuItem";
            this.peminjamanDanPengembalianToolStripMenuItem.Size = new System.Drawing.Size(238, 54);
            this.peminjamanDanPengembalianToolStripMenuItem.Text = "Peminjaman dan pengembalian";
            // 
            // peminjamanBukuToolStripMenuItem
            // 
            this.peminjamanBukuToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_add_book_481;
            this.peminjamanBukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peminjamanBukuToolStripMenuItem.Name = "peminjamanBukuToolStripMenuItem";
            this.peminjamanBukuToolStripMenuItem.Size = new System.Drawing.Size(214, 56);
            this.peminjamanBukuToolStripMenuItem.Text = "Peminjaman Buku";
            this.peminjamanBukuToolStripMenuItem.Click += new System.EventHandler(this.peminjamanBukuToolStripMenuItem_Click);
            // 
            // pengembalianBukuToolStripMenuItem
            // 
            this.pengembalianBukuToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_return_book_50;
            this.pengembalianBukuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pengembalianBukuToolStripMenuItem.Name = "pengembalianBukuToolStripMenuItem";
            this.pengembalianBukuToolStripMenuItem.Size = new System.Drawing.Size(214, 56);
            this.pengembalianBukuToolStripMenuItem.Text = "Pengembalian Buku";
            this.pengembalianBukuToolStripMenuItem.Click += new System.EventHandler(this.pengembalianBukuToolStripMenuItem_Click);
            // 
            // pendaftaranPetugasToolStripMenuItem
            // 
            this.pendaftaranPetugasToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_add_user_male_50;
            this.pendaftaranPetugasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pendaftaranPetugasToolStripMenuItem.Name = "pendaftaranPetugasToolStripMenuItem";
            this.pendaftaranPetugasToolStripMenuItem.Size = new System.Drawing.Size(178, 54);
            this.pendaftaranPetugasToolStripMenuItem.Text = "Pendaftaran Petugas";
            this.pendaftaranPetugasToolStripMenuItem.Click += new System.EventHandler(this.pendaftaranPetugasToolStripMenuItem_Click);
            // 
            // manajemenAnggotaToolStripMenuItem
            // 
            this.manajemenAnggotaToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_student_male_50;
            this.manajemenAnggotaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manajemenAnggotaToolStripMenuItem.Name = "manajemenAnggotaToolStripMenuItem";
            this.manajemenAnggotaToolStripMenuItem.Size = new System.Drawing.Size(181, 54);
            this.manajemenAnggotaToolStripMenuItem.Text = "Manajemen Anggota";
            this.manajemenAnggotaToolStripMenuItem.Click += new System.EventHandler(this.manajemenAnggotaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 54);
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_view_50;
            this.riwayatToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
            this.riwayatToolStripMenuItem.Text = "Riwayat";
            this.riwayatToolStripMenuItem.Click += new System.EventHandler(this.riwayatToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::Manajemen_Perpustakaan.Properties.Resources.icons8_exit_sign_50;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(107, 54);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Manajemen_Perpustakaan.Properties.Resources.books_library_shelves_138556_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 558);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manajemenBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendaftaranPetugasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanDanPengembalianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manajemenAnggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem peminjamanBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengembalianBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatDaftarBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
    }
}