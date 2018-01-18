using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumTest
{
    
    [Binding]
    public class BasicSteps
    {
        IWebDriver driver = Variables.driver;
        

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.infusion.com/";
        }

        [AfterScenario]
        public void AfterScenario()
        {
           // driver.Close();
        }

    }

   
        
     

        
    
}
