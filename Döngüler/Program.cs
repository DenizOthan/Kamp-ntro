using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "yazılım kampı";
            string kurs2 = "programlama kursu";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs = "c++";

            //array-dizi

            string[] kurslar = new string[] { "yazılım kampı" , "programlama kursu" , "java","python","c++" };
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ.");


            foreach (string Kurs in kurslar)   //foreach dizileri  KOLAYCA tek tek dolaşır.
            {
                Console.WriteLine(Kurs);
            }
            Console.WriteLine("Sayfa sonu--footer");
        }
    }
}
