using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumCSharpTutorials.Utilities
{
    public class BrowserUtility
    {
        private object lockObject = new object();
        public IWebDriver driver;

        public IWebDriver Init()
        {
            lock (lockObject)
            {
                driver = new ChromeDriver();
            }
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";

            return driver;
        }
    }
}
