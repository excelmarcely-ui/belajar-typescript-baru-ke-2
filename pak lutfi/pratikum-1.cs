using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukan Nilai:");
        int Nilai=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Masukan persentase kehadiran:");
        int kehadiran=Convert.ToInt32(Console.ReadLine());
        if(Nilai >=75&& kehadiran >=80)
        {
            Console.WriteLine("Status:LULUS");
        }
        else
        {
            Console.WriteLine("Ststus: TIDAK LULUS");
        }
    }
}