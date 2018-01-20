using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class CommonHelpers
    {

        public static IWebElement FindWebElement(string query)
        {

            return Variables.driver.FindElement(By.XPath(query)); 
        }

        public static IWebElement FindWebElement(string query, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(Variables.driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(By.XPath(query)));
            }

            return Variables.driver.FindElement(By.XPath(query));
        }

    }
}
