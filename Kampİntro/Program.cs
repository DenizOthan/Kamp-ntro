using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {   //type safety - tip güvenliği
            //do not repeat - kendini tekrarlma
            //değer tutucu , alias
            string kategoriEtiketi = "kategori";
            int ogrenciSayısı = 320000000;
            double faizOranı = 1.45;
            bool SistemeGirişiYapmısMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonun Göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu Göster.");
            }
            else
            {
                Console.WriteLine  ("Değişmedi butonu");
            }
            if (SistemeGirişiYapmısMı== true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
            





        }
    }
}
