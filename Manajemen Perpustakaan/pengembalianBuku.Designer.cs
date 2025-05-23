namespace Latihan_LKS_IT_Software
{
    partial class pengembalianBuku
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
            this.dgvPengembalian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKodeBuku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJudulBuku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPeminjam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomorIndukPeminjam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpPengembalian = new System.Windows.Forms.DateTimePicker();
            this.txtDenda = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKembalikan = new System.Windows.Forms.Button();
            this.txtTanggalPinjam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPengembalian
            // 
            this.dgvPengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengembalian.Location = new System.Drawing.Point(13, 13);
            this.dgvPengembalian.Name = "dgvPengembalian";
            this.dgvPengembalian.Size = new System.Drawing.Size(775, 164);
            this.dgvPengembalian.TabIndex = 0;
            this.dgvPengembalian.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPengembalian_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kode buku";
            // 
            // txtKodeBuku
            // 
            this.txtKodeBuku.Location = new System.Drawing.Point(137, 181);
            this.txtKodeBuku.Name = "txtKodeBuku";
            this.txtKodeBuku.ReadOnly = true;
            this.txtKodeBuku.Size = new System.Drawing.Size(239, 20);
            this.txtKodeBuku.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Judul buku";
            // 
            // txtJudulBuku
            // 
            this.txtJudulBuku.Location = new System.Drawing.Point(137, 207);
            this.txtJudulBuku.Name = "txtJudulBuku";
            this.txtJudulBuku.ReadOnly = true;
            this.txtJudulBuku.Size = new System.Drawing.Size(239, 20);
            this.txtJudulBuku.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama peminjam";
            // 
            // txtNamaPeminjam
            // 
            this.txtNamaPeminjam.Location = new System.Drawing.Point(137, 233);
            this.txtNamaPeminjam.Name = "txtNamaPeminjam";
            this.txtNamaPeminjam.ReadOnly = true;
            this.txtNamaPeminjam.Size = new System.Drawing.Size(239, 20);
            this.txtNamaPeminjam.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nomor induk peminjam";
            // 
            // txtNomorIndukPeminjam
            // 
            this.txtNomorIndukPeminjam.Location = new System.Drawing.Point(137, 259);
            this.txtNomorIndukPeminjam.Name = "txtNomorIndukPeminjam";
            this.txtNomorIndukPeminjam.ReadOnly = true;
            this.txtNomorIndukPeminjam.Size = new System.Drawing.Size(239, 20);
            this.txtNomorIndukPeminjam.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tanggal pinjam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tanggal pengembalian";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Denda";
            // 
            // dtpPengembalian
            // 
            this.dtpPengembalian.Location = new System.Drawing.Point(137, 314);
            this.dtpPengembalian.Name = "dtpPengembalian";
            this.dtpPengembalian.Size = new System.Drawing.Size(239, 20);
            this.dtpPengembalian.TabIndex = 13;
            // 
            // txtDenda
            // 
            this.txtDenda.Location = new System.Drawing.Point(137, 340);
            this.txtDenda.Name = "txtDenda";
            this.txtDenda.ReadOnly = true;
            this.txtDenda.Size = new System.Drawing.Size(239, 20);
            this.txtDenda.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(137, 367);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(219, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKembalikan
            // 
            this.btnKembalikan.Location = new System.Drawing.Point(301, 367);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(75, 23);
            this.btnKembalikan.TabIndex = 18;
            this.btnKembalikan.Text = "Kembalikan";
            this.btnKembalikan.UseVisualStyleBackColor = true;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click);
            // 
            // txtTanggalPinjam
            // 
            this.txtTanggalPinjam.Location = new System.Drawing.Point(137, 288);
            this.txtTanggalPinjam.Name = "txtTanggalPinjam";
            this.txtTanggalPinjam.ReadOnly = true;
            this.txtTanggalPinjam.Size = new System.Drawing.Size(239, 20);
            this.txtTanggalPinjam.TabIndex = 19;
            // 
            // pengembalianBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.txtTanggalPinjam);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtDenda);
            this.Controls.Add(this.dtpPengembalian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomorIndukPeminjam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaPeminjam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJudulBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKodeBuku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPengembalian);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pengembalianBuku";
            this.Text = "pengembalianBuku";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengembalian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPengembalian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKodeBuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJudulBuku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPeminjam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomorIndukPeminjam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpPengembalian;
        private System.Windows.Forms.TextBox txtDenda;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKembalikan;
        private System.Windows.Forms.TextBox txtTanggalPinjam;
    }
}