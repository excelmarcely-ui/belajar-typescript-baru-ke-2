using System;
class Program
{
        static void Main()
    {
        Console.WriteLine("Nilai Teori:");
        int Teori=Convert.ToInt32(Console.ReadLine());
        Console.Write("Nilai Praktik:");
        int Praktik=Convert.ToInt32(Console.ReadLine());
        if(Teori <75 || Praktik > 75)
        {
            Console.WriteLine("Murid mengikuti REMEDIAL.");
        }
        else
        {
            Console.WriteLine("Murid tidak perlu mengikuti REMEDIAL.");
        }
    }
}