using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.Source.Page
{
    public class AmazonWebPage
    {
        readonly IWebDriver _driver;
        private const string _domainUrl = "https://www.amazon.com/", _priceList = "//span[@class='a-price']", 
            _price = "//span[@class='a-offscreen']";

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        IWebElement _searchBar;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        IWebElement _searchButton;

        [FindsBy(How = How.XPath, Using = "//span[@class='icp-nav-flag icp-nav-flag-us icp-nav-flag-lop']//following-sibling::span[@class='nav-icon nav-arrow']")]
        IWebElement _preferencePageButton;

        [FindsBy(How = How.Id, Using = "icp-currency-dropdown")]
        IWebElement _currencyDropdown;

        [FindsBy(How = How.Id, Using = "icp-save-button")]
        IWebElement _savePreferenceButton;

        public AmazonWebPage(IWebDriver driver) 
        { 
            _driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(_domainUrl);
            PageFactory.InitElements(_driver, this);
        }

        public void SetCurrencyPreference(string currency)
        {
            OpenUserPreference();
            SelectElement dropdown = new SelectElement(_currencyDropdown);
            dropdown.SelectByText(currency);
            _savePreferenceButton.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(condition =>
            {
                try
                {
                    return !_savePreferenceButton.Displayed;
                }
                catch (NoSuchElementException) 
                {
                    return true;
                }
            });
        }

        public void OpenUserPreference()
        {
            _preferencePageButton.Click();
        }

        public void Search(string searchText)
        {
            _searchBar.SendKeys(searchText);
            _searchButton.Click();
        }

        public float GetPriceOfItem(int index)
        {
            string price = _driver.FindElement(By.XPath(_priceList + $"[{index}]" + _price)).GetAttribute("textContent");
            return float.Parse(price.Substring(1));
        }
    }
}
