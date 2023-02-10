using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Selenium_Automation_Project.Utils;

namespace Selenium_Automation_Project.Pages
{
    class SearchPage : BasePage
    {
        public SearchPage(WebDriver driver) : base(driver)
        {
        }

        private IWebElement searchField => driver.FindElement(By.XPath("//input[@type='text']"));
        private IWebElement searchButton => driver.FindElement(By.CssSelector(".btn.btn-default.btn-lg"));


        public void SearchCategory()
        {
            SetText(searchField ,Categories.Tablets);
            searchField.SendKeys(Keys.Enter);
            //Click(searchButton);

        }
        
    }
}
