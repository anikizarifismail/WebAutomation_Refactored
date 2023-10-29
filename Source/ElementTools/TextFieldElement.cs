using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonWebPageAutomation_Refactored.Source.ElementTools
{
    public class TextFieldElement : BaseWebElement
    {
        public TextFieldElement(IWebElement element) : base(element) { }

        public TextFieldElement SetSearchItem(string searchItem)
        {
            _element.SendKeys(searchItem);
            return this;
        }
    }
}
