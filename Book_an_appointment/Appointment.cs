using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using mrsLibrary;
namespace Book_an_appointment
{
    internal class Appointment :Library
    {
        public void appointment()
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
            time(2000);
            Findxpath("//a[@id='coreapps-activeVisitsHomepageLink-coreapps-activeVisitsHomepageLink-extension']").Click();
            time(2000);
            Findxpath("//input[@id='patient-search']").SendKeys("rtrgg kumar grfr");
            time(2000);
            Findxpath("//span[@class='recent-lozenge']").Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,700)");
            time(2000);
            Findxpath("//i[@class='icon-share-alt edit-action']").Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,700)");
            time(2000);
            Findxpath("//div[@id='viewAllAppointmentTypes']").Click();
            time(2000);
            js.ExecuteScript("window.scrollBy(0,700)");
            Findxpath("//a[contains(text(),'Dermatology (New Patient)')]").Click();
            quit();

        }
    }
}
