# Internformatic

game development kelompok 3 - Internformatic

Berikut adalah panduan singkat tentang cara menggunakan Git dan Git LFS untuk berkolaborasi dalam proyek Unity di repositori GitHub dengan tautan SSH. Pastikan untuk menyesuaikan sesuai dengan proyek Anda dan informasi spesifik Anda:

pertama instal git di browser dulu gess


# Panduan Kolaborasi Proyek Unity Menggunakan Git dan Git LFS

Ini adalah panduan singkat tentang cara berkolaborasi dalam proyek Unity dengan menggunakan Git dan Git LFS. Pastikan Anda telah menginstal Git dan Git LFS di komputer Anda sebelum memulai.

## Langkah 1: Klona Repositori
1. Buka terminal Anda.

2. Klona repositori dengan perintah berikut:
   ```sh
   git clone git@github.com:vinsmith-MIB/Internformatic.git
   ```

## Langkah 2: Instalasi Git LFS (Jika Diperlukan)
1. Jika proyek ini menggunakan Git LFS, jalankan perintah berikut di direktori proyek untuk menginstal Git LFS:
   ```sh
   git lfs install
   ```

2. Pastikan untuk mengikuti langkah-langkah konfigurasi Git LFS sesuai kebutuhan proyek.

## Langkah 3: Mengambil Pembaruan
1. Sebelum memulai pekerjaan, pastikan untuk selalu mengambil pembaruan terbaru dari repositori dengan perintah:
   ```sh
   git pull
   ```

## Langkah 4: Pekerjaan dan Perubahan
1. Kerjakan perubahan Anda dalam proyek Unity seperti biasa.

2. Gunakan perintah `git add` untuk menambahkan perubahan ke *staging area*:
   ```sh
   git add .
   ```

3. Buat *commit* dari perubahan yang sudah di-*stage*:
   ```sh
   git commit -m "Deskripsi singkat tentang perubahan Anda"
   ```

4. Kirim *commit* Anda ke repositori dengan perintah:
   ```sh
   git push
   ```

## Langkah 5: Penyelesaian Konflik
1. Jika terjadi konflik saat melakukan *push*, Anda perlu menyelesaikan konflik tersebut sebelum bisa melanjutkan. Anda dapat menggunakan Git GUI atau alat bantu pemecah konflik.

2. Setelah konflik terselesaikan, lanjutkan dengan perintah `git add`, `git commit`, dan `git push` seperti biasa.

## Catatan Penting
- Pastikan Anda selalu mengambil pembaruan terbaru sebelum memulai pekerjaan Anda untuk menghindari konflik.

- Pastikan Anda telah mengkonfigurasi identitas Git Anda dengan benar, termasuk alamat email dan nama pengguna.

- Jika Anda belum memiliki izin untuk mengakses repositori ini, minta akses dari pemilik repositori.

- Ikuti pedoman kolaborasi yang telah ditetapkan oleh tim proyek.

Semoga panduan ini membantu Anda berkolaborasi dengan efisien dalam proyek Unity. Selamat berkolaborasi!
```

Panduan ini adalah panduan singkat dan perlu disesuaikan sesuai dengan kebutuhan proyek Anda. Juga, pastikan untuk memberikan akses ke repositori kepada kolaborator Anda jika belum ada akses sebelumnya.
