﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OOP3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı.");
        }
    }
}
