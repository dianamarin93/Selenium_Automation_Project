using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V107.WebAudio;

namespace Selenium_Automation_Project.Utils
{
    class Constants
    {
        private static string date = DateTime.Now.ToLongTimeString();

        private static string GenerateRandomDate()
        {
            if (date.EndsWith(" PM"))
            {
                date = date.Replace(" PM", "");
            }
            else if (date.EndsWith(" AM"))
            {
                date = date.Replace(" AM", "");
            }

            return date.Replace(":", "");
        }

        public static readonly string FirstName = "Diana";
        public static readonly string LastName = "Marin";
        public static readonly string Email = "diana" + GenerateRandomDate() + "@email.com";
        public static readonly string Phone = "1234567890";
        public static readonly string Password = "test123*";
        public static readonly string RegisterSuccessMessage = "Your Account Has Been Created!";

        // Css Colors
        public static readonly string RGBAColorBlue = "rgba(34, 154, 200, 1)";

    }
}

