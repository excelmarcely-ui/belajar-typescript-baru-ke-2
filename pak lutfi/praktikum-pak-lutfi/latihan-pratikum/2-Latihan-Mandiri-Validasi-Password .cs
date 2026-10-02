using System;
class Program
{
    static void Main()
    {
        string passwordBenar = "antartika"; 
        Console.WriteLine("Masukan Password:");
        string password = Console.ReadLine();
        if (password == passwordBenar)
        {
            Console.WriteLine("Login Berhasil");
        }
        else
        {
            Console.WriteLine("Password Salah");
        }
    }
}