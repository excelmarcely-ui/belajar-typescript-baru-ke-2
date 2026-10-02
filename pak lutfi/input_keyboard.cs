using System;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    {
        //deklarasi variabel
    string nama;
    string kelas;
    int usia;
    double nilai;
    char jenisKelamin;
    bool aktif;

    //proses
    //Console.ReadLine() digunakan untuk membaca input dari pengguna
    Console.WriteLine("=== INPUT DATA SISWA ===");
    Console.WriteLine("Masukan nama          : ");
    nama = Console.ReadLine() ?? "";
    Console.Write("Masukan kelas             : ");
    kelas = Console.ReadLine() ?? "";
    Console.Write("Masukan usia              : ");
    usia = Convert.ToInt32(Console.ReadLine());
    Console.Write("Masukan nilai             : ");
    nilai = Convert.ToDouble(Console.ReadLine());
    Console.Write("jenisKelamin      :   (L/P) ");
    jenisKelamin = Convert.ToChar(Console.ReadLine() ?? "L");
    Console.Write("status aktif (true/false) :");
    aktif = Convert.ToBoolean(Console.ReadLine());

    //menampilkan hasil input
    Console.WriteLine("\n=== DATA SISWA ==");
    Console.WriteLine($"nama          : {nama}");
    Console.WriteLine($"kelas         : {kelas}");
    Console.WriteLine($"usia          : {kelas}");
    Console.WriteLine($"nilai         : {nilai}");
    Console.WriteLine($"jenisKelamin  : {jenisKelamin}");
    Console.WriteLine($"status aktif   : {aktif}");

    Console.WriteLine("\nTekan Enter Untuk Keluar");
    Console.ReadLine();
    }
}