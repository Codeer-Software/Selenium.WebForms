using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms.Control
{
    public class ControlLabelDriver : ControlBaseDriver
    {
        public ControlLabelDriver(IWebDriver driver, string baseId) : base(driver, baseId)
        {
        }

        public string Text => IdElement.Text;
        public ElementDriver Element => new ElementDriver(IdElement);
    }
}