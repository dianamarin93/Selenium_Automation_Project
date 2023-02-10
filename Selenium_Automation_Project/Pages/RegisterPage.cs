using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_Automation_Project.Utils;

namespace Selenium_Automation_Project.Pages
{
    class RegisterPage : BasePage
    {
        public RegisterPage(WebDriver driver) : base(driver)
        {
        }

        private IWebElement firstNameField => driver.FindElement(By.CssSelector("#input-firstname"));
        private IWebElement lastNameField => driver.FindElement(By.CssSelector("#input-lastname"));
        private IWebElement emailField => driver.FindElement(By.CssSelector("#input-email"));
        private IWebElement phoneField => driver.FindElement(By.CssSelector("#input-telephone"));
        private IWebElement passwordField => driver.FindElement(By.CssSelector("#input-password"));
        private IWebElement confirmPasswordField => driver.FindElement(By.CssSelector("#input-confirm"));
        private IWebElement checkBox => driver.FindElement(By.XPath("//input[@type='checkbox']"));
        private IWebElement continueButton => driver.FindElement(By.XPath("//input[@value='Continue']"));
        private IWebElement successMessage => driver.FindElement(By.CssSelector("#content h1"));


        public void CompleteFields()
        {
            SetText(firstNameField, Constants.FirstName);
            SetText(lastNameField ,Constants.LastName);
            SetText(emailField, Constants.Email);
            SetText(phoneField ,Constants.Phone);
            SetText(passwordField, Constants.Password);
            SetText(confirmPasswordField, Constants.Password);
            Click(checkBox);
            Click(continueButton);
        }

        public string GetSuccessMessage()
            => GetText(successMessage);

    }
}
