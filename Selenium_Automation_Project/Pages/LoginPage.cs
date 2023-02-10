using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_Automation_Project.Utils;

namespace Selenium_Automation_Project.Pages
{
    class LoginPage : BasePage
    {
        public LoginPage(WebDriver driver) : base(driver)
        {
        }

        private IWebElement emailElement => driver.FindElement(By.XPath("//input[@id = 'input-email']"));
        private IWebElement passwordElement => driver.FindElement(By.XPath("//input[@id = 'input-password']"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//input[@type= 'submit']"));
        public void CompleteAccountElements()
        {
            SetText(emailElement,Constants.Email);
            SetText(passwordElement, Constants.Password);
            Click(loginButton);
        }

    }
}
