using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumTest.CommonHelpers;

namespace SeleniumTest.Pages
{
    class SearchJobsPage:BasePage
    {
        public string searchResult = "//span[@class='meta-item meta-result-count ng-binding'][text()[contains(.,'result')]]";

        public string allSearchResult = "//td[@class='job-category ng-binding']";

        public SearchJobsPage(IWebDriver driver)
            :base(driver)
        {
        }

        public IWebElement GetsearchResultElement()
        {
            var searchResultElement = FindWebElement(searchResult, 30);
            return searchResultElement;
        }

        public IWebElement GetAllSearchResultElement()
        {
            var allSearchResultElement = FindWebElement(allSearchResult, 30);
            return allSearchResultElement;
        }

        private string GetOfferItemXPath(string offerName)
        {
            return "//a[@ng-if='job.seo_title'][text()='" + offerName + "']";
        }

        public IWebElement GetOfferElement(string elementName)
        {
            var elementXPath = GetOfferItemXPath(elementName);
            var offerElement = FindWebElement(elementXPath, 30);
            return offerElement;
        }

    }
}
