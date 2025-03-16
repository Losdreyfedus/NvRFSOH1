using System;

namespace NvRFSHO2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bellek kullanımı karşılaştırması
            Console.WriteLine("1- Bellek Kullanımı Karşılaştırması");
            Console.WriteLine("-----------------------------------");
            BellekKullanimi bellek = new BellekKullanimi();
            bellek.BellekKarsilastir();

            // Sayıları toplama
            Console.WriteLine("\n2- Sayıları Toplama");
            Console.WriteLine("-------------------");
            Hesaplama hesap = new Hesaplama();
            hesap.SayilariTopla();

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
