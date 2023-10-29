using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.Source.ElementTools
{
    public class DropdownElement : BaseWebElement
    {
        SelectElement? _selectElement;
        public DropdownElement(IWebElement element) : base(element) { }

        public void SelectElementByText(string text)
        {
            _selectElement = new SelectElement(_element);
            _selectElement.SelectByText(text);
        }
    }
}
