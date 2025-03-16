using System;

namespace NvRFSHO2
{
    public class BellekKullanimi
    {
        public void BellekKarsilastir()
        {
            int x = 5;
            double y = 5.2;
            string name = "Mehmet";

            Console.WriteLine("Değişkenlerin Bellek Kullanımı:");
            Console.WriteLine($"int x = 5: {sizeof(int)} byte");
            Console.WriteLine($"double y = 5.2: {sizeof(double)} byte");
            Console.WriteLine($"string name = \"Mehmet\": {System.Text.ASCIIEncoding.Unicode.GetByteCount(name)} byte");
            
            Console.WriteLine("\nEk Bilgiler:");
            Console.WriteLine("- int: Tam sayılar için kullanılır ve 4 byte yer kaplar");
            Console.WriteLine("- double: Ondalıklı sayılar için kullanılır ve 8 byte yer kaplar");
            Console.WriteLine("- string: Metin için kullanılır ve her karakter için 2 byte yer kaplar (Unicode)");
        }
    }
} 