using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public class ListViewSubItemLinkButtonDriver : ListViewSubItemDriver
    {
        private IWebElement CheckButton => Element.FindElement(By.XPath("a[@href]"));
        IWebElement LinkButton => Element.FindElement(By.TagName("a"));
        public string Text => Element.Text;
        public ListViewSubItemLinkButtonDriver(ListViewSubItemDriver src) : base(src) { }

        public void Click()
        {
            LinkButton.Click();
        }
    }

    public static class ListViewSubItemLinkButtonDriverExtensions
    {
        public static ListViewSubItemLinkButtonDriver AsLinkButton(this ListViewSubItemDriver subItem) => new ListViewSubItemLinkButtonDriver(subItem);
    }
}
