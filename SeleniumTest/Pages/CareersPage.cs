using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var searchFieldElement = CommonHelpers.FindWebElement(searchField);
            return searchFieldElement;
        }
       

        public IWebElement GetLocationDropDown()
        {
            var dropDownElement = CommonHelpers.FindWebElement(locationsDropDown);
            return dropDownElement;
        }


        private string GetCountryItemXPath(string countryName)
        {
            return "//a[@onclick='addLocation(this)'][text()='" + countryName+ "']";
        }

        public IWebElement GetCountryElement(string elementName)
        {
            var elementXPath = GetCountryItemXPath(elementName);
            var countryElement = CommonHelpers.FindWebElement(elementXPath);
            return countryElement;
        }

        public IWebElement GetSearchButton()
        {
            var searchButtonElement = CommonHelpers.FindWebElement(searchButton);
            return searchButtonElement;
        }




    }
}
