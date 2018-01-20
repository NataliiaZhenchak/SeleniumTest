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
        public string avanadeFeatureBlock = "//h1[@class='feature-title']";
      
        public HomePage(IWebDriver driver)
            :base(driver)
        {
        }

        public IWebElement GetAvanadeFeatureBlock()
        {
           var featureBlockElement = CommonHelpers.FindWebElement(avanadeFeatureBlock);
           return featureBlockElement; 
        }

        public IWebElement GetNavigationBarElement(string elementName)
        {
            var elementXPath = GetNavigationBarElementXPath(elementName);
            var navigationBarElement = CommonHelpers.FindWebElement(elementXPath);
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
            var dropDownElement = CommonHelpers.FindWebElement(elementXPath);
            return dropDownElement;
        }


    }
}
