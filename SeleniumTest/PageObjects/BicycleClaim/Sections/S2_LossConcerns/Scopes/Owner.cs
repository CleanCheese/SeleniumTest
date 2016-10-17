using System.Linq;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S2_LossConcerns.Scopes
{
    public class Owner
    {

        public Owner(IWebDriver driver)
        {
            var section = driver.FindElement(_sectionLocator);
            var scope = section.FindElements(By.TagName("ol")).ElementAt(6);
        }

        private By _sectionLocator = By.Id("bicycleCosts_section");
        
    }
}
