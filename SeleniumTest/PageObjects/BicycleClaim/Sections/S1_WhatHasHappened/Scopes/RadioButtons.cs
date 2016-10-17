using System;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened.Scopes
{
    public class RadioButtons
    {
        private static IWebDriver _driver;
        private static IWebElement _section;

        public RadioButtons(IWebDriver driver)
        {
            _driver = driver;
            _section = _driver.FindElement(_sectionLocator);
        }

        private static By _sectionLocator = By.Id("eventForm_section");
        private static By _bicycleStolenRbLocator = By.Id("eventTypeStolen");
        private static By _bicycleVandalizedRbLocator = By.Id("eventTypeVandalized");
        private static By _bicycleBrokenRbLocator = By.Id("eventTypeBroken");
        private static By _bicycleDamagedRbLocator = By.Id("eventTypeDamaged");

        public void Click(string button)
        {
            _section.FindElement(GetLocator(button)).Click();
        }

        public bool IsSelected(string button)
        {
            return Selected(GetLocator(button));
        }

        private bool Selected(By locator)
        {

            var selected = false;
            var elementClass = _driver.FindElement(locator).FindElement(By.XPath("input")).GetAttribute("Class");
            if (elementClass.Contains("ng-valid-parse")) selected = true;

            return selected;
        }

        private By GetLocator(string button)
        {
            switch (button)
            {
                case "Bicycle or parts of it have been stolen": return _bicycleStolenRbLocator;
                case "Bicycle has been vandalized": return _bicycleVandalizedRbLocator;
                case "Bicycle has got broken": return _bicycleBrokenRbLocator;
                case "Bicycle has been damaged in a collision with a motor vehicle": return _bicycleDamagedRbLocator;
                default: throw new NotImplementedException("'" + button + "' button is not implemented in the code, contact responsible developer!");
            }
        }
    }
}
