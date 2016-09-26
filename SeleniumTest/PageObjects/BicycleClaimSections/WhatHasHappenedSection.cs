using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaimSections
{
    public class WhatHasHappenedSection
    {
        private static IWebDriver _driver;
        private static IWebElement _section;

        public WhatHasHappenedSection(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
        }

        private By _sectionLocator = By.Id("eventForm_section");
        private By _headerLocator = By.ClassName("ecmt-grid-cell ecmt-width-1of2 accordion-header");


        public IWebElement Header
        {
            get
            {
                var element = _section.FindElement(_headerLocator);
                return element;
            }
        }
    }
}
