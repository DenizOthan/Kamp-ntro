using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            

            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            

            IKrediManager konutKrediManager = new KonutKrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());
            


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasıtKrediManager};
            basvuruManager.KrediOnBilgiliendirmesiYap(krediler);


        }
    }
}
