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

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            IWebElement createAccountButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@data-testid='open-registration-form-button']")));
            createAccountButton.Click();
            IWebElement monthDropdownList = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='month']")));
            SelectElement element = new SelectElement(monthDropdownList);
            // differences in values, there is no "month" value in dropdown
            element.SelectByIndex(0);
            element.SelectByText("mar"); // different text in each different language
            element.SelectByValue("6");
        }

        [Test,Category("Regression Testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test,Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }


    }
}
