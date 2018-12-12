using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Task_dev_9_WebDriver
{
    class EntryPoint
    {
       public static void Main(string[] args)
        {
            try
            {
                var sms = new SmsVk();
                List<string> message = new List<string>();
                message = sms.Sms();
             
            }
           catch(Exception e)
            {
                Console.WriteLine("Error!" + e.Message);
            }

        }
    }
}
