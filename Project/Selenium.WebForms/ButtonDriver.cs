using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class ButtonDriver : ControlBaseDriver
    {
        public ButtonDriver(IWebDriver driver, string baseId) : base(driver, baseId)
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
