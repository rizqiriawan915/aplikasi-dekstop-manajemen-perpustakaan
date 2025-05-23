create database perpustakaan;
use perpustakaan;

create table pengguna(
nomor_induk int not null primary key,
nama_pengguna varchar(100) not null,
nomor_telepon varchar(100) not null,
email varchar(100) not null,
kata_sandi varchar(100) not null,
keanggotaan varchar(100) not null
);

create table buku(
kode_buku int not null primary key,
judul_buku varchar(100) not null,
penulis_buku varchar(100) not null,
tahun_terbit datetime not null,
stok_buku int not null
);

CREATE TABLE peminjaman (
    id_peminjaman INT AUTO_INCREMENT PRIMARY KEY,
    nomor_induk INT NOT NULL,         
    kode_buku INT NOT NULL,            
    tanggal_pinjam DATE NOT NULL,      
    tanggal_kembali DATE NOT NULL,     
    status_peminjaman ENUM('Dipinjam', 'Dikembalikan') DEFAULT 'Dipinjam',
    
    FOREIGN KEY (nomor_induk) REFERENCES pengguna(nomor_induk) ON DELETE CASCADE,
    FOREIGN KEY (kode_buku) REFERENCES buku(kode_buku) ON DELETE CASCADE
);

-- Codingan sql server nya

-- Membuat database
-- CREATE DATABASE perpustakaan;
-- GO

-- Menggunakan database
-- USE perpustakaan;
-- GO

-- Tabel pengguna
-- CREATE TABLE pengguna (
--     nomor_induk INT NOT NULL PRIMARY KEY,
--     nama_pengguna VARCHAR(100) NOT NULL,
--     nomor_telepon VARCHAR(100) NOT NULL,
--     email VARCHAR(100) NOT NULL,
--     kata_sandi VARCHAR(100) NOT NULL,
--     keanggotaan VARCHAR(100) NOT NULL
-- );
-- GO

-- Tabel buku
-- CREATE TABLE buku (
--     kode_buku INT NOT NULL PRIMARY KEY,
--     judul_buku VARCHAR(100) NOT NULL,
--     penulis_buku VARCHAR(100) NOT NULL,
--     tahun_terbit DATE NOT NULL,
--     stok_buku INT NOT NULL
-- );
-- GO

-- Tabel peminjaman
-- CREATE TABLE peminjaman (
--     id_peminjaman INT IDENTITY(1,1) PRIMARY KEY,
--     nomor_induk INT NOT NULL,
--     kode_buku INT NOT NULL,
--     tanggal_pinjam DATE NOT NULL,
--     tanggal_kembali DATE NOT NULL,
--     status_peminjaman VARCHAR(20) NOT NULL DEFAULT 'Dipinjam',
--     
--     FOREIGN KEY (nomor_induk) REFERENCES pengguna(nomor_induk) ON DELETE CASCADE,
--     FOREIGN KEY (kode_buku) REFERENCES buku(kode_buku) ON DELETE CASCADE
-- );
-- GO
 