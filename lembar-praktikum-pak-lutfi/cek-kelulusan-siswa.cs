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

                    if (nilaiTeori >= 90)
                    {
                        Console.WriteLine("Predikat Teori: Sangat Baik");
                    }
                    else
                    {
                        Console.WriteLine("Predikat Teori: Baik");
                    }
                    
                    if (nilaiPraktek >= 90)
                    {
                        Console.WriteLine("Predikat Praktik: Sangat Baik");
                    }
                    else
                    {
                        Console.WriteLine("Predikat Praktik: Baik");
                    }
                }
                else
                {
                    Console.WriteLine("Status: TIDAK LULUS");
                    Console.WriteLine("Alasan: Nilai Kehadiran Kurang dari 80");
                }
            }
            else
            {
                Console.WriteLine("Status: TIDAK LULUS");
                Console.WriteLine("Alasan: Nilai Praktek Kurang dari 75");
            }
        }
        else
        {
            Console.WriteLine("Status: TIDAK LULUS");
            Console.WriteLine("Alasan: Nilai Teori Kurang dari 75");
        }
    }
}