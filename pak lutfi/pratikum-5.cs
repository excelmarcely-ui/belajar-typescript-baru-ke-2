using System;
class Program
{
    static void Main()
    {
        string usernameBenar = "Excell marcely";
        string passwordBenar = "201009";
        Console.Write("Username: ");
        string username =Console.ReadLine();
        Console.Write("Password: ");
        string password =Console.ReadLine();
        if(username == usernameBenar && password == passwordBenar)
        {
            Console.WriteLine("Login berhasil");
            }
            else
            {
            Console.WriteLine("Username atau password salah");
            
        }
    }
}