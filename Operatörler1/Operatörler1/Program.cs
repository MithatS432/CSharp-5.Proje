using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatörler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aritmetik Operatörler
            int a = 10;
            int b = 3;

            Console.WriteLine("Aritmetik Operatörler:");
            Console.WriteLine("Toplama: " + (a + b));
            Console.WriteLine("Çıkarma: " + (a - b));
            Console.WriteLine("Çarpma: " + (a * b));
            Console.WriteLine("Bölme: " + (a / b));
            Console.WriteLine("Mod (kalan): " + (a % b));

            // Karşılaştırma Operatörleri
            Console.WriteLine("\nKarşılaştırma Operatörleri:");
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != b: " + (a != b));
            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a >= b: " + (a >= b));
            Console.WriteLine("a <= b: " + (a <= b));

            // Mantıksal Operatörler
            bool x = true;
            bool y = false;

            Console.WriteLine("\nMantıksal Operatörler:");
            Console.WriteLine("x && y: " + (x && y));
            Console.WriteLine("x || y: " + (x || y));
            Console.WriteLine("!x: " + (!x));

            // Atama Operatörleri
            int sayi = 5;
            sayi += 3; // sayi = sayi + 3;
            Console.WriteLine("\nAtama Operatörleri:");
            Console.WriteLine("sayi += 3: " + sayi);
            sayi *= 2; // sayi = sayi * 2;
            Console.WriteLine("sayi *= 2: " + sayi);

            // Ternary Operatör
            int yas = 20;
            string sonuc = (yas >= 18) ? "Reşit" : "Reşit değil";
            Console.WriteLine("\nTernary Operatör:");
            Console.WriteLine("Durum: " + sonuc);
        }
    }
}
