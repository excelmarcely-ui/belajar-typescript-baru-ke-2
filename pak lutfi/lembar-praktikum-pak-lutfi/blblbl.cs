using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukan Nama:");
        string nama = Console.ReadLine();
        Console.Write("Masukan Nilai Teori:");
        int nilaiTeori = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukan Nilai Praktek:");
        int nilaiPraktek = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nilai Kehadiran:");
        int nilaiKehadiran = Convert.ToInt32(Console.ReadLine());

        if (nilaiTeori >= 75)
        {
            if (nilaiPraktek >= 75)
            {
                if (nilaiKehadiran >= 80)
                {
                    Console.WriteLine("Status: LULUS");
                }
            }
        }
        else
        {
            Console.WriteLine("Status: TIDAK LULUS");
        }


        if (nilaiTeori >= 90)
        {
            Console.WriteLine("Predikat Teori:Sangat Baik");
        }
        else
        {
            Console.WriteLine("Predikat Teori: Baik");
        }

        if (nilaiPraktek >= 90)
        {
            Console.WriteLine("Predikat Praktek:Sangat Baik");
        }
        else
        {
            Console.WriteLine("Predikat Praktek: Baik");
        }
    }
}