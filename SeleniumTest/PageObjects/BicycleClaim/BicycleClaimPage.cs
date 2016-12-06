using OpenQA.Selenium;
using SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened;
using SeleniumTest.PageObjects.BicycleClaim.Sections.S2_LossConcerns;
using SeleniumTest.PageObjects.BicycleClaim.Sections.S3_PleaseGiveTHePersonalDetails;

namespace SeleniumTest.PageObjects.BicycleClaim
{
    public class BicycleClaimPage
    {
        private static IWebDriver _driver;

        public BicycleClaimPage(IWebDriver driver) { _driver = driver; }

        private By _header = By.TagName("h2");
        private By _iHaveFilledInAllTheNecessary = By.Id("toggleReviewed");
        private By _sendButton = By.Id("sendClaimButton");
        private By _abortButton = By.Id("cancelButton");
        
        public IWebElement Header
        {
            get
            {
                var element = _driver.FindElement(_header);
                return element;
            }
        }

        public IWebElement Checkbox
        {
            get
            {
                var element = _driver.FindElement(_iHaveFilledInAllTheNecessary);
                return element;
            }
        }

        public IWebElement SendButton
        {
            get
            {
                var element = _driver.FindElement(_sendButton);
                return element;
            }
        }

        public IWebElement AbortButton
        {
            get
            {
                var element = _driver.FindElement(_abortButton);
                return element;
            }
        }

        public void ClickIHaveFilledInCheckbox()
        {
            _driver.FindElement(_iHaveFilledInAllTheNecessary).Click();
        }

        public void Click(string button)
        {
            switch (button.ToLower())
            {
                case "send":
                    _driver.FindElement(_sendButton).Click();
                    break;
                case "abort":
                    _driver.FindElement(_abortButton).Click();
                    break;

            }
        }



        public WhatHasHappened WhatHasHappened => new WhatHasHappened(_driver);

        public LossConcerns LossConcerns => new LossConcerns(_driver);

        public PersonalDetails PersonalDetails => new PersonalDetails(_driver);
    }
}
