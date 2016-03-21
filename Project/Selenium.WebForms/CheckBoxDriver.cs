using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class CheckBoxDriver : ControlBaseDriver
    {
        public CheckBoxDriver(IWebDriver driver, string id) : base(driver, id)
        {
        }

        public string Text => IdElement.GetParent().Text;
        public bool Checked => (bool)Js.ExecuteScript("return document.getElementById(\"" + Id + "\").checked;");
        public ElementDriver Element => new ElementDriver(IdElement.GetParent());

        public void Edit(bool check)
        {
            if (Checked != check)
            {
                IdElement.Click();
            }
        }
    }
}