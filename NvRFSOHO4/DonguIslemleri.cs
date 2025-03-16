using System;

public class DonguIslemleri
{
    public static void BirdenOnaKadarYazdir()
    {
        Console.WriteLine("1'den 10'a kadar olan sayılar:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static int SayilarinToplaminiHesapla(int limit)
    {
        int toplam = 0;
        for (int i = 1; i <= limit; i++)
        {
            toplam += i;
        }
        return toplam;
    }
}