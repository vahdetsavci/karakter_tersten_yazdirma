using System;
using System.Linq;

namespace karakter_tersten_yazdirma;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir metin giriniz!");
        Console.WriteLine("-----------------------------");
        char[] chars = Console.ReadLine().ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine(chars);
    }
}
