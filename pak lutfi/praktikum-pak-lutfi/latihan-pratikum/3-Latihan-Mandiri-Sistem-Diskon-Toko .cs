using System;
class Program
{
    static void Main()
    {
        Console.Write("Masukkan total belanja (Rp): ");
        double totalBelanja = Convert.ToDouble(Console.ReadLine());
        double persentaseDiskon = 0;

        if (totalBelanja >= 1000000)
        {
            persentaseDiskon = 20;
        }
        else if (totalBelanja >= 500000)
        {
            persentaseDiskon = 10;
        }
        else if (totalBelanja >= 250000)
        {
            persentaseDiskon = 5;
        }
        else
        {
            persentaseDiskon = 0;
        }

        double nominalPotongan = (persentaseDiskon / 100) * totalBelanja;
        double totalBayar = totalBelanja - nominalPotongan;

        Console.WriteLine($"Total Belanja              : Rp {totalBelanja:N0}");
        Console.WriteLine($"Persentase Diskon          : {persentaseDiskon}%");
        Console.WriteLine($"Nominal Potongan           : Rp {nominalPotongan:N0}");
        Console.WriteLine($"Total Bayar Setelah Diskon : Rp {totalBayar:N0}");
    }
}