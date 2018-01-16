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
        private static IWebDriver driver;
        

        [BeforeScenario]
       
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            
         
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
        }

    }

   
        
     

        
    
}
