using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms.Control
{
    public class ControlTextBoxDriver : ControlBaseDriver
    {
        public ControlTextBoxDriver(IWebDriver driver, string baseId) : base(driver, baseId)
        {
        }

        public string Text => IdElement.GetAttribute("value");
        public ElementDriver Element => new ElementDriver(IdElement);

        public string Edit(string text)
        {
            IdElement.Clear();
            IdElement.SendKeys(text);
            return IdElement.GetAttribute("tooltip-error");
        }
    }
}