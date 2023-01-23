using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace theInternetHeroApp.Steps
{
    internal class Checkbutton1
    {

        //Click operation of button
        public static void Click(IWebDriver driver, string element, string elementtype)
        { 
            if (elementtype == "id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        
        }


    }
}
