﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharpTutorials.BaseClass;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Thread.Sleep(5000);
        }


    }
}
