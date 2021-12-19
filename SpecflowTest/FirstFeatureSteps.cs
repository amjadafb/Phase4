using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecflowTest
{
    [TestClass]
    [Binding]
    public class FirstFeatureSteps
    {
        IWebDriver Driver = new ChromeDriver();
        [TestMethod]
        [Given(@"the Pizza Website home page")]
        public void GivenThePizzaWebsiteHomePage()
        {
            using (Driver)
            {
                Driver.Navigate().GoToUrl("http://localhost:8546/");
                Driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(2000);
            }
        }
        [TestMethod]
        [When(@"Click checkout Link")]
        public void WhenClickCheckoutLink()
        {
            using (Driver)
            {
                Driver.Navigate().GoToUrl("http://localhost:8546/");
                IWebElement CheckoutLink = Driver.FindElement(By.Id("Checkout"));
                Assert.IsNotNull(CheckoutLink);
                CheckoutLink.Click();
            }
        }
        [TestMethod]
        [Then(@"the result will be Total: 0")]
        public void ThenTheResultWillBeTotal()
        {
            using (Driver)
            {
                var content = Driver.PageSource.Contains("Total: 0");
                Assert.IsNotNull(content);
            }
        }
    }
}
