using OpenQA.Selenium;

namespace Selenium.WebForms.Control
{
    public abstract class ControlBaseDriver
    {
        protected ControlBaseDriver(IWebDriver driver, string baseId)
        {
            Driver = driver;
            Id = baseId;
        }

        public IWebDriver Driver { get; set; }
        public string Id { get; set; }
        protected IWebElement IdElement => Driver.FindElement(By.Id(Id));
        protected IJavaScriptExecutor Js => Driver as IJavaScriptExecutor;
    }
}