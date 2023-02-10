using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Selenium_Automation_Project.Utils;

namespace Selenium_Automation_Project.Tests
{
    class HomeTests : BaseTest
    {
        [Test]
        public void VerifyBannerColor()
        {
            Assert.AreEqual(Constants.RGBAColorBlue, homePage.GetBannerColor(), "The colors doesn't match!");
        }
    }
}
