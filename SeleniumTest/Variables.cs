using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
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


        public static void Init()
        {
            var browser = ConfigurationManager.AppSettings["browser"];

            if (browser == "Chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "IE")
            {
                
                InternetExplorerOptions options = new InternetExplorerOptions();
                options.EnableNativeEvents = false;
                options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                options.IgnoreZoomLevel = true;
                options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                options.EnablePersistentHover = true;
                driver = new InternetExplorerDriver(options);
            }
            else if (browser == "FireFox")
            {
                driver = new FirefoxDriver();
            }
            else
            {
                driver = new ChromeDriver();
            }

        }
    }
}
