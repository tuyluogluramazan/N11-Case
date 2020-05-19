using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class SearchConstant
    {
        public static By txtResult = By.CssSelector("div.resultText");
        public static By PAGINATION = By.CssSelector("div.pagination");

        public static By GetPageElement(int pageNumber)
        {
            return By.CssSelector("div.pagination > a:nth-child(" + pageNumber + ")");
        }

        public static By GetProductElement(int productNumber)
        {
            return By.CssSelector("div#view > ul > li:nth-child(" + productNumber + ")");
        }
    }
}
