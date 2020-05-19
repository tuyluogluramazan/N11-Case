using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class SearchPage : BasePage
    {
        public SearchPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void CheckResultText(string text)
        {
            IWebElement resultText = FindElement(SearchConstant.txtResult);
            Assert.IsTrue(resultText.Text.Contains(text));
        }

        public void SwitchPage(int pageNumber)
        {
            HoverElement(SearchConstant.PAGINATION);
            Click(SearchConstant.GetPageElement(pageNumber));
        }

        public string AddFavorites(int productNumber)
        {
            By product = SearchConstant.GetProductElement(productNumber);
            IWebElement productElement = FindElement(product);
            IWebElement followElement = productElement.FindElement(By.ClassName("followBtn"));

            HoverElement(followElement);
            followElement.Click();

            return productElement.FindElement(By.ClassName("columnContent")).GetAttribute("id");
        }
    }
}
