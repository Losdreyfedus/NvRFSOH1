using System;

namespace NvRFSHO1
{
    public class KullaniciAdi
    {
        public void AdGoster()
        {
            Console.WriteLine("Lütfen adınızı giriniz:");
            string ad = Console.ReadLine();

            // Boş girişi kontrol et
            if (string.IsNullOrWhiteSpace(ad))
            {
                Console.WriteLine("İsim boş bırakılamaz!");
                return;
            }

            Console.WriteLine($"\nMerhaba, {ad}! Programımıza hoş geldiniz.");
        }
    }
} 