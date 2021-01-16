using System;

namespace _3_ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Category category1 = new Category { ID = 1, Name = "Teknoloji", Active = true };
            Category category2 = new Category { ID = 2, Name = "Beyaz Eşya", Active = true };
            Category[] categories = new Category[] { category1, category2 };

            Product product1 = new Product { ID = 1, Name = "HP NoteBook", CategoryID = 1, Price = 5250, Active = true };
            Product product2 = new Product { ID = 2, Name = "Apple Phone", CategoryID = 1, Price = 7650, Active = false };
            Product product3 = new Product { ID = 3, Name = "Samsung Phone", CategoryID = 1, Price = 5250, Active = true };
            Product product4 = new Product { ID = 4, Name = "Buz Dolabı", CategoryID = 2, Price = 6000, Active = true };
            Product product5 = new Product { ID = 5, Name = "Çamaşır Makinası", CategoryID = 2, Price = 5500, Active = true };
            Product[] products = new Product[] { product1, product2, product3, product4, product5 };
            Console.WriteLine("For döngüsü ile");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı: " + products[i].Name + ", Fiyatı: " + products[i].Price + " TL");
            }
            Console.WriteLine("Foreach döngüsü ile");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı: " + product.Name + ", Fiyatı: " + product.Price + " TL");
            }

            Console.WriteLine("While döngüsü ile");
            int sayac = 0;
            while (products.Length == products.Length)
            {

            }

            string adi = "Melek";
            int yas = 32;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;
            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;
            Console.WriteLine(kurs1);
            Console.WriteLine();
            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            Console.WriteLine();
            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " -> " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    //class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        Category category1 = new Category[] { ID = 1, Name = "Teknoloji", Active = true }
    //      Category category2 = new Category[] { ID = 2, Name = "Ev Yaşam", Active = true }
    //      Category[] categories = new Category[] { category1, category2 }
    //      foreach (kategori in categories)
    //        {
    //            Console.WiteLine(kategori);
    //        }
    //    }
    //}
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
    }
    class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}