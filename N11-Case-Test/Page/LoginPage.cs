using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class LoginPage : BasePage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
        public void SwitchToLastScreen()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
        public void Login(string email, string password)
        {
            SendKeys(LoginConstant.txtEmail, email);
            SendKeys(LoginConstant.txtPassword, password);
            Click(LoginConstant.btnLogin);

        }

    }
}
