using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Automation_Project.Pages;

namespace Selenium_Automation_Project.Tests
{
    class BaseTest
    {
        protected WebDriver driver;
        protected HomePage homePage;
        protected LoginPage loginPage;
        protected SearchPage searchPage;
        protected RegisterPage registerPage;
        protected BasePage basePage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://www.tutorialsninja.com/demo/");
            driver.Manage().Window.Maximize();

            homePage = new HomePage(driver);
            homePage.GoToLogin();

            loginPage = new LoginPage(driver);
            searchPage = new SearchPage(driver);
            basePage = new BasePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            basePage.WaitForSeconds(2);
            //driver.Quit();
        }
    }
}
