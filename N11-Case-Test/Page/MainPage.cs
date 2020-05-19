using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver _driver) : base(_driver)
        {
        }

        public void ClickBlackButton()
        {
            Click(MainConstant.btnBlack);
        }
        public void ClickSignInButton()
        {
            Click(MainConstant.btnLogin);
        }
        public void ClickFbLoginButton()
        {
            Click(MainConstant.btnFbLogin);
        }


        public void SearchData(string searchText)
        {
            SendKeys(MainConstant.txtSearch, searchText);
            Click(MainConstant.btnSearch);
        }

        public void NavigateToFavorites()
        {
            HoverElement(MainConstant.MY_ACCOUNT);
            Click(MainConstant.MY_ACCOUNT_MENU_FAVORITES);
        }
    }
}
