using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using theInternetHeroApp.PageOptions;
using theInternetHeroApp.Steps;

namespace theInternetHeroKuapp.StepDefinitions
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        [Given(@"I launch the website ""(.*)""")]
        public void GivenILaunchTheWebsite(string url)
        {
            WebDriver.driver.Url = url;
            //WebDriver.Open(url);
        }

        [Given(@"The Page is Launched correctly")]
        public void GivenThePageIsLaunchedCorrectly()
        {
            //bool result = WebDriver.driver.Title == "The internet" ? true : false;
            //Assert.That(result, Is.True);
            bool result;

            if  (WebDriver.driver.Title == "The Internet")
                result = true;
            else
                result= false;
            Assert.That(result, Is.True);
        }

        [Then(@"The ""(.*)"" is visible")]
        public void ThenTheIsVisible(string checkText)
        {
            bool result;
            string text = HomePageObjects.HeaderText(WebDriver.driver).Text;
            result = text == checkText ? true : false;
            Assert.That(result, Is.True);
        }

        
        [Given(@"I have Cooldata with Cooldata, blue")]
        public void GivenIHaveCooldataWithCooldataBlue()
        {
            bool result;
            result = HomePageObjects.Button1(WebDriver.driver).Displayed;
            Assert.That(result, Is.True);
        }

        [Given(@"I have Cooldata with Cooldata, red")]
        public void GivenIHaveCooldataWithCooldataRed()
        {
            bool result;
            result = HomePageObjects.Button2(WebDriver.driver).Displayed;
            Assert.That(result, Is.True);
        }

        [Given(@"I have Cooldata with Cooldata, green")]
        public void GivenIHaveCooldataWithCooldataGreen()
        {
            bool result;
            result = HomePageObjects.Button3(WebDriver.driver).Displayed;
            Assert.That(result, Is.True);
        }



        [Then(@"The Buttons (.*)> are visible")]
        //[Obsolete]
        public void ThenTheButtonsAreVisible(string Name)
        {
            //ScenarioContext.Current.Pending();
            bool result;
            switch (Name)
            {
                case "blue":
                    result = HomePageObjects.Button1(WebDriver.driver).Displayed;
                    break;
                case "red":
                    result = HomePageObjects.Button2(WebDriver.driver).Displayed;
                    break;
                case "green":
                    result = HomePageObjects.Button3(WebDriver.driver).Displayed;
                    break;
                default:
                    result = false;
                    break;
            }

            Assert.That(result, Is.True);



        }

        [Then(@"The Button ""([^""]*)"" Is Visible")]
        public void ThenTheButtonIsVisible(string p0)
        {
            bool result;
            result = HomePageObjects.Button1(WebDriver.driver).Displayed;
            Assert.That(result, Is.True);
        }


        [Then(@"The table with rows is visible")]
        //[Obsolete]
        public void ThenTheTableWithRowsIsVisible()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"Click the first button bar")]
        public void ThenTheFirstButtonClick()
        {
            Checkbutton1.Click(WebDriver.driver, "bar", "2146e210-7cc7-013b-ebb7-4273e980571c");
        }
    }
}
