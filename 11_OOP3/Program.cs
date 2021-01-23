using System;
using System.Collections.Generic;

namespace _11_OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>
            {
                smsLoggerService,
                fileLoggerService
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggerServices) ;

            List<IKrediManager> krediler = new List<IKrediManager> {
                ihtiyacKrediManager,
                tasitKrediManager
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
