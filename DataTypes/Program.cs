/*
Apa definisi atau arti dari basis data (database)? Basis data adalah kumpulan data yang disimpan secara sistematis di dalam 
komputer yang dapat diolah atau dimanipulasi menggunakan perangkat lunak (program aplikasi) untuk menghasilkan informasi. 
Pendefinisian basis data meliputi spesifikasi berupa tipe data, struktur data dan juga batasan-batasan pada data yang kemudian 
disimpan.
Basis data merupakan aspek yang sangat penting dalam sistem informasi karena berfungsi sebagai gudang penyimpanan data yang 
akan diolah lebih lanjut. Basis data menjadi penting karena dapat mengorganisasi data, menghidari duplikasi data, menghindari 
hubungan antar data yang tidak jelas dan juga update yang rumit.
Proses memasukkan dan mengambil data ke dan dari media penyimpanan data memerlukan perangkat lunak yang disebut dengan sistem 
manajemen basis data (database management system | DBMS). DBMS merupakan sistem perangkat lunak yang memungkinkan pengguna 
basis data (database user) untuk memelihara, mengontrol dan mengakses data secara praktis dan efisien.
Dengan kata lain, semua akses ke basis data akan ditangani oleh DBMS. DBMS ini menjadi lapisan yang menghubungkan basis data 
dengan program aplikasi untuk memastikan bahwa basis data tetap terorganisasi secara konsisten dan dapat diakses dengan mudah.
Ada beberapa fungsi yang harus ditangani DBMS seperti pendefinisian data, menangani permintaan pengguna untuk mengakses data, 
memeriksa sekuriti dan integriti data yang didefinisikan oleh DBA (Database Administrator), menangani kegagalan dalam pengaksesan 
data yang disebabkan oleh kerusakan sistem maupun media penyimpanan (disk) dan juga menangani unjuk kerja semua fungsi secara 
efisien.
Tujuan utama DBMS adalah untuk memberikan tinjauan abstrak data kepada pengguna. Jadi sistem menyembunyikan informasi tentang
bagaimana data disimpan, dipelihara dan juga bisa diakses secara efisien. Pertimbangan efisien di sini adalah rancangan struktur 
data yang kompleks tetapi masih bisa digunakan oleh pengguna awam tanpa mengetahui kompleksitas strukturnya.
2. Pembagian basis data.
Menurut jenisnya, basis data dapat dibagi menjadi:
a. Basis data flat-file.
Basis data ini ideal untuk data berukuran kecil dan dapat dirubah dengan mudah. Pada dasarnya, basis data flat-file tersusun dari 
sekumpulan string dalam satu atau lebih file yang dapat diurai untuk mendapatkan informasi yang disimpan. Basis data flat-file 
cocok untuk menyimpan daftar atau data yang sederhana dan dalam jumlah kecil. Basis data flat-file akan menjadi sangat rumit 
apabila digunakan untuk menyimpan data dengan struktur kompleks walaupun dimungkinkan pula untuk itu.
Beberapa kendala dalam menggunakan basis data jenis ini adalah rentan pada korupsi data karena tidak adanya penguncian yang 
melekat ketika data digunakan atau dimodifikasi dan juga adanya duplikasi data yang mungkin sulit dihindari. 
Salah satu tipe basis data flat-file adalah file CSV yang menggunakan pemisah koma untuk setiap nilainya.
b. Basis data relasional.
Basis data ini mempunyai struktur yang lebih logis terkait cara penyimpanan. Kata "relasiona" berasal dari kenyataan bahwa 
tabel-tabel yang ada di basis data relasional dihubungkan satu dengan lainnya. Basis data relasional menggunakan sekumpulan tabel 
dua dimensi yang masing-masing tabel tersusun atas baris (tupel) dan kolom (atribut).
Untuk membuat hubungan antara dua atau lebih tabel, digunakan key (atribut kunci) yaitu primary key di salah satu tabel dan 
foreign key di tabel yang lain. Saat ini, basis data relasional menjadi pilihan utama karena keunggulannya. 
Program aplikasi untuk mengakses basis data relasional menjadi lebih mudah dibuat dan dikembangkan dibandingkan dengan 
penggunaan basis data flat-file.
Beberapa kekurangan yang mungkin dirasakan di basis data jenis ini adalah implementasi yang lebih sulit untuk data dalam 
jumlah besar dengan tingkat kompleksitasnya yang tinggi. Selain itu, proses pencarian informasi juga menjadi lebih lambat 
karena perlu menghubungkan tabel-tabel terlebih dahulu apabila datanya tersebar di beberapa tabel.
Namun, terlepas dari beberapa kekurangannya, basis data relasional telah digunakan secara luas. Saat ini, basis data relasional 
telah banyak dimanfaatkan oleh perusahaan-perusahaan dari skala kecil, menengah hingga besar. Beberapa basis data ternama yang 
ada saat ini, baik yang berasal dari sumber terbuka (open source) atau yang komersil, adalah juga basis data relasional.

Tujuan Basis Data
Adapun tujuan basis data diantaranya:

Kecepatan serta kemudahan dalam menyimpan, memanipulasi atau juga menampilkan kembali data tersebut.
Efisiensinya ruang penyimpanan, karena dengan basis data, redudansi data akan bisa dihindari.
Keakuratan (Accuracy) data.
Ketersediaan (Availability) data.
Kelengkapan (Completeness) data, Bisa melakukan perubahan struktur dalam basis data, 
    baik dalam penambahan objek baru (tabel) atau dengan penambahan field-field baru pada table.
Keamanan (Security) data, dapat menentukan pemakai yang boleh menggunakan basis data beserta objek-objek 
    yang ada didalamnya serta menentukan jenis -jenis operasi apa saja yang boleh dilakukannya.
Kebersamaan Pemakai (Sharability), Pemakai basis data bisa lebih dari satu orang, tetapi tetap menjaga 
    atau menghindari masalah baru seperti: inkonsistensi data (karana data yang sama diubah oleh banyak pemakai 
    pada saat yang bersamaan) dan juga kondisi deadlock (karena ada banyak pemakai yang saling menunggu 
    untuk menggunakan data tersebut.


Pengertian DBMS
Pengertian DBMS
DBMS mengoptimalkan pengelolaan data menggunakan teknik skema database yang disebut normalisasi. Hasilnya, 
tabel data besar akan dipecah menjadi bagian-bagian yang lebih kecil untuk meminimalkan redundansi dan dependensi.

Selain itu, DBMS mendukung akses konkuren sehingga beberapa user bisa berinteraksi dengan database secara bersamaan, 
tapi tetap mempertahankan integritas data.

DBMS berjalan menggunakan command sistem. Dengan menginput command, administrator database akan memberikan instruksi 
untuk mengambil, mengubah, atau memuat data yang ada.

Nah, DBMS biasanya terdiri dari beberapa komponen terintegrasi yang melakukan tugas pengelolaan data:
Storage engine. Storage engine atau mesin penyimpanan adalah elemen inti DBMS yang berinteraksi dengan 
    sistem file di tingkat sistem operasi.
Query language. Contohnya termasuk Structured Query Language (SQL) dan MongoDB Query Language (MQL), 
    keduanya digunakan untuk berinteraksi dengan database.
Query processor. Komponen ini menafsirkan query user sehingga database bisa memahami command yang diinput.
Optimization engine. Memberikan insight tentang performa dan kueri database.
Metadata catalog. Komponen ini bertindak sebagai repositori objek database. Setiap objek yang dibuat 
    akan disimpan di sini. Katalog ini digunakan untuk memverifikasi kueri user dan memberikan detail struktur database.
Log manager. Komponen ini melacak aktivitas pengguna, login, backup, dan tindakan lain yang dilakukan dengan DBMS.
Reporting and monitoring tool. Utilitas ini menghasilkan laporan dan memantau penggunaan resource DBMS.
Data utilities. Tool tambahan yang melakukan tugas backup dan recovery, validasi data, perbaikan database, 
    dan pengecekan integritas data di shared server atau private server Anda.
Jenis DBMS
DBMS dikategorikan berdasarkan distribusi database, model data, dan jumlah user yang didukung. Berikut ini adalah 3 jenis DBMS yang paling utama:

Relational Database Management System (RDBMS)
Relational Database Management System memiliki antarmuka yang user-friendly dan menggunakan data terstruktur 
dalam bentuk tabel dengan relasi yang telah ditentukan sebelumnya. RDBMS menggunakan SQL agar bisa berinteraksi dengan database.

Fitur-fitur yang membedakan RDBMS dengan DBMS adalah:

Struktur. Data disusun dalam format tabel.
Pengguna. RDBMS mendukung banyak user yang mengoperasikannya secara bersamaan.
Program. Mengontrol relasi antartabel data yang tergabung.
Data. RDBMS bisa menangani data dalam jumlah besar.
Database terdistribusi: Mendukung database terdistribusi, sedangkan DBMS tidak mendukungnya.
Redundansi data: RDBMS memiliki kunci dan indeks untuk mencegah redundansi data. Sementara itu, 
    DBMS biasanya tidak memiliki fitur semacam ini.
Document Database Management System (DoDBMS)
Document Database Management System atau DoDBMS mengelola data dalam file yang mirip dengan JSON, 
    yang hampir tidak memiliki struktur relasional. Sistem ini biasanya menggunakan MongoDB Query Language untuk operasi database,
    termasuk membaca dan menulis.

Columnar Database Management System (CDBMS)
CDBMS mengelola database dalam format kolom untuk mencapai performa tinggi. Sistem ini menyediakan pemrosesan 
    analitik yang cepat karena membaca data secara efisien. Itulah sebabnya bisnis dengan data yang memerlukan 
    kapasitas disk besar biasanya menggunakan CDBMS.

Contoh DBMS
MySQL. Database relasional yang menyimpan data dalam bentuk tabel.
PostgreSQL. Database relasional yang memungkinkan Anda menyesuaikan jenis dan fungsi data.
MongoDB. Sistem database dokumen yang mengubah data JSON menjadi format file biner.
Cassandra Database. Sistem database terdistribusi yang mereplikasi data di beberapa perangkat.
Oracle Database. Database relasional yang membagi struktur fisik dan logis dalam arsitektur sistemnya.

1. Pengertian Field
Filed adalah kumpulan karakter yang membentuk suatu arti, misal dalam filed selalu ada KodeBarang, NamaBarang, 
KodeBarang, JenisBarang, dan sebagainya, maka semua acuannya harus yang berkaitan dengan KodeBarang. 
Biasa juga arti filed merupakan tempat berupa kolom yang ada pada table untuk mengisi data, 
yang biasanya ada pada kolom database seperti di Microsoft Acces atau Database lainnya.

2. Pengertian Record

Record adalah kumpulan field yang lengkap dan kompleks, biasanya satu record dihitung dalam satu baris yang ada 
pada table basis data. Singkatnya basis data (database) merupakan element data yang berkaitan satu sama lain. 
Misalnya pada table memiliki komlom KodeBarang, NamaBarang, JenisBarang, TanggalExpiredBarang, 
maka yang dimaksud record yaitu satu baris data dari KodeBarang hingga TanggalExpiredBarang.

3. Pengertian Table / Tabel
Table adalah kumpulan dari field dan record. Ada juga yang mengartikan table merupakan susunan antara baris dan kolom, 
sehingga strukturnya lebih kompleks. Tabel sering digunakan pada penelitian, analisis data, hingga basis data. 
Database sendiri bentuknya berupa table, dna dalam table tersebut berisi kumpulan data yang kompleks, 
data tersebut diolah kembali hingga menampilkan berbagai bentuk bisa berupa diagram, daftar data yang di inginkan, 
dan sebagainya.

4. Pengertian File
File adalah sering disebut sebagai berkas komputer (computer file) yang disimpan dalam komputer bisa di akses, 
diatur, di modifikasi oleh pengunanya. File didalamnya terdiri dari data, table yang menggambarkan kesatuan data. 
Dalam basis data file biasanya merupakan table dengan kumpulan data yang sejenis, misalnya ada file berisikan 
table NamaBarang maka semua isinya merupakan yang berkaitan dengan NamaBarang.

NORMALISASI
Normalisasi database 1NF, 2NF, dan 3NF akan sering kita lakukan ketika akan membuat sebuah database yang optimal. 
Jika kamu ingin menjadi seorang Database Administrator (DBA) harus tahu bagaimana cara normalisasi database yang optimal. 
Misalkan suatu saat ketika website yang kamu buat mengalami penurunan kinerja, mungkin kamu akan ditanya apakah database 
tersebut sudah dinormalisasi dengan benar?


Pengertian Normalisasi Database
Normalisasi database adalah proses pengelompokan atribut data yang membentuk entitas sederhana, nonredundant, 
fleksibel, dan mudah beradaptasi. Sehingga dapat dipastikan bahwa database yang dibuat berkualitas baik.


Tujuan Normalisasi Database
Tujuan utama dari normalisasi database adalah:

Menghilangkan dan mengurangi redudansi data.
Memastikan dependensi data (data berada pada tabel yang tepat).
Jika sebuah database belum dinormalisasi, kemungkinan terburuk yang akan merugikan sistem adalah:

INSERT Anomali
Situasi dimana tidak memungkinkan untuk memasukkan beberapa jenis data secara langsung di database.
UPDATE Anomali
Situasi dimana nilai yang diubah mengakibatkan ketidakkonsistenan database, artinya data yang diubah tidak 
    sesuai dengan yang diinginkan.
DELETE Anomali
Penghapusan data tidak sesuai yang diharapkan, artinya data yang seharusnya tidak terhapus malah terhapus.

1NF
Suatu tabel dikatakan 1NF jika dan hanya jika setiap atribut dari data tersebut hanya memiliki nilai tunggal dalam satu baris.

2NF
Syarat 2NF adalah tidak diperkenankan adanya partial “functional dependency” kepada primary key dalam sebuah tabel.
Apa itu “functional dependency”?
Functional dependency adalah setiap atribut yang bukan kunci (non key) bergantung secara fungsional terhadap primary key.
Masih bingung?
Intinya adalah pada tahap normalisasi 2NF ini tabel tersebut harus dipecah berdasarkan primary key. 
Sehingga bentuk normalisasi 2NF dari tabel tersebut adalah sebagai berikut:
Tabel Barang dan Tabel Transaksi

3NF
Pada 3NF tidak diperkenankan adanya partial “transitive dependency” dalam sebuah tabel.
Apa itu “transitive dependency”? Transitive dependency biasanya terjadi pada tabel hasil relasi, 
atau kondisi dimana terdapat tiga atribut A, B, C. Kondisinya adalah A ⇒ B dan B ⇒ C. Maka C dikatakan 
sebagai transitive dependency terhadap A melalui B.
Masih bingung?
Intinya pada 3NF ini, jika terdapat suatu atribut yang tidak bergantung pada primary key tapi bergantung 
pada field yang lain maka atribut-atribut tersebut perlu dipisah ke tabel baru.
Contohnya ada pada atribut qty, kolom tersebut tidak bergantung langsung pada primary key kode_faktur melainkan 
bergantung pada kolom kode_barang. Jadi setelah dinormalisasi 3NF akan menghasilkan tabel berikut:
Tabel Barang, Tabel Faktur dan Tabel Detail Faktur
Dari gambar tabel di atas dapat dilihat pada tahap normalisasi 3NF menghasilkan 1 tabel baru dari hasil pemecahan 
tabel transaksi yaitu tabel detail barang yang isinya menampung barang-barang yang dibeli.

Eitss… coba perhatikan gambar di atas! kenapa di tabel detail barang terdapat kolom harga lagi? padahal kolom harga 
sudah ada di tabel barang. Baca penjelasannya di bawah ini.
Kolom harga pada tabel detail barang digunakan untuk menyimpan harga barang pada saat proses transaksi. 
Jadi, meskipun kolom harga pada tabel barang berubah (naik/turun), harga barang yang ada pada tabel detail 
barang tidak ikut berubah (fixed). Bayangkan jika kita tidak menambahkan kolom harga pada pada tabel detail barang, 
maka yang terjadi total invoice dari transaksi akan berubah seiring berubahnya harga barang.

SQL Server Basics
// Penjelasan login ke SQL Server via SSMS

1. SQL.
SQL adalah bahasa non procedural untuk mengakses data pada database relational. 

2. Standarisasi SQL
Standarisasi SQL di definisikan oleh ANSI (American National Std Institute).  SQL bukan ditemukan oleh ANSI tp oleh IBM.
3. Interactive dan Embbeded SQL
Dalam SQL ada 2 pengertian atau definisi, yaitu interactive dan embbeded SQL. Interactive SQL di gunakan untuk untuk dioperasikan
secara langsung  pada suatu database untuk  menghasilkan output untuk langsung di lihat hasilnya.  Embedded SQL terdiri dari 
perintah2 yang di letakkan dalam program, umumnya menggunakan bahasa pemrogramman lain seperti Delphi, C#, Java dll.

Bagian dari SQL
SQL terdiri dari 3 bagian
1. DDL (Data Definition Language)
   Juga disebut sebagai schema definition language, terdiri atas perintah2 SQL untuk membuat sebuah object seperti table, index,
   view dll.  
2. Data Manipulation Language
   Kumpulan perintah2 SQL untuk menentukan atau memanipulasi isi suatu tabel. 
3. Data Control Language
   Terdiri atas perintah untuk menentukan izin akses dari user dalam suatu database.

DDL.
1. Create Table : Digunakan untuk membuat sebuah table.
Create Table <Table_Name> (<column1> <datatype> [(<size>)], <column1> <datatype> [(<size>)],..)
Contoh:
CREATE TABLE SalesPromotion (nomor int, nama varchar(100), kota varchar(100));

2. Alter Table : Digunakan untuk mengubah definisi dari table.
ALTER TABLE <table name> ADD <column> <data type> <size>;
ALTER TABLE SalesPromotion ADD nik varchar(10);
3. Drop Table : Digunakan untuk menghapus sebuah table.
    DROP TABLE <NamaTable>
    DROP TABLE SalesPromotion;
    DROP digunakan untuk menghapus seluruh database atau hanya sebuah tabel. Pernyataan DROP menghancurkan objek seperti database, 
    tabel, indeks, atau tampilan yang ada.
    Pernyataan DROP dalam SQL menghapus komponen dari sistem manajemen basis data relasional (RDBMS).
    Sintaksis:

    DROP objek object_name

    Contoh:
    DROP TABLE nama_tabel; 
    table_name : Nama tabel yang akan dihapus.

    DROP DATABASE database_name; 
    database_name : Nama database yang akan dihapus.
    
    TRUNCATE adalah operasi Data Definition Language (DDL) yang digunakan untuk menandai tingkat tabel untuk deallokasi 
    (kosong untuk digunakan kembali). Hasil dari operasi ini dengan cepat menghapus semua data dari tabel, biasanya 
    melewati sejumlah mekanisme penegakan integritas. Ini secara resmi diperkenalkan dalam standar SQL:2008 .
    Pernyataan mytable TRUNCATE TABLE secara logis (meskipun tidak secara fisik) setara dengan pernyataan 
    DELETE FROM mytable (tanpa klausa WHERE).

    TRUNCATE TABLE table_name; 
    table_name : Nama tabel yang akan dipotong.

    DROP vs TRUNCATE
    Truncate biasanya sangat cepat dan ideal untuk menghapus data dari tabel sementara.
    Truncate mempertahankan struktur tabel untuk penggunaan di masa mendatang, tidak seperti tabel drop di mana tabel dihapus 
        dengan struktur penuhnya.
    Penghapusan tabel atau database menggunakan statement DROP tidak dapat di-roll back, sehingga harus digunakan dengan bijak.
 */

//// CONTOH 1
//// CREATE DATABASE VIA ADO.NET
//using System;
//using System.Data.SqlClient;
//using System.Xml.Linq;

//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().CreateTable();
//        }
//        public void CreateTable()
//        {
//            SqlConnection con = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
//                // writing sql query  
//                SqlCommand cm = new SqlCommand(@"create table student(studentId int not null,   
//                name varchar(100))", con);  
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                cm.ExecuteNonQuery();
//                // Displaying a message  
//                Console.WriteLine("Table created Successfully");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong." + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}


// CONTOH 2
// INSERT TABLE VIA ADO.NET
//using System;
//using System.Data.SqlClient;
//using System.Xml.Linq;

//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().CreateTable();
//        }
//        public void CreateTable()
//        {
//            SqlConnection con = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
//                // writing sql query  
//                SqlCommand cm = new SqlCommand(@"insert into student  
//                (studentid, name)values('101', 'Ronald Trump')", con);
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                cm.ExecuteNonQuery();
//                // Displaying a message  
//                Console.WriteLine("Record Inserted Successfully");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong." + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}

// CONTOH 3
// Get Data via ADONET
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().CreateTable();
//        }
//        public void CreateTable()
//        {
//            SqlConnection con = null;
//            SqlTransaction sqlTransaction = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");

//                sqlTransaction = con.BeginTransaction();
//                // writing sql query  
//                SqlCommand cm = new SqlCommand("Select * from student", con);
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                SqlDataReader sdr = cm.ExecuteReader();
//                sqlTransaction.Commit();

//                // Iterating Data  
//                while (sdr.Read())
//                {
//                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " "); // Displaying Record  
//                }
//            }
//            catch (Exception e)
//            {
//                sqlTransaction.Rollback();
//                Console.WriteLine("OOPs, something went wrong.\n" + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}


//// CONTOH 4
//// Menghapus Data
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().CreateTable();
//        }
//        public void CreateTable()
//        {
//            SqlConnection con = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
//                // writing sql query  
//                SqlCommand cm = new SqlCommand("delete from student where id = '101'", con);
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                cm.ExecuteNonQuery();
//                Console.WriteLine("Record Deleted Successfully");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong.\n" + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}

// CONTOH 5
// SQL Connection
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().Connecting();
//        }
//        public void Connecting()
//        {
//            using (
//                     // Creating Connection  
//                     SqlConnection con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI")
//                 )
//            {
//                con.Open();
//                Console.WriteLine("Connection Established Successfully");
//            }
//        }
//    }
//}

// CONTOH 6
// SQLConnection
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().Connecting();
//        }
//        public void Connecting()
//        {
//            SqlConnection con = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
//                con.Open();
//                Console.WriteLine("Connection Established Successfully");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong.\n" + e);
//            }
//            finally
//            {   // Closing the connection  
//                con.Close();
//            }
//        }
//    }
//}

//// CONTOH 7
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().CreateTable();
//        }
//        public void CreateTable()
//        {
//            SqlConnection con = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
//                // writing sql query  
//                SqlCommand cm = new SqlCommand("select * from student", con);
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                SqlDataReader sdr = cm.ExecuteReader();
//                while (sdr.Read())
//                {
//                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong." + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}

// CONTOH 8
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().GetData();
//        }
//        public void GetData()
//        {
//            SqlConnection con = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
//                // writing sql query  
//                SqlCommand cm = new SqlCommand("select * from student", con);
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                SqlDataReader sdr = cm.ExecuteReader();
//                while (sdr.Read())
//                {
//                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong." + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}


using System.Data.Common;
using System.Data.SqlClient;

public class Student
{
    public int Id 
    { 
        get; 
        set; 
    }

    public string Name
    {
        get; set;
    }

    public int Age
    {
        get;
        set;
    }
}

// Define the interface for the data access layer
public interface IDataAccess
{
    List<Student> GetAllStudents();
    Student GetStudentById(int id);
    void InsertStudent(Student student);
    void UpdateStudent(Student student);
    void DeleteStudent(Student student);
}

// Define the abstract base class for the data access layer
public abstract class DataAccessBase : IDataAccess
{
    // Implement the interface methods as abstract methods
    public abstract List<Student> GetAllStudents();
    public abstract Student GetStudentById(int id);
    public abstract void InsertStudent(Student student);
    public abstract void UpdateStudent(Student student);
    public abstract void DeleteStudent(Student student);
}

// Define the concrete class for the data access layer using ADO.NET
public class AdoNetDataAccess : DataAccessBase
{
    private readonly SqlConnection _connection;

    public AdoNetDataAccess(SqlConnection connection)
    {
        _connection = connection;
    }

    // Implement the abstract methods using ADO.NET
    public override List<Student> GetAllStudents()
    {
        // Code to retrieve all students using ADO.NET goes here
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Students";

            using (var reader = command.ExecuteReader())
            {
                var students = new List<Student>();

                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Age = (int)reader["Age"]
                    });
                }

                return students;
            }
        }
    }

    public override Student GetStudentById(int id)
    {
        // Code to retrieve a student by ID using ADO.NET goes here
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "SELECT * FROM Students WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Student
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Age = (int)reader["Age"]
                    };
                }
            }
        }

        return null;
    }

    public override void InsertStudent(Student student)
    {
        // Code to insert a student using ADO.NET goes here
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "INSERT INTO Students (Name, Age) VALUES (@name, @age)";
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@age", student.Age);
            command.ExecuteNonQuery();
        }
    }

    public override void UpdateStudent(Student student)
    {
        // Code to update a student using ADO.NET goes here
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "UPDATE Students SET Name = @name, Age = @age WHERE Id = @id";
            command.Parameters.AddWithValue("@id", student.Id);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@age", student.Age);
            command.ExecuteNonQuery();
        }
    }

    public override void DeleteStudent(Student student)
    {
        // Code to delete a student using ADO.NET goes here
        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "DELETE FROM Students WHERE Id = @id";
            command.Parameters.AddWithValue("@id", student.Id);
            command.ExecuteNonQuery();
        }
    }
}

class Program
{
   private static readonly string ConString = @"";

    public static void Main()
    {
        SqlConnection sqlConnection = new SqlConnection(ConString);

        // Create an instance of the data access layer
        IDataAccess dataAccess = new AdoNetDataAccess(sqlConnection);

        while (true)
        {
            Console.WriteLine("1. View all students");
            Console.WriteLine("2. View student by ID");
            Console.WriteLine("3. Add new student");
            Console.WriteLine("4. Update student");
            Console.WriteLine("5. Delete student");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (choice == 1)
            {
                // Call the GetAllStudents method
                List<Student> students = dataAccess.GetAllStudents();

                // Display the students
                foreach (Student student in students)
                {
                    Console.WriteLine("ID: {0}", student.Id);
                    Console.WriteLine("Name: {0}", student.Name);
                    Console.WriteLine("Age: {0}", student.Age);
                    Console.WriteLine();
                }
            }
            else if (choice == 2)
            {
                // Edit student
            }
            else if (choice == 3)
            {
                // Delete student
            }
            else if (choice == 4)
            {
                // View students
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection");
            }
        }
    }
}