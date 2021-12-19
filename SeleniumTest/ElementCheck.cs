using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    [TestClass]
    public class ElementCheck
    {
        [TestMethod]
        public void Check()
        {
            using (var Driver = new ChromeDriver())
            {
                Driver.Manage().Window.Maximize();
                Driver.Navigate().GoToUrl("http://localhost:8546/");

                var CheckoutLink = Driver.FindElement(By.Id("Checkout"));
                Assert.IsNotNull(CheckoutLink);

                CheckoutLink.Click();
                var content = Driver.PageSource.Contains("Total: 0");
                Assert.IsNotNull(content);
            }
        }
    }
}
