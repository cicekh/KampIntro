using System;
using System.Collections.Generic;
using System.Text;

namespace OOP4
{
    class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplaması yapıldı");
        }
    }
}
