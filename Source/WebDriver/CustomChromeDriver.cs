using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonWebPageAutomation_Refactored.Source.WebDriver
{
    public class CustomChromeDriver
    {
        public IWebDriver WebDriver { get; private set; }
        
        public CustomChromeDriver() 
        {
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            WebDriver.Manage().Window.Maximize();
        }

        public CustomChromeDriver Load(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
            return this;
        }
    }
}
