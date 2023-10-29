using AmazonWebPageAutomation_Refactored.PageActions;
using AmazonWebPageAutomation_Refactored.Source.Page;
using AmazonWebPageAutomation_Refactored.Source.WebDriver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AmazonWebPageAutomation_Refactored.StepDefinitions
{
    [Binding]
    public class ItemPricingTest
    {
        CustomChromeDriver? driver;
        AmazonWebPageActions? webPageActions;
        AmazonUserPreferenceActions? userPreferenceActions;

        [Given(@"Browser has Amazon webpage navigated")]
        public void GivenBrowserHasAmazonWebpageNavigated()
        {
            driver = new CustomChromeDriver();
            driver.Load("https://www.amazon.com/");
            webPageActions = new AmazonWebPageActions(driver.WebDriver);
        }

        [Given(@"The currency preference is set to US Dollar")]
        public void GivenTheCurrencyPreferenceIsSetToUSDollar()
        {
            webPageActions?.ClickUserPreference();

            userPreferenceActions = new AmazonUserPreferenceActions(driver!.WebDriver);
            userPreferenceActions.SetCurrencyPreference("$ - USD - US Dollar (Default)");
            userPreferenceActions.ClickSaveUserPreference();
        }

        [When(@"Query for laptop using search bar")]
        public void WhenQueryForLaptopUsingSearchBar()
        {
            webPageActions?.SetSearchField("laptop");
            webPageActions?.ClickSearch();
        }

        [Then(@"First laptop item should be priced more than \$(.*)")]
        public void ThenFirstLaptopItemShouldBePricedMoreThan(Decimal p0)
        {
            //Console.WriteLine(p0);
            //Assert.Greater(webPage.GetPriceOfItem(1), p0);
        }

        [When(@"Query for '([^']*)' using search bar")]
        public void WhenQueryForUsingSearchBar(string item)
        {
            webPageActions?.SetSearchField(item);
            webPageActions?.ClickSearch();
        }

        [Then(@"First listed item should be priced more than '([^']*)'")]
        public void ThenFirstListedItemShouldBePricedMoreThan(Decimal price)
        {
            //Console.WriteLine(">>>Price :", price);
            //Assert.Greater(webPage.GetPriceOfItem(1), price);
        }

    }
}