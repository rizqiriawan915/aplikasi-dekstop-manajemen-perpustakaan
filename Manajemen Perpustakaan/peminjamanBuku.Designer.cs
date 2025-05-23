namespace Latihan_LKS_IT_Software
{
    partial class peminjamanBuku
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
            this.dgvBuku = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpPengembalian = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpPinjam = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPenulisBuku = new System.Windows.Forms.TextBox();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
            this.txtKodeBuku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnKirim = new System.Windows.Forms.Button();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.txtNomorTelepon = new System.Windows.Forms.TextBox();
            this.txtRuangan = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNomorInduk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuku
            // 
            this.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuku.Location = new System.Drawing.Point(13, 13);
            this.dgvBuku.Name = "dgvBuku";
            this.dgvBuku.Size = new System.Drawing.Size(775, 173);
            this.dgvBuku.TabIndex = 0;
            this.dgvBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuku_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpPengembalian);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpPinjam);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPenulisBuku);
            this.groupBox1.Controls.Add(this.txtJudulBuku);
            this.groupBox1.Controls.Add(this.txtKodeBuku);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Biodata buku";
            // 
            // dtpPengembalian
            // 
            this.dtpPengembalian.Location = new System.Drawing.Point(131, 153);
            this.dtpPengembalian.Name = "dtpPengembalian";
            this.dtpPengembalian.Size = new System.Drawing.Size(232, 20);
            this.dtpPengembalian.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Tanggal pengembalian";
            // 
            // dtpPinjam
            // 
            this.dtpPinjam.Location = new System.Drawing.Point(131, 122);
            this.dtpPinjam.Name = "dtpPinjam";
            this.dtpPinjam.Size = new System.Drawing.Size(232, 20);
            this.dtpPinjam.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Tanggal pinjam";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(131, 179);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(131, 12);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(232, 20);
            this.txtCari.TabIndex = 7;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cari buku";
            // 
            // txtPenulisBuku
            // 
            this.txtPenulisBuku.Location = new System.Drawing.Point(131, 95);
            this.txtPenulisBuku.Name = "txtPenulisBuku";
            this.txtPenulisBuku.ReadOnly = true;
            this.txtPenulisBuku.Size = new System.Drawing.Size(232, 20);
            this.txtPenulisBuku.TabIndex = 5;
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.Location = new System.Drawing.Point(131, 68);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.ReadOnly = true;
            this.txtJudulBuku.Size = new System.Drawing.Size(232, 20);
            this.txtJudulBuku.TabIndex = 4;
            // 
            // txtKodeBuku
            // 
            this.txtKodeBuku.Location = new System.Drawing.Point(131, 41);
            this.txtKodeBuku.Name = "txtKodeBuku";
            this.txtKodeBuku.ReadOnly = true;
            this.txtKodeBuku.Size = new System.Drawing.Size(232, 20);
            this.txtKodeBuku.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Penulis buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode buku";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh2);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnKirim);
            this.groupBox2.Controls.Add(this.cmbJabatan);
            this.groupBox2.Controls.Add(this.txtNomorTelepon);
            this.groupBox2.Controls.Add(this.txtRuangan);
            this.groupBox2.Controls.Add(this.txtNama);
            this.groupBox2.Controls.Add(this.txtNomorInduk);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(389, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biodata peminjam";
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(333, 150);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh2.TabIndex = 12;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(169, 151);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 10;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(169, 123);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(224, 21);
            this.cmbJabatan.TabIndex = 9;
            // 
            // txtNomorTelepon
            // 
            this.txtNomorTelepon.Location = new System.Drawing.Point(169, 94);
            this.txtNomorTelepon.Name = "txtNomorTelepon";
            this.txtNomorTelepon.Size = new System.Drawing.Size(224, 20);
            this.txtNomorTelepon.TabIndex = 8;
            // 
            // txtRuangan
            // 
            this.txtRuangan.Location = new System.Drawing.Point(169, 67);
            this.txtRuangan.Name = "txtRuangan";
            this.txtRuangan.Size = new System.Drawing.Size(224, 20);
            this.txtRuangan.TabIndex = 7;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(169, 40);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(224, 20);
            this.txtNama.TabIndex = 6;
            // 
            // txtNomorInduk
            // 
            this.txtNomorInduk.Location = new System.Drawing.Point(169, 12);
            this.txtNomorInduk.Name = "txtNomorInduk";
            this.txtNomorInduk.Size = new System.Drawing.Size(224, 20);
            this.txtNomorInduk.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Masukkan jabatan anda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Masukkan nomor telepon anda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Masukkan ruangan anda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Masukkan nama anda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Masukkan kode induk";
            // 
            // peminjamanBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBuku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "peminjamanBuku";
            this.Text = "peminjamanBuku";
            this.Load += new System.EventHandler(this.peminjamanBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuku)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuku;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPenulisBuku;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.TextBox txtKodeBuku;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.TextBox txtNomorTelepon;
        private System.Windows.Forms.TextBox txtRuangan;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNomorInduk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPinjam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPengembalian;
        private System.Windows.Forms.Label label11;
    }
}