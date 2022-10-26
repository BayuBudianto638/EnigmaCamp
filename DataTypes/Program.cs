/////*
////    .NET adalah platform yang mencakup bahasa, runtime, dan pustaka kerangka kerja, memungkinkan
////    pengembang untuk membuat banyak jenis aplikasi. C# adalah salah satu bahasa .NET, yang juga
////    termasuk Visual Basic, F#, C++, dan banyak lagi.
////    Runtime lebih formal bernama Common Language Runtime (CLR). Pemrograman
////    bahasa yang menargetkan kompilasi CLR ke Bahasa Menengah (IL). CLR itu sendiri adalah
////    mesin virtual yang menjalankan IL, JIT (Just In Time) dan menyediakan banyak layanan seperti manajemen memori,
////    pengumpulan sampah (GC, garbage collection), manajemen exception, keamanan/security, dan banyak lagi.
////    Framework Class Library (FCL) adalah seperangkat kode yang dapat digunakan kembali yang menyediakan
////    layanan dan platform khusus teknologi. Layanan umum termasuk jenis penting seperti:
////    seperti koleksi, kriptografi, jaringan, dan lainnya. Selain kelas umum, FCL
////    termasuk platform khusus teknologi seperti ASP.NET, WPF, layanan web, dan banyak lagi. Nilai
////    penawaran FCL adalah memiliki komponen umum yang tersedia untuk digunakan kembali, menghemat waktu dan uang
////    tanpa perlu menulis kode itu sendiri.

////    Framework Class Library atau FCL menyediakan fungsionalitas sistem dalam .NET Framework karena memiliki berbagai kelas, tipe data, 
////    antarmuka, dll. untuk melakukan banyak fungsi dan membangun berbagai jenis aplikasi seperti aplikasi desktop, aplikasi web, aplikasi seluler, dll.  
////    Pustaka Kelas Kerangka terintegrasi dengan Common Language Runtime (CLR) kerangka .NET dan digunakan oleh semua bahasa .NET seperti C#, F#, Visual Basic .NET, dll.

////    Untuk memulai, klik Visual Studio 2022 dan pilih New Projects. Tulis saja EnigmaCamp_Chapter1. Akan tampil file Program.cs.
////    Untuk eksekusi tekan tombol F9 atau ke menu Debug dan pilih Start Debugging.

////    Maka akan tampil pesan Hello World!.

////    Kemudian ganti pada Line Console.Writeline("EnigmaCamp"); Kemudian run kembali.
////    Jika sudah maka coba ketikkan data nama sendiri, menjadi Nama, Alamat, Kota, Provinsi dan Negara.
//// */

////Console.WriteLine("Hello World!");
////Console.ReadKey();


//public class Program
//{
//    public static void Main(string[] args)
//    {
//        int a = 2;
//        int b = 8;

//        b = b / a / a;
//        a = b * b * b;



//        Console.Write("{0} - {1}", a, b);
//    }
//}

// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        int a = 100;
        int b = 10;

        /*
         * Tuliskan Code di sini
         */
        a = b / a;//4
        b /= b;//1
        b += b;//2
        a *= b;//8

        Console.Write("{0} - {1}", a, b);
    }
}
