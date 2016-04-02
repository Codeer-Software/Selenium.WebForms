using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Selenium.WebForms
{
    public class FormsRadioButtonDriver : RadioButtonDriver
    {
        public FormsRadioButtonDriver(IWebElement element) : base(element) { }
        public string Text => Parent.Text;
        public static implicit operator FormsRadioButtonDriver(ElementFinder finder) => new FormsRadioButtonDriver(finder.Find());
    }
}