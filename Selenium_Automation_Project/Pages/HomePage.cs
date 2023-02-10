using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_Automation_Project.Pages
{
    class HomePage : BasePage
    {
        public HomePage(WebDriver driver) : base(driver)
        {

        }
        private IWebElement myAccountButton => driver.FindElement(By.XPath("//i[@class='fa fa-user']"));
        private IWebElement registerButton => driver.FindElement(By.LinkText("Register"));
        private IWebElement loginBtn => driver.FindElement(By.LinkText("Login"));
        private IWebElement bannerElement => driver.FindElement(By.CssSelector("#menu"));



        public void GoToRegister()
        {
            Click(myAccountButton);
            Click(registerButton);
        }

        public void GoToLogin()
        {
            Click(myAccountButton);
            Click(loginBtn);
        }

        public string GetBannerColor()
           => bannerElement.GetCssValue("background-color");

    }
}
