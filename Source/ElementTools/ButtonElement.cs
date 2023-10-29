using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.Source.ElementTools
{
    public class ButtonElement : BaseWebElement
    {
        public ButtonElement(IWebElement element) : base(element) { }

        public void Click() => _element.Click();
    }
}
