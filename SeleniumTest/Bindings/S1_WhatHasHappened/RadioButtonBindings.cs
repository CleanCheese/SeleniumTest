using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim;
using TechTalk.SpecFlow;

namespace SeleniumTest.Bindings.S1_WhatHasHappened
{
    [Binding]
    public sealed class RadioButtonBindings
    {
        //Scope - What happened to your bicycle - Radio buttons
        [When(@"I click ""(.*)"" radio button")]
        public void WhenIClickElement(string button)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            page.WhatHasHappened.RadioButtons.Click(button);
        }

        [Then(@"""(.*)"" radio button is selected")]
        public void ThenRadioButtonIsSelected(string button)
        {
            var selected = IsRadioButtonSelected(button);
            Assert.IsTrue(selected);

        }

        [Then(@"""(.*)"" radio button is unselected")]
        public void ThenRadioButtonIsUnselected(string button)
        {
            var selected = IsRadioButtonSelected(button);
            Assert.IsFalse(selected);

        }

        private bool IsRadioButtonSelected(string button)
        {
            var driver = ScenarioContext.Current.Get<IWebDriver>();
            var page = new BicycleClaimPage(driver);
            var selected = page.WhatHasHappened.RadioButtons.IsSelected(button);
            Debug.WriteLine("-- '"  + button + "' selected = " + selected);
            return selected;

        }

    }
}
