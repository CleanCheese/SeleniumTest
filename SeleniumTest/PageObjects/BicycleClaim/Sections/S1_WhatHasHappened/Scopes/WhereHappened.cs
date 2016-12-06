using System.Linq;
using OpenQA.Selenium;

namespace SeleniumTest.PageObjects.BicycleClaim.Sections.S1_WhatHasHappened.Scopes
{
    public class WhereHappened
    {
        private static IWebElement _scope;
        private static IWebElement _countrySelected;
        private static IWebElement _country;
        private static IWebElement _address;


        public WhereHappened(IWebDriver driver)
        {
            var section = driver.FindElement(_sectionLocator);
            _scope = section.FindElements(By.TagName("ol")).ElementAt(4);
            _countrySelected = _scope.FindElement(_countrySelectedLocator);
            _country = _scope.FindElement(_countryLocator);
            _address = _scope.FindElement(_addressLocator);
        }

        private static By _sectionLocator = By.Id("eventForm_section");
        private static By _countrySelectedLocator = By.Id("eventCountryDropDown");
        private static By _countryLocator = By.Id("eventCountryDropDownSelect");
        private static By _cityLocator = By.Id("eventCityDropDownSelect");
        private static By _addressLocator = By.Id("bicycleStolenStreetTextInput");

        private IWebElement City
        {
            get { return _scope.FindElement(_cityLocator); }
        }

        public void SetCountry(string country)
        {
            _country.SendKeys(country);
        }

        public string GetCountry()
        {
            return _countrySelected.GetAttribute("Text");
        }

        public void SetCity(string keys)
        {
            City.SendKeys(keys);
        }

        public string GetCity()
        {
            return City.Text;
        }

        public void SetAddress(string keys)
        {
            _address.SendKeys(keys);
        }

        public string GetAddress()
        {
            return _address.Text;
        }
    }
}
