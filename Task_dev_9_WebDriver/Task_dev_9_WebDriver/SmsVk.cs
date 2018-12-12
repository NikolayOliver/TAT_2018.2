using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace Task_dev_9_WebDriver
{
    // Our go to vk
    // write login and password
    // and write new sms
    // Field: IWebDriver brouser, which is responsible to references in internet page
    class SmsVk
    {
        IWebDriver brouser = new OpenQA.Selenium.Chrome.ChromeDriver();
        public List<string> Sms()
        {
            // GO to VK
            brouser.Navigate().GoToUrl("https://vk.com");
            // Input Login
            IWebElement element = brouser.FindElement(By.XPath("//*[@id=\"index_email\"]"));
            element.SendKeys("375299903589");
            // Input password
            element = brouser.FindElement(By.XPath("//*[@id=\"index_pass\"]"));
            element.SendKeys(@"rjhjkd32");

            // click to come on page      
            element = brouser.FindElement(By.XPath("//*[@id=\"index_login_button\"]"));
            element.Click();

            List<string> messages = new List<string>();
            Thread.Sleep(5000);
            // click to message
            brouser.FindElement(By.XPath("//*[@id=\"l_msg\"]")).Click();
            Thread.Sleep(5000);
            // find unread message
            var mess = brouser.FindElement(By.XPath("//*[@id=\"im_dialogs\"]")).FindElements(By.ClassName("nim-dialog--unread _im_dialog_unread_ct")).ToList();
           
            foreach(var m in mess)
            {
                messages.Add(m.Text);
            }
            return messages;
       }
    }
}
