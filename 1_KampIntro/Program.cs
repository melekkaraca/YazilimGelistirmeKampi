using System;

namespace _1_KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety : tip güvenliği
            //Do not repeat yourself : Kendini tekrarlama
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Çıkış Yap");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }
        }
    }
}