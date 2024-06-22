using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = "Kazuo";
            int bulan = 7;
            int tanggal_lahir = bulan + 5;
            Console.WriteLine("~~ Masukkan nama anda ~~");
            Console.WriteLine("========================");
            var need = Console.ReadLine();
            Console.WriteLine("========================");
            Console.WriteLine($"Response:\nHallo {need}, {k} Ulang tahun pada tanggal {tanggal_lahir} dan bulan {bulan}");
            Console.WriteLine("========================");
        }
    }
}

