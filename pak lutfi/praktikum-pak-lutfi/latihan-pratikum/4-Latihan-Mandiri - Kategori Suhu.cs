using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan suhu: ");
        int nilai = Convert.ToInt32(Console.ReadLine());

        if (nilai >=30)
            Console.WriteLine("Panas");
        else if (nilai >=26)
            Console.WriteLine("Normal");
        else if (nilai >= 20)
            Console.WriteLine("Sejuk");
        else if (nilai <= 15)
            Console.WriteLine("Dingin");
    }
}