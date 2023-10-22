using AmazonWebPageAutomation_Refactored.Source.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AmazonWebPageAutomation_Refactored.StepDefinitions
{
    [Binding]
    public class AmazonWebpageFunctionalTestStepDefinitions
    {
        IWebDriver driver;
        AmazonWebPage webPage;

        [Given(@"Browser has Amazon webpage navigated")]
        public void GivenBrowserHasAmazonWebpageNavigated()
        {
            driver = new ChromeDriver();
            webPage = new AmazonWebPage(driver);
        }

        [Given(@"The currency preference is set to US Dollar")]
        public void GivenTheCurrencyPreferenceIsSetToUSDollar()
        {
            webPage.SetCurrencyPreference("$ - USD - US Dollar (Default)");
        }

        [When(@"Query for laptop using search bar")]
        public void WhenQueryForLaptopUsingSearchBar()
        {
            webPage.Search("laptop");
        }

        [Then(@"First laptop item should be priced more than \$(.*)")]
        public void ThenFirstLaptopItemShouldBePricedMoreThan(Decimal p0)
        {
            Console.WriteLine(p0);
            Assert.Greater(webPage.GetPriceOfItem(1), p0);
        }

        [When(@"Query for '([^']*)' using search bar")]
        public void WhenQueryForUsingSearchBar(string item)
        {
            webPage.Search(item);
        }

        [Then(@"First handbag item should be priced more than \$(.*)")]
        public void ThenFirstHandbagItemShouldBePricedMoreThan(Decimal p0)
        {
            Console.WriteLine(">>>Price :", p0);
            Assert.Greater(webPage.GetPriceOfItem(1), p0);
        }

        [Then(@"First listed item should be priced more than '([^']*)'")]
        public void ThenFirstListedItemShouldBePricedMoreThan(Decimal price)
        {
            Console.WriteLine(">>>Price :", price);
            Assert.Greater(webPage.GetPriceOfItem(1), price);
        }

    }
}