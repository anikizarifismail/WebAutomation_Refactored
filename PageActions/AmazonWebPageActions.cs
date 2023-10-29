using AmazonWebPageAutomation_Refactored.Source.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.PageActions
{
    public class AmazonWebPageActions
    {
        readonly AmazonWebPageObject amazonPage;

        public AmazonWebPageActions(IWebDriver driver) 
        {
            amazonPage = new AmazonWebPageObject(driver);
        }

        public void SetSearchField(string item) => amazonPage.SearchBar.SetSearchItem(item);
        public void ClickUserPreference() => amazonPage.PreferencePageButton.Click();
        public void ClickSearch() => amazonPage.SearchButton.Click();
    }
}
