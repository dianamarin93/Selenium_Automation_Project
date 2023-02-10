using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Selenium_Automation_Project.Pages
{
    public class BasePage
    {
        protected WebDriver driver;

        public BasePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public void Click(IWebElement el)
        {
            el.Click();
        }

        public void SetText(IWebElement el, string text)
        {
            el.SendKeys(text);
        }

        public string GetText(IWebElement el)
            => el.Text;

        public void WaitForSeconds(int seconds)
        {
            seconds *= 1000;
            Thread.Sleep(seconds);
        }
    }
}
