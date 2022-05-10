using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using mrsLibrary;
namespace Logout
{
    internal class Logout :Library
    {
        public void logout()
        {
            
            chrome("https://demo.openmrs.org/openmrs/login.htm");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Findxpath("//input[@id='username']").SendKeys("Admin");
            time(2000);
            Findxpath("//input[@id='password']").SendKeys("Admin123");
            time(2000);
            Findxpath("//li[@id='Inpatient Ward']").Click();
            time(2000);
            Findxpath("//input[@id='loginButton']").Click();
            time(3000);
            Findxpath("//li[@class='nav-item logout']").Click();
            time(2000);
            quit();
        }
    }
}
