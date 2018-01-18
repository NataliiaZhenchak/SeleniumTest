using OpenQA.Selenium;
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
    }
}
