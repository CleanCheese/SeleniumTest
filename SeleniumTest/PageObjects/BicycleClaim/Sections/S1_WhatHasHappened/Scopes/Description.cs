using System.Linq;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened.Scopes
{
    public class Description
    {
        private static IWebElement _description;

        public Description(IWebDriver driver)
        {
            var section = driver.FindElement(_sectionLocator);
            var scope = section.FindElements(By.TagName("ol")).ElementAt(6);
            _description = scope.FindElement(_descriptionLocator);
        }

        private By _sectionLocator = By.Id("eventForm_section");
        private By _descriptionLocator = By.Id("bicycleEventDescriptionTextAreaWithHeaderInput");
        
        public void SetDescription(string description)
        {
            _description.SendKeys(description);
        }
    }
}
