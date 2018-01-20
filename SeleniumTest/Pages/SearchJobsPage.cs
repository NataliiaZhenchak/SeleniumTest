using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    class SearchJobsPage:BasePage
    {
        public string searchResult = "//span[@class='meta-item meta-result-count ng-binding'][text()[contains(.,'result')]]";

        public SearchJobsPage(IWebDriver driver)
            :base(driver)
        {
        }

        public IWebElement GetsearchResultElement()
        {
            var searchResultElement = CommonHelpers.FindWebElement(searchResult, 5);
            return searchResultElement;
        }

    }
}
