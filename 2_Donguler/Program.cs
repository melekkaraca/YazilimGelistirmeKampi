using System;

namespace _2_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //string dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java", "Python" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine();
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}