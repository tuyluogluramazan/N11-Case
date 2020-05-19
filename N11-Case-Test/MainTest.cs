using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace N11_Case_Test
{
    public class MainTest
    {
        IWebDriver driver;
        MainPage mainPage;
        LoginPage loginPage;
        SearchPage browsePage;
        AccountPage accountPage;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized");
            options.AddArguments("test-type");
            driver = new ChromeDriver(options);
            mainPage = new MainPage(driver);
            loginPage = new LoginPage(driver);
            browsePage = new SearchPage(driver);
            accountPage = new AccountPage(driver);
            driver.Navigate().GoToUrl("https://www.n11.com");

        }

        [Test]
        public void TestCase()
        {
            mainPage.ClickBlackButton();
            mainPage.ClickSignInButton();
            mainPage.ClickFbLoginButton();
            loginPage.SwitchToLastScreen();
            loginPage.Login("email", "pass");
            Thread.Sleep(4000);
            loginPage.SwitchToLastScreen();
            mainPage.SearchData("samsung");
            browsePage.CheckResultText("Samsung");
            browsePage.SwitchPage(2);
            string productId = browsePage.AddFavorites(3);
            mainPage.NavigateToFavorites();
            accountPage.NavigateToFavoriteList();
            accountPage.CheckProductExistOnFavorites(productId);
            accountPage.RemoveFromFavorites(productId);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
