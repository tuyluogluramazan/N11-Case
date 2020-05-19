    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace N11_Case_Test
{
    class BasePage
    {
        IWebDriver driver;
        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }


        public void Click(By element)
        {
            FindElement(element).Click();
        }


        public void SendKeys(By element, string text)
        {
            FindElement(element).SendKeys(text);
        }


        public IWebElement FindElement(By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            return wait.Until(ExpectedConditions.ElementIsVisible(element));
        }


        public void HoverElement(By by)
        {
            IWebElement element = FindElement(by);

            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void HoverElement(IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
    }
}
