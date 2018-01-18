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
        public HomePage(IWebDriver driver)
            :base(driver)
        {
        }

        public IWebElement YourCareerText
        {
            get { return driver.FindElement(By.XPath("//h1[@class='feature-title']")); }
            set { }
        }

        public IWebElement CareersButton
        {
            get { return driver.FindElement(By.XPath("//div[@id='main-navbar']//a[text()='Careers']")); }
            set { }
        }

        public IWebElement YourCareerButton
        {
            get { return driver.FindElement(By.XPath("//ul[@class='dropdown-menu second-dropdown lessthan10']/li/a[text()='Your Career']")); }
            set { }
        }


    }
}
