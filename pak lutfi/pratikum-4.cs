using System;
class Program
{
    static void Main()
    {
        Console.Write("Apakah siswa?(true/false):");
        bool siswa=Convert.ToBoolean(Console.ReadLine());
        Console.Write("Apakah Guru?(ture/false):");
        bool Guru=Convert.ToBoolean(Console.ReadLine());
        Console.Write("Memiliki kartu akses?(true/false):");
        bool kartuAkses=Convert.ToBoolean(Console.ReadLine());
        if((siswa || Guru)&& kartuAkses)
        {
            Console.WriteLine("Akses labotarium DITERIMA.");
        }
        else
        {
            Console.WriteLine("Akses laboratorium DITOLAK.");
        }
    }
}