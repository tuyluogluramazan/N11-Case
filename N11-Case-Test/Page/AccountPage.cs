using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class AccountPage : BasePage
    {
        public AccountPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void NavigateToFavoriteList()
        {
            Click(AccountConstant.btnFavorites);
        }

        public void CheckProductExistOnFavorites(string productId)
        {
            IWebElement product = FindElement(By.Id(productId));
            Assert.IsTrue(product.GetAttribute("id").Equals(productId));
        }

        public void RemoveFromFavorites(string productId)
        {
            IWebElement product = FindElement(By.Id(productId));
            IWebElement deleteFromFavorites = product.FindElement(By.ClassName("deleteProFromFavorites"));
            deleteFromFavorites.Click();

            IWebElement message = FindElement(By.CssSelector(".lightBox .message"));
            Assert.AreEqual(message.Text, "Ürününüz listeden silindi.");
        }
    }
}
