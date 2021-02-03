using System;
using System.Collections.Generic;
using System.Text;


namespace Oop3
{
    class BasvuruManager
    {   //method injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            //Başvuran bilgileri değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgiliendirmesiYap(List<IKrediManager> krediler)
        {
            foreach( var kredi in krediler)
            {
                kredi.Hesapla();
            }   
        }
    }
}
