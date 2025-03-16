using System;

namespace NvRFSHO1
{
    class Program
    {
        static void Main(string[] args)
        {
            KullaniciAdi kullanici = new KullaniciAdi();
            kullanici.AdGoster();

            Console.WriteLine("\nProgramı kapatmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
