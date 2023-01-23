using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace theInternetHeroApp.PageOptions
{
    public static class HomePageObjects
    {
        public static IWebElement HeaderText(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//*[@id='content']/div/h3"));
        }

        public static IWebElement Button1(IWebDriver driver)
        {
            return (IWebElement)driver.FindElements(By.XPath("//*[contains (@class, 'button')]"));
        }

        public static IWebElement Button2(IWebDriver driver)
        {

            return (IWebElement)driver.FindElements(By.XPath("//*[contains (@class, 'button alert')]"));
        }

        public static IWebElement Button3(IWebDriver driver)
        {
            return (IWebElement)driver.FindElements(By.XPath("//button[contains (@class, 'button success')]"));
        }

        public static IWebElement WebTable(IWebDriver driver)
        {
            return driver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table"));
        }

        //
    }
}
