using System;

namespace NvRFSHO2
{
    public class Hesaplama
    {
        public void SayilariTopla()
        {
            try
            {
                Console.WriteLine("\nLütfen birinci sayıyı giriniz:");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                double toplam = sayi1 + sayi2;
                Console.WriteLine($"\nSonuç: {sayi1} + {sayi2} = {toplam}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nHata: Lütfen geçerli bir sayı giriniz!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nBir hata oluştu: {ex.Message}");
            }
        }
    }
} 