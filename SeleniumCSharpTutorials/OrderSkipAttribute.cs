// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharpTutorials.BaseClass;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    { 

        [Test,Order(2),Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }


        [Test,Order(1),Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test,Order(0),Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://www.facebook.com/";
            //this lines are commented out, because Facebook page looks completely different in IE
            //IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            //emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
