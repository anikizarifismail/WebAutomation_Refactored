using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.Source.ElementTools
{
    public class BaseWebElement
    {
        public readonly IWebElement _element;

        public BaseWebElement(IWebElement element)
        {
            _element = element;
        }

        public bool IsDisplayed() => _element.Displayed;

        public Type Type() => _element.GetType();

    }
}
