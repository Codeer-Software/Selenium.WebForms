using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms.Control
{
    public class ControlRadioButtonDriver : ControlBaseDriver
    {
        public ControlRadioButtonDriver(IWebDriver driver, string baseId) : base(driver, baseId)
        {
        }

        public string Text => IdElement.GetParent().Text;
        public bool Checked => (bool)Js.ExecuteScript("return document.getElementById(\"" + Id + "\").checked;");
        public ElementDriver Element => new ElementDriver(IdElement.GetParent());

        public void Edit()
        {
            IdElement.Click();
        }
    }
}