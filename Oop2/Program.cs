using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12456";
            musteri1.Adi = "deniz";
            musteri1.Soyadi = "othan";
            musteri1.TcNo = " 11546236";


            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "214588";
            musteri2.SirketAdi = " kodlama.io";
            musteri2.VergiNo = "125487956";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);



            //gercek müşteri - tüzel müşteri birbirlerinni yerine kullanılmaz.
            //SOLıd

        }
    }
}
