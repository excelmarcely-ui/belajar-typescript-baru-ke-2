using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan sebuah angka: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        if (angka % 2 == 0)
        {
            Console.WriteLine("Bilangan Genap");
        }
        else
        {
            Console.WriteLine("Bilangan Ganjil");
        }
    }
}