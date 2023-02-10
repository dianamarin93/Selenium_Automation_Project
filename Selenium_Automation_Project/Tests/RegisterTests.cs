using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_Automation_Project.Pages;
using Selenium_Automation_Project.Utils;

namespace Selenium_Automation_Project.Tests
{
    class RegisterTests : BaseTest
    {
        [Test]
        public void RegisterTest()
        {
            registerPage.CompleteFields();

            string expectedMessage = Constants.RegisterSuccessMessage;

            string actualMessage = registerPage.GetSuccessMessage();

            Assert.AreEqual(expectedMessage, actualMessage, "The account creation success message is not correct!");
        }
    }
}
