using System;

public class DiziIslemleri
{
    public static int[] DiziOlusturVeDoldur()
    {
        int[] sayilar = new int[5];

        Console.WriteLine("5 adet sayı giriniz:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        return sayilar;
    }

    public static void DiziyiYazdir(int[] dizi)
    {
        Console.WriteLine("Girdiğiniz sayılar:");

        foreach (int sayi in dizi)
        {
            Console.WriteLine(sayi);
        }
    }

    public static int EnBuyukSayiyiBul(int[] dizi)
    {
        int enBuyuk = dizi[0];

        for (int i = 1; i < dizi.Length; i++)
        {
            if (dizi[i] > enBuyuk)
            {
                enBuyuk = dizi[i];
            }
        }

        return enBuyuk;
    }
}