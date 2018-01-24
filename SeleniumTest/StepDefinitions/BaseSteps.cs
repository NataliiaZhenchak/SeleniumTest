using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SeleniumTest.Variables;

namespace SeleniumTest
{
    
    [Binding]
    public class BasicSteps
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            Init();
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
