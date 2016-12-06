using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings.S1_WhatHasHappened
{
    [Binding]
    class ErrorLabelsBindings
    {
        [Then(@"all information is filled in What has happened section")]
        public void ThenAllInformationIsFilledInWhatHasHappenedSection()
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            Assert.IsFalse(page.WhatHasHappened.RequiredInformationMissing);
        }

    }
}
