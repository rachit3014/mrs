using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using mrsLibrary;
namespace Register_paetint
{
    internal class Register_paeint :Library
    {
        public void regestration()
        {
            
            
            
            chrome("https://demo.openmrs.org/openmrs/login.htm");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            Findxpath("//input[@id='username']").SendKeys("Admin");
            time(2000);
            Findxpath("//input[@id='password']").SendKeys("Admin123");
            time(2000);
            Findxpath("//li[@id='Inpatient Ward']").Click();
            time(2000);
            Findxpath("//input[@id='loginButton']").Click();
            time(2000);
            Findxpath("//i[@class='icon-user']").Click();
            time(2000);
            Findxpath("//input[@name='givenName']").SendKeys("rtrgg");
            time(2000);
            Findxpath("//input[@name='middleName']").SendKeys("kumar");
            time(2000);
            Findxpath("//input[@name='familyName']").SendKeys("grfr");
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            Findxpath("//select[@id='gender-field']//option['M']").Click();
            time(2000);
            Findxpath("//button[@id='prev-button']").Click();
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            Findxpath("//input[@id='birthdateDay-field']").SendKeys("16");
            time(2000);
            Findxpath("//select[@id='birthdateMonth-field']//option[2]").Click();
            time(2000);
            Findxpath("//input[@id='birthdateYear-field']").SendKeys("2000");
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            Findxpath("//input[@id='address1']").SendKeys("njwndjh");
            time(2000);
            Findxpath("//input[@id='address2']").SendKeys("kmdwmnms");
            time(2000);
            Findxpath("//input[@id='cityVillage']").SendKeys("ndhii");
            time(2000);
            Findxpath("//input[@id='stateProvince']").SendKeys("kkdsm");
            time(2000);
            Findxpath("//input[@id='country']").SendKeys("INDIA");
            time(2000);
            Findxpath("//input[@id='postalCode']").SendKeys("189568");
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            Findxpath("//input[@name='phoneNumber']").SendKeys("7896541230");
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            Findxpath("//select[@id='relationship_type']//option[@data-val='Doctor']").Click();
            time(2000);
            Findxpath("//input[@placeholder='Person Name']").SendKeys("tyui");
            time(2000);
            Findxpath("//i[@class='icon-plus-sign edit-action']").Click();
            time(2000);
            Driver.FindElements(By.XPath("//i[@class='icon-minus-sign edit-action']"))[1].Click();
            time(2000);
            Findxpath("//button[@id='next-button']").Click();
            time(2000);
            quit();
        }
    }
}
