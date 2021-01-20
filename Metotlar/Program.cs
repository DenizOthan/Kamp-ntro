using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "elma";
            
            double fiyati = 15;

            string aciklama = ("amasya elması");


            string[] meyveler = new string[] {"elma","karpuz" };
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (Urun urun in urunler)//urun=takma isim Urun=dizinin adı urunler=oluışturu-duğumuz yeni dizi
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------------------METOTLAR---------------");
                // instance-örnek
                //encapsulation = ayrı ayrı düzensiz bir yapıyı bir kapsülün içine sokarız.


                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Elms", "Yeşil Elm", 12,8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,9);



        }
    }
}


//dont repaet yourself-DRY-Clean Code-Best Practice
