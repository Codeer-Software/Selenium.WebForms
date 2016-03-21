using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class LinkButtonDriver : ControlBaseDriver
    {
        public LinkButtonDriver(IWebDriver driver, string baseId) : base(driver, baseId)
        {
        }

        public string Text => IdElement.Text;
        public ElementDriver Element => new ElementDriver(IdElement);

        public void Click()
        {
            IdElement.Click();
        }
    }
}