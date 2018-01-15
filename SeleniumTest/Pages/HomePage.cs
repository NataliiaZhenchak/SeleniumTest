using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class HomePage: BasePage

    {
        //public IWebDriver driver;
        public HomePage(IWebDriver driver)
            :base(driver)
        {
        }

        public IWebElement CareersButton
        {
            get { return driver.FindElement(By.XPath("//div[@id='main-navbar']//a[text()='Careers']")); }
            set { }
        }



    }
}
