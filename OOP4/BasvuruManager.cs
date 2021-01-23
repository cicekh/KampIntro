using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class BasvuruManager
    {
        // Method injection yapıyoruz. Yani dependency injection yapıyoruz bir nevi.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //Hangi krediyi gönderirsem o kredinin Hesapla() metodu çalışır. IKrediManager çünkü her Kredi türünün referansını tutabiliyor. Böylece hangi krediyi göndereceksek IKrediManager instance ile new leriz.
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
