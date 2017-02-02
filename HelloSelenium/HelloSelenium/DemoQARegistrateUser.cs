using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSelenium
{
    public  class DemoQARegistrateUser
    {
        private IWebDriver driver;

        [SetUp]
        public void TestInitialize()
        {
            this.driver = new ChromeDriver();
        }

        [Test]
        public void RegistrateUserWithFullData()
        {
            driver.Navigate().GoToUrl("http://demoqa.com/");
            IWebElement registrationButton = driver.FindElement(By.XPath("//*[@id='menu - item - 374']/a"));
            registrationButton.Click();
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }
    }
}
