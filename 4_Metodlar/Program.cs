using System;


namespace Metodlar
{
	class Program
	{
		static void Main(string[] args)
		{
			Urun urun1 = new Urun();
			urun1.Adi = "Elma";
			urun1.Fiyati = 15;
			urun1.Aciklama = "Amasya elması";


			Urun urun2 = new Urun();
			urun2.Adi = "Karpuz";
			urun2.Fiyati = 17;
			urun2.Aciklama = "Adana karpuzu";


			Urun[] urunler = new Urun[] { urun1, urun2 };
			//C# ve java type-safe(tip güvenli) dilleridir
			foreach (Urun urun in urunler)
			{
				Console.WriteLine(urun.Adi);
				Console.WriteLine(urun.Fiyati);
				Console.WriteLine(urun.Aciklama);
				Console.WriteLine("----------------");
			}
			Console.WriteLine("-----------------------Metodlar-------------------");


			//instance -örnek
			//encapsulation


			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(urun1);
			sepetManager.Ekle(urun2);


			sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 50);
			sepetManager.Ekle2("Elma", "Yeşif Elma", 12, 10);
			sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 22);
		}
	}
}


//Don't repeat yourself - DRY - Clean Code - Best Practice 
