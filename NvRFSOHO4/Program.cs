using System;

public class Program
{
    public static void Main(string[] args)
    {
        // 2. soru: 1'den 10'a kadar sayıları yazdırma
        DonguIslemleri.BirdenOnaKadarYazdir();

        // 3. soru: Kullanıcının girdiği sayıya kadar olan sayıların toplamını hesaplama
        Console.Write("Bir sayı girin: ");
        int kullaniciSayisi = Convert.ToInt32(Console.ReadLine());
        int toplam = DonguIslemleri.SayilarinToplaminiHesapla(kullaniciSayisi);
        Console.WriteLine($"1'den {kullaniciSayisi}'e kadar olan sayıların toplamı: {toplam}");
    }
}