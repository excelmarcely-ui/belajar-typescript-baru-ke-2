using System;
class Program
{
    static void Main()
    {
        string Pin = "123456";
        int saldo = 500000;
        Console.Write("Masukkan PIN: ");
        string PIN =Console.ReadLine();

        if (PIN == Pin)
        {
            Console.Write("Jumlah penarikan: ");
            int penarikan = Convert.ToInt32(Console.ReadLine());

            if (penarikan <= saldo)
            {
                saldo -= penarikan;
                Console.WriteLine("Transaksi berhasil, sisa saldo: " + saldo);
            }
            else
            {
                Console.WriteLine("Saldo tidak cukup, transaksi ditolak");
            }
        }
        else
        {
            Console.WriteLine("PIN salah");
        }
    }
}