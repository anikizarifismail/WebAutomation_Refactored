using AmazonWebPageAutomation_Refactored.Source.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.PageActions
{
    public class AmazonUserPreferenceActions
    {
        readonly AmazonUserPreferencePageObject userPreferencePage;
        readonly IWebDriver _driver;

        public AmazonUserPreferenceActions(IWebDriver driver)
        {
            _driver = driver;
            userPreferencePage = new AmazonUserPreferencePageObject(_driver);
        }

        public void SetCurrencyPreference(string currencyPreference) 
            => userPreferencePage.CurrencyDropdown.SelectElementByText(currencyPreference);

        public void ClickSaveUserPreference()
        {
            userPreferencePage.PreferenceSaveButton.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(condition =>
            {
                try
                {
                      return !userPreferencePage.PreferenceSaveButton.IsDisplayed();
                  }
                  catch (NoSuchElementException) 
                  {
                      return true;
                  }
             });
        }
    }
}
