// 2. soru: Kullanıcıdan alınan değerlerle dizi oluşturma ve yazdırma
int[] kullaniciDizisi = DiziIslemleri.DiziOlusturVeDoldur();
DiziIslemleri.DiziyiYazdir(kullaniciDizisi);

// 3. soru: Dizideki en büyük sayıyı bulma
int[] ornekDizi = { 12, 45, 6, 78, 23 };
int enBuyukSayi = DiziIslemleri.EnBuyukSayiyiBul(ornekDizi);
Console.WriteLine($"Dizideki en büyük sayı: {enBuyukSayi}");