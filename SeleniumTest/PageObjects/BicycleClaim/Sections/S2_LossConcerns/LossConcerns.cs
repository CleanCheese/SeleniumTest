using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim.Sections.S2_LossConcerns.Scopes;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S2_LossConcerns
{
    public class LossConcerns
    {
        private static IWebDriver _driver;
        private static IWebElement _section;

        public LossConcerns(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
        }

        private By _sectionLocator = By.Id("bicycleCosts_section");
        private By _headerLocator = By.XPath("");

        public IWebElement Header => _section.FindElement(_headerLocator);
        
        public Costs Costs => new Costs(_driver);

        public Owner Owner => new Owner(_driver);
    }
}
