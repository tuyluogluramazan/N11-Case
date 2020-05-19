using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace N11_Case_Test
{
    class LoginConstant
    {
        public static By txtEmail = By.Id("email");
        public static By txtPassword = By.Id("pass");
        public static By btnLogin = By.CssSelector("input[value='Giriş Yap']");


    }
}
