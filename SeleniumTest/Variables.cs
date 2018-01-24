using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class Variables
    {
        public static IWebDriver driver;  
        
        public static IWebDriver Init()
        {
         
            switch (ConfigurationManager.AppSettings["browser"])
            {
               
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    break;
                case "FireFox":
                    driver = new FirefoxDriver();
                    break;
            }
            return driver;


        }
    }
}
