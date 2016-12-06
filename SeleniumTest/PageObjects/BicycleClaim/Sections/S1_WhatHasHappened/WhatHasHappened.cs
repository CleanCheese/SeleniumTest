using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened.Scopes;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened
{
    public class WhatHasHappened
    {
        private static IWebDriver _driver;
        private static IWebElement _section;
        private static IWebElement _requiredInformationMissing;

        public WhatHasHappened(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
        }

        private By _sectionLocator = By.Id("eventForm_section");
        private By _headerLocator = By.XPath("//*[contains(@class,'ecmt-details-summary iconbefore icon-arrowdown')]");
        private By _requiredInformationMissingLocator = By.Id("eventForm_requiredMessage");

        public IWebElement Header => _section.FindElement(_headerLocator);
        public bool RequiredInformationMissing => _section.FindElement(_requiredInformationMissingLocator).Selected;

        public RadioButtons RadioButtons => new RadioButtons(_driver);

        public WhenHappened WhenHappened => new WhenHappened(_driver);

        public WhereHappened WhereHappened => new WhereHappened(_driver);

        public Description Description => new Description(_driver);
        
    }
}
