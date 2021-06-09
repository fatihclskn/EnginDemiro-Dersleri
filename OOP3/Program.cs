using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager
            IhtiyaçKrediManager ihtiyaçKrediManager = new IhtiyaçKrediManager();
            
            //IKrediManager
            TaşıtKrediManager taşıtKrediManager = new TaşıtKrediManager();

            //IKrediManager
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(taşıtKrediManager, fileloggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager , konutKrediManager , taşıtKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            Console.ReadLine();
        }
    }
}
