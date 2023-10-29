using AmazonWebPageAutomation_Refactored.Source.ElementTools;
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
    public class AmazonWebPageObject
    {
        readonly IWebDriver _driver;
        public ButtonElement SearchButton { get; }
        public ButtonElement PreferencePageButton { get;}
        public TextFieldElement SearchBar { get; }
        private const string _priceList = "//span[@class='a-price']", 
            _price = "//span[@class='a-offscreen']";

        [FindsBy(How = How.Id, Using = "twotabsearchtextbox")]
        readonly IWebElement? _searchBar;

        [FindsBy(How = How.Id, Using = "nav-search-submit-button")]
        readonly IWebElement? _searchButton;

        [FindsBy(How = How.XPath, Using = "//span[@class='icp-nav-flag icp-nav-flag-us icp-nav-flag-lop']//following-sibling::span[@class='nav-icon nav-arrow']")]
        readonly IWebElement? _preferencePageButton;


        public AmazonWebPageObject(IWebDriver driver) 
        { 
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            SearchButton = new ButtonElement(_searchButton!);
            SearchBar = new TextFieldElement(_searchBar!);
            PreferencePageButton = new ButtonElement(_preferencePageButton!);
        }

        //public void SetCurrencyPreference(string currency)
        //{
        //    OpenUserPreference();
        //    SelectElement dropdown = new SelectElement(_currencyDropdown);
        //    dropdown.SelectByText(currency);
        //    _savePreferenceButton.Click();

        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    wait.Until(condition =>
        //    {
        //        try
        //        {
        //            return !_savePreferenceButton.Displayed;
        //        }
        //        catch (NoSuchElementException) 
        //        {
        //            return true;
        //        }
        //    });
        //}

        //public void OpenUserPreference()
        //{
        //    _preferencePageButton.Click();
        //}

        //public void Search(string searchText)
        //{
        //    _searchBar.SendKeys(searchText);
        //    _searchButton.Click();
        //}

        //public float GetPriceOfItem(int index)
        //{
        //    string price = _driver.FindElement(By.XPath(_priceList + $"[{index}]" + _price)).GetAttribute("textContent");
        //    return float.Parse(price.Substring(1));
        //}
    }
}
