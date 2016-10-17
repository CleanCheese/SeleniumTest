using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S2_LossConcerns.Scopes
{
    public class Estimator
    {
        private static IWebElement _estimator;

        public Estimator(IWebElement scope)
        {
            _estimator = scope.FindElement(_estimatorLocator);
        }

        private static By _estimatorLocator = By.Id("repairCostsEstimatedOnDropDownSelect");
        
        public void Set(string estimation)
        {
            _estimator.SendKeys(estimation);
        }
    }
}
