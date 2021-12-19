using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            using (IWebDriver Driver = new ChromeDriver(@"C:\Users\aalbugami\source\repos\Phase4\NUnitTest\bin\Debug\netcoreapp2.2"))
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