using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaimSections;

namespace SeleniumTest.PageObjects
{
    public class BicycleClaimPage
    {
        private static IWebDriver _driver;

        public BicycleClaimPage(IWebDriver driver) { _driver = driver; }

        private By _header = By.TagName("h2");
        private By _whatItemConsernSection = By.Id("bicycleCosts_section");
        private By _pleaseGiveDetailsSection = By.Id("bicycleNotifier_section");

        public IWebElement Header
        {
            get
            {
                var element = _driver.FindElement(_header);
                return element;
            }
        }



        public WhatHasHappenedSection WhatHasHappenedSection
        {
            get
            {
                //var element = _driver.FindElement(_whatHasHappenedSection);
                return new WhatHasHappenedSection(_driver);
            }
        }


    }
}
