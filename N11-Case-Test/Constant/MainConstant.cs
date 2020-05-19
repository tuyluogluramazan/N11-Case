using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class MainConstant
    {
        public static By btnBlack = By.ClassName("btnBlack");
        public static By btnLogin = By.ClassName("btnSignIn");
        public static By btnFbLogin = By.CssSelector("#loginContainer > div > div.leftBlock > div > div.facebook_large.medium.facebookBtn.btnLogin");

        public static By txtSearch = By.Id("searchData");
        public static By btnSearch = By.CssSelector("a.searchBtn");
        public static By MY_ACCOUNT = By.ClassName("myAccount");
        public static By MY_ACCOUNT_MENU_FAVORITES = By.CssSelector(".myAccountMenu a:nth-child(2)");
    }
}
