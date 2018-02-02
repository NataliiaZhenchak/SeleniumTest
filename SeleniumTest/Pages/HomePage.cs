using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SeleniumTest.CommonHelpers;

namespace SeleniumTest.Pages
{
    public class HomePage: BasePage
    {
        public string avanadeFeatureBlock = "//h1[@class='feature-title']";

        public HomePage(IWebDriver driver)
            :base(driver)
        {
        }
        public IWebElement GetAvanadeFeatureBlock()
        {
           var featureBlockElement = FindWebElement(avanadeFeatureBlock, 30);
           return featureBlockElement; 
        }

        public IWebElement GetNavigationBarElement(string elementName)
        {
            var elementXPath = GetNavigationBarElementXPath(elementName);
            var navigationBarElement = FindWebElement(elementXPath);
            return navigationBarElement;
        }
        private string GetNavigationBarElementXPath(string elementName)
        {
            return "//div[@id='main-navbar']//a[text()='" + elementName + "']";
        }
        private string GetDropDownItemXPath(string itemName)
        {
            return "//ul[@class='dropdown-menu second-dropdown lessthan10']/li/a[text()='" + itemName + "']";
        }
        public IWebElement GetDropDownElement(string elementName)
        {
            var elementXPath = GetDropDownItemXPath(elementName);
            var dropDownElement = FindWebElement(elementXPath, 30);
            return dropDownElement;
        }

    }
}
