using System;
using System.Collections.Generic;

namespace OOP4
{
    class Program
    {
        //SOLID - O: Open Closed Principle
        // Sisteme yeni bir özellik eklendiğinde sistemin çalışması bozulmaz.

        //interfaceler de o interface i implemente eden classın referansını tutabiliyor. interface onu implemente eden classın referansını tutabilir.

        //interface leri birbirlerinin alternatifi 
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>() { new DatabaseLoggerService(),new SmsLoggerService() });

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
