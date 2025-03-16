using System;

namespace NvRFSHO3
{
    class Program
    {
        static void Main(string[] args)
        {
            SayiKontrol kontrol = new SayiKontrol();

            Console.WriteLine("Lütfen bir sayı giriniz:");
            if (int.TryParse(Console.ReadLine(), out int sayi))
            {
                // Tek mi çift mi kontrolü
                string tekCiftSonuc = kontrol.TekCiftKontrol(sayi);
                Console.WriteLine(tekCiftSonuc);

                // Pozitif/Negatif kontrolü
                string pozitifNegatifSonuc = kontrol.PozitifNegatifKontrol(sayi);
                Console.WriteLine(pozitifNegatifSonuc);
            }
            else
            {
                Console.WriteLine("Geçerli bir sayı girmediniz!");
            }

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
