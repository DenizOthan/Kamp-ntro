using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "python";
            kurs1.KursunEğitmeni = "engin demirog";
            kurs1.KursunİzlenmeOranı = 68;
            

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursunEğitmeni = "kerem";
            kurs2.KursunİzlenmeOranı = 56;
               

            //Console.WriteLine(kurs1.KursAdi+ " : " +kurs1.KursunEğitmeni);
            Kurs[] Kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var  kurs in Kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.KursunEğitmeni);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEğitmeni { get; set; }
        public int KursunİzlenmeOranı { get; set; }
    }
}
