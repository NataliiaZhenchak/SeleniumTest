using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumTest.CommonHelpers;

namespace SeleniumTest.Pages
{
    class CareersPage:BasePage
    {

        public string searchField = "//*[@id='searchboxfilter']";

        public string locationsDropDown = "//*[@id='countries']";

        public string searchButton = "//*[@id='jobsearchclick']";

        public CareersPage(IWebDriver driver)
            :base(driver)
        {
        }

        public IWebElement GetSearchField()
        {
            var searchFieldElement = FindWebElement(searchField, 30);
            return searchFieldElement;
        }
       

        public IWebElement GetLocationDropDown()
        {
            var dropDownElement = FindWebElement(locationsDropDown, 30);
            return dropDownElement;
        }

        private string GetCountryItemXPath(string countryName)
        {
            return "//a[@onclick='addLocation(this)'][text()='" + countryName+ "']";
        }

        public IWebElement GetCountryElement(string elementName)
        {
            var elementXPath = GetCountryItemXPath(elementName);
            var countryElement = FindWebElement(elementXPath, 30);
            return countryElement;
        }

        public IWebElement GetSearchButton()
        {
            var searchButtonElement = FindWebElement(searchButton, 30);
            return searchButtonElement;
        }

    }
}
