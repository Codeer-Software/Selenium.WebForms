using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms.Control
{
    public class ControlButtonDriver : ControlBaseDriver
    {
        public ControlButtonDriver(IWebDriver driver, string baseId) : base(driver, baseId)
        {
        }
        public string Text => IdElement.GetAttribute("value");
        public ElementDriver Element => new ElementDriver(IdElement);
        public void Click()
        {
            IdElement.Click();
        }

    }
}
