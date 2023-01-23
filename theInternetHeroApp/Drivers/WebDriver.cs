using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theInternetHeroKuapp
{
    public static class WebDriver
    {
        
        public static IWebDriver driver = new ChromeDriver(Environment.CurrentDirectory);
        public static void Open(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
