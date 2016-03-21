using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class ButtonDriver : ControlBaseDriver
    {
        public ButtonDriver(IWebDriver driver, string id) : base(driver, id)
        {
        }
        public ButtonDriver(IWebDriver driver, By by) : base(driver, by)
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
