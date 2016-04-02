using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;

namespace Selenium.WebForms
{
    public class FormsCheckBoxDriver : CheckBoxDriver
    {
        public FormsCheckBoxDriver(IWebElement element) : base(element) { }
        public string Text => Parent.Text;
        public static implicit operator FormsCheckBoxDriver(ElementFinder finder) => new FormsCheckBoxDriver(finder.Find());
    }
}