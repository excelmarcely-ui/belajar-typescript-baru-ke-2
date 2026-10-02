using System;
/*
1. implicit casting (Bertahap)
   - Implicit casting adalah proses konversi tipe data dari tipe data yang lebih kecil ke tipe data yang lebih besar secara otomatis 
      oleh compiler.
   - biasanya terjadi ketika kita mengkonversi tipe data yang lebih kecil 
      ke tipe data yang lebih besar.
   - Contoh: byte -> short -> int -> long -> float -> double -> decimal
   - Keuntungan dari implicit casting adalah.
        - Tidak perlu menulis kode tambahan untuk melakukan konversi.
            karena compiler akan melakukan konversi secara otomatis.
        b. mngurangi kemungkinan kesalahan konversi tipe data
            karena compiler akan melakukan pencocokan tipe data secara otomatis.
        c. meningkatkan keterbacaan kode karena tidak perlu menulis kode konversi secara eksplisit.
        d. meningkatkan perfoma program karena tidak perlu melakukan konversi tipe data secara manual.
        e. meningkatkan keamanan program karena compiler akan melakukan pengecekan tipe data secara otomatis.
        f. meningkatkan fleksibilitas program karena kita dapat menggunakan tipe data yang lebih besar
            tanpa harus melakukan konversi secara manual. 
*/

class Program
{
    static void Main()
    {
        byte nilaiByte = 100; // nilai byte
        short nilaiShort = nilaiByte; // implicit casting dari byte ke short.
        int nilaiInt = nilaiShort; // implicit casting dari short ke int.
        long nilaiLong = nilaiInt; // implicit casting dari int ke long.
        float nilaiFloat = nilaiLong; // implicit casting dari long ke float.
        double nilaiDouble = nilaiFloat; // implicit casting dari float ke double.
        decimal nilaiDecimal = (decimal)nilaiDouble; // implicit casting dari double ke decimal.

        Console.WriteLine("Byte           : " + nilaiByte + " " + nilaiByte.GetType());
        Console.WriteLine("short          : " + nilaiShort + " " + nilaiShort.GetType());
        Console.WriteLine("int            : " + nilaiInt + " " + nilaiInt.GetType);
        Console.WriteLine("long           : " + nilaiLong + " " + nilaiLong.GetType());
        Console.WriteLine("float          : " + nilaiFloat + " " + nilaiFloat.GetType());
        Console.WriteLine("decimal        : " + nilaiDecimal + " " + nilaiDecimal.GetType());
    }
}