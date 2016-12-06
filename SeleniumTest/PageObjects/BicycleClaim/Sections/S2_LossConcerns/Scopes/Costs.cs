using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S2_LossConcerns.Scopes
{
    public class Costs
    {
        private static IWebDriver _driver;
        private static IWebElement _section;
        private static IWebElement _scope;
        private static IWebElement _type;
        private static IWebElement _year;
        private static IWebElement _branAndModel;
        private static IWebElement _priceOfNewItem;
        private static IWebElement RepairCosts;
        private static IWebElement Save;
        private static IWebElement Cancel;

        public Costs(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
            _scope = _section.FindElement(_scopeLocator);
            _type = _scope.FindElement(_typeLocator);
            _year = _scope.FindElement(_yearLocator);
            _branAndModel = _scope.FindElement(_branAndModelLocator);
            _priceOfNewItem = _scope.FindElement(_priceOfNewItemLocator);
            RepairCosts = _scope.FindElement(_repairCostsLocator);
            Save = _scope.FindElement(_saveLocator);
            Cancel = _scope.FindElement(_cancelLocator);
        }

        private static By _sectionLocator = By.Id("bicycleCosts_section");
        private static By _scopeLocator = By.Id("bicycleCostListEditItemForm");
        private static By _typeLocator = By.Id("bicycleTypeDropDownSelect");
        private static By _yearLocator = By.Id("yearOfPurchaseDropDownSelect");
        private static By _branAndModelLocator = By.Id("brandAndModelInputText");
        private static By _priceOfNewItemLocator = By.Id("newItemCostInputMoney");
        private static By _repairCostsLocator = By.Id("repairCostsInputMoney");
        private static By _saveLocator = By.Id("savebicycleCostList");
        private static By _cancelLocator = By.Id("resetbicycleCostList");
        
        public void SetType(string type)
        {
            _type.SendKeys(type);
        }

        public void SetYear(string yaer)
        {
            _year.SendKeys(yaer);
        }

        public void SetBrandANdModel(string brandAndModel)
        {
            _branAndModel.SendKeys(brandAndModel);
        }

        public void SetPrice(string price)
        {
            _priceOfNewItem.SendKeys(price);
        }

        public void SetRepairCost(string cost)
        {
            RepairCosts.SendKeys(cost);
        }

        public Estimator Estimator => new Estimator(_scope);

        public void Click(string button)
        {
            switch (button.ToLower())
            {
                case "save": Save.Click(); break;
                case "cancel": Cancel.Click(); break;
            }
        }
    }
}
