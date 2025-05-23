# 📚 Aplikasi Manajemen Perpustakaan

## 📖 Deskripsi  
Aplikasi ini dibuat untuk memudahkan proses administrasi **peminjaman buku** di perpustakaan sekolah.  
Sistem informasi ini memiliki tiga level user, yaitu **Admin**, **User (Petugas)**, dan **Siswa**, dengan fitur dan hak akses yang berbeda sesuai perannya.

---

## 👥 Level User dan Fitur

### 🛠️ Admin  
- 📚 Manajemen semua buku (tambah, edit, hapus)  
- 👩‍💼 Pendaftaran petugas yang dapat mengakses sistem  
- 📦 Melayani proses peminjaman dan pengembalian buku  
- 🔐 Memberikan hak akses untuk setiap petugas  
- 🧑‍🤝‍🧑 Manajemen anggota perpustakaan  
- 📊 Manajemen laporan

### 🧑‍💻 User (Petugas)  
- 📚 Manajemen semua buku  
- 📦 Melayani proses peminjaman dan pengembalian buku  
- 🧑‍🤝‍🧑 Manajemen anggota perpustakaan  
- 📊 Manajemen laporan

### 🎓 Siswa  
- 🔍 Mencari ketersediaan buku  
- 📖 Meminjam dan mengembalikan buku

---

## 💸 Sistem Denda Pengembalian Terlambat  
Jika buku dikembalikan melewati batas waktu, anggota dikenakan denda:  

> **DENDA = Rp 2.250 x Total Hari Terlambat per Buku**

---

## 🚀 Cara Penggunaan  

1. **Instalasi**  
   - Pastikan sudah menginstall .NET Framework (jika aplikasi C# desktop) atau runtime yang dibutuhkan.  
   - Clone repository ini ke komputer kamu:  
     ```bash
     git clone https://github.com/rizqiriawan915/aplikasi-dekstop-manajemen-perpustakaan.git
     ```  
   - Buka folder proyek di Visual Studio atau IDE favorit kamu.

2. **Menjalankan Aplikasi**  
   - Build dan jalankan aplikasi dari IDE (contoh: tekan tombol Run di Visual Studio).  
   - Masuk ke aplikasi dengan menggunakan akun yang sudah didaftarkan (admin atau user).

3. **Fitur Utama**  
   - Admin dan user dapat mengelola data buku, anggota, dan transaksi peminjaman.  
   - Siswa bisa mencari buku, meminjam, dan mengembalikan buku melalui aplikasi.  
   - Sistem akan menghitung denda otomatis jika buku dikembalikan terlambat.

4. **Backup dan Restore Database**  
   - Database MySQL digunakan untuk menyimpan data aplikasi.  
   - Untuk backup, export database ke file `.sql` dan simpan.  
   - Untuk restore, import file `.sql` ke MySQL server.
