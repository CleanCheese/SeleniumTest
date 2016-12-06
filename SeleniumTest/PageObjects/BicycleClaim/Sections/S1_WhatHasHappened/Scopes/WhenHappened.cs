using System.Linq;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened.Scopes
{
    public class WhenHappened
    {
        private static IWebElement _date;

        public WhenHappened(IWebDriver driver)
        {
            var section = driver.FindElement(_sectionLocator);
            var scope = section.FindElements(By.TagName("ol")).ElementAt(2);
            _date = scope.FindElement(_dateLocator);
        }

        private static By _sectionLocator = By.Id("eventForm_section");
        private static By _dateLocator = By.Name("bicycleStolenDateWithHeaderInput");
        
        public void SetDate(string date)
        {
            _date.SendKeys(date);
            _date.SendKeys(Keys.Enter);
        }
    }
}
