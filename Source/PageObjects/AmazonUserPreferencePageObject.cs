using AmazonWebPageAutomation_Refactored.Source.ElementTools;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.Source.PageObjects
{
    public class AmazonUserPreferencePageObject
    {
        readonly IWebDriver _driver;
        public DropdownElement CurrencyDropdown { get; }
        [FindsBy(How = How.Id, Using = "icp-currency-dropdown")]
        readonly IWebElement? _currencyDropdown;

        public ButtonElement PreferenceSaveButton { get; }
        [FindsBy(How = How.Id, Using = "icp-save-button")]
        readonly IWebElement? _preferenceSaveButton;

        public AmazonUserPreferencePageObject(IWebDriver driver) 
        { 
            _driver = driver;
            PageFactory.InitElements(_driver, this);
            CurrencyDropdown = new DropdownElement(_currencyDropdown!);
            PreferenceSaveButton = new ButtonElement(_preferenceSaveButton!);
        }
    }
}
