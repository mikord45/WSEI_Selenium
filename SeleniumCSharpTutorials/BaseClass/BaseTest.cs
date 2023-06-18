using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumCSharpTutorials.BaseClass
{
    public class BaseTest
    {
       public IWebDriver driver ;
       public WebDriverWait wait;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement cookiesAcceptButton = driver.FindElement(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']"));
            try
            {
                cookiesAcceptButton.Click();
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(".//*[@data-testid='cookie-policy-manage-dialog-accept-button']")));
            }
            catch { }
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
