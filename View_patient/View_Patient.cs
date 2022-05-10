using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using mrsLibrary;

namespace View_patient
{
    internal class View_Patient:Library
    {
        public void view()
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            time(2000);
            Driver.Navigate().GoToUrl("https://demo.openmrs.org/openmrs/login.htm");
            Findxpath("//input[@id='username']").SendKeys("Admin");
            time(2000);
            Findxpath("//input[@id='password']").SendKeys("Admin123");
            time(2000);
            Findxpath("//li[@id='Inpatient Ward']").Click();
            time(2000);
            Findxpath("//input[@id='loginButton']").Click();
            time(2000);
            Findxpath("//a[@id='coreapps-activeVisitsHomepageLink-coreapps-activeVisitsHomepageLink-extension']").Click();
            time(2000);
            Findxpath("//input[@id='patient-search']").SendKeys("rtrgg kumar grfr");
            time(2000);
            Findxpath("//span[@class='recent-lozenge']").Click();
            time(2000);
            quit();

            


        }
    }
}
