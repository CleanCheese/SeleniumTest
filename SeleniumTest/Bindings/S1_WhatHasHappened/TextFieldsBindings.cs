using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings.S1_WhatHasHappened
{
    [Binding]
    public sealed class TextFieldsBindings
    {
        //Scope - When did the incident happen
        [When(@"I enter ""(.*)"" in field When did the incident happen")]
        public void WhenIEnterInFieldWhenDidTheIncidentHappen(string dateText)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.WhatHasHappened.WhenHappened.SetDate(dateText);

        }

        //Scope - where the incident happen
        [When(@"I enter ""(.*)"" in field Street address or place")]
        public void WhenIEnterInFieldStreetAddressOrPlace(string address)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.WhatHasHappened.WhereHappened.SetAddress(address);
        }

        [When(@"I enter ""(.*)"" in field Country")]
        public void WhenIEnterInFieldCountry(string country)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.WhatHasHappened.WhereHappened.SetCountry(country);
        }

        //Scope - Describe in details what has happened
        [When(@"I enter ""(.*)"" in field Describe in details what has happened")]
        public void WhenIEnterInFieldDescribeInDetailsWhatHasHappened(string description)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.WhatHasHappened.Description.SetDescription(description);
        }

    }
}
