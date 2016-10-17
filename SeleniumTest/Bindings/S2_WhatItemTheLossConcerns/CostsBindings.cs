using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings.S2_WhatItemTheLossConcerns
{
    [Binding]
    public sealed class CostsBindings
    {
        //Scope - What are the costs
        [When(@"I enter ""(.*)"" in field Bicycle")]
        public void WhenIEnterInFieldBicycle(string itemType)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.SetType(itemType);
        }

        [When(@"I enter ""(.*)"" in field Year of purchase")]
        public void WhenIEnterInFieldYearOfPurchase(string year)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.SetYear(year);
        }

        [When(@"I enter ""(.*)"" in field Brand and model")]
        public void WhenIEnterInFieldBrandAndModel(string brandAndModel)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.SetBrandANdModel(brandAndModel);
        }

        [When(@"I enter ""(.*)"" in field The price of an new item")]
        public void WhenIEnterInFieldThePriceOfAnNewItem(string price)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.SetPrice(price);
        }

        [When(@"I enter ""(.*)"" in field Repair costs")]
        public void WhenIEnterInFieldRepairCosts(string costs)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.SetRepairCost(costs);
        }

        [When(@"I enter ""(.*)"" in field Repair estimation is based on")]
        public void WhenIEnterInFieldRepairEstimationIsBasedOn(string estimator)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.Estimator.Set(estimator);
        }

        [When(@"I click ""(.*)"" button")]
        public void WhenIClickButton(string button)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.LossConcerns.Costs.Click(button);
        }
    }
}
