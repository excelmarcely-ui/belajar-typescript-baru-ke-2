using System;
class Program
{
    static void Main()
    {
        Console.Write(" Nilai produktif: ");
        int Nilai =Convert.ToInt32(Console.ReadLine());
        Console.Write("  kehadiran: ");
        int kehadiran =Convert.ToInt32(Console.ReadLine());
        Console.Write(" nilai sikap: ");
        int nilai =Convert.ToInt32 (Console.ReadLine());

        if ( Nilai >= 80)
        {
            if (kehadiran >= 90)
            {
                if (nilai >= 80)
                {
                    Console.WriteLine("Status: LAYAK PKL");
                }
            }
        }
        else
        {
            Console.WriteLine("Status:TIDAK LAYAK");
        }
    } 
}