using System;

class Program
{
    static void Main()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (username == "admin")
        {
            if (password == "12345")
            {
                Console.WriteLine("Login berhasil.");
            }
            else
            {
                Console.WriteLine("Password salah.");
            }
        }
        else
        {
            Console.WriteLine("Username tidak ditemukan.");
        }
    }
}