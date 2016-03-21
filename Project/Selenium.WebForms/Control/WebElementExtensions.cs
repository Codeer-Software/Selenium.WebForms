using OpenQA.Selenium;

namespace Selenium.WebForms.Control
{
    public static class WebElementExtensions
    {
        public static IWebElement GetParent(this IWebElement element)
        {
            return element.FindElement(By.XPath("parent::node()"));
        }
    }
}
