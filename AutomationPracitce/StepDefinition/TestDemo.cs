using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPracitce.StepDefinition
{
    class TestDemo
    {
        IWebDriver driver;


        [SetUp]
        public void setUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void test1()
        {
            Assert.Fail();
        }

       
        [TearDown]
        public void tearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
