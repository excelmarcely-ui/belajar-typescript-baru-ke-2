using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukan Usia:");
        int Usia = Convert.ToInt32(Console.ReadLine());

        if (Usia >= 17)
        {
            Console.WriteLine("Selamat, Anda Memenuhi Syarat usia");
        }
        else
        {
            Console.WriteLine("Anda tidak Memenuhi syarat usia");
        }
    }
}