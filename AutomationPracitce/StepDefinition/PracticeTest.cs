using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;

namespace AutomationPracitce.StepDefinition
{
    class PracticeTest
    {
        IWebDriver driver;

        private readonly string url = "http://automationpractice.com/index.php";
        private readonly string loginLink = "//a[@title='Log in to your customer account']";
        private readonly string pageHeadingElement = "//h1[text()='Authentication']";


        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void RegistrationTest()
        {
            driver.FindElement(By.XPath(loginLink)).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement pageHeading = driver.FindElement(By.XPath(pageHeadingElement));
            Assert.AreEqual("AUTHENTICATION", pageHeading.Text);
            
        }

        [TearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
