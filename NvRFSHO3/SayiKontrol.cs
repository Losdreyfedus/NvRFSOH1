namespace NvRFSHO3
{
    public class SayiKontrol
    {
        public string TekCiftKontrol(int sayi)
        {
            return sayi % 2 == 0 ? "Çift sayı" : "Tek sayı";
        }

        public string PozitifNegatifKontrol(int sayi)
        {
            if (sayi > 0)
                return "Pozitif sayı";
            else if (sayi < 0)
                return "Negatif sayı";
            else
                return "Sayı sıfırdır";
        }
    }
} 