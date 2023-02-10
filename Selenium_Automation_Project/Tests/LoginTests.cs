using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Automation_Project.Pages;
using Selenium_Automation_Project.Tests;
using Selenium_Automation_Project.Utils;

namespace Selenium_Automation_Project
{
    class LoginTests : BaseTest
    {
        [Test]
        public void LoginTest()
        {
            loginPage.CompleteAccountElements();
        }

        [Test]
        public void SearchCategoriesTest()
        {
            loginPage.CompleteAccountElements();
            searchPage.SearchCategory();
        }
    }
}