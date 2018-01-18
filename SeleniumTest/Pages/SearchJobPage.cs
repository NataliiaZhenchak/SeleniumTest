using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    class SearchJobPage:BasePage
    {
        public SearchJobPage(IWebDriver driver)
            :base(driver)
        {
        }

        public string searchField = "//*[@id='searchbox']";

        public SearchJobPage SelectCountry()
        {
            CommonHelpers.FindWebElement(searchField).Click();
            return this;
        }

        public IWebElement SearchField
        {
            get { return driver.FindElement(By.Id("searchbox")); }
            set { }
        }

        public IWebElement LocationDropDown
        {
            get { return driver.FindElement(By.Id("countries")); }
            set { }
        }

        public IWebElement CountryName
        {
            get { return driver.FindElement(By.Id("searchboxfilter")); }
            set { }
        }

        public SearchJobPage SelectLocationDropDown()
        {
            LocationDropDown.Click();
            return this;
        }

        

    }
}
