using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public abstract class ControlBaseDriver
    {
        By _by;
        public IWebDriver Driver { get; set; }
        public string Id { get; set; }
        protected IWebElement IdElement => Driver.FindElement(_by);
        protected IJavaScriptExecutor Js => Driver as IJavaScriptExecutor;

        protected ControlBaseDriver(IWebDriver driver, string id)
        {
            Driver = driver;
            Id = id;
            _by = By.Id(id);
        }

        protected ControlBaseDriver(IWebDriver driver, By by)
        {
            Driver = driver;
            _by = by;
        }
    }
}