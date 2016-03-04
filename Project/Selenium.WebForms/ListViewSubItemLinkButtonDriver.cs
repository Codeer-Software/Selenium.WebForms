using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public class ListViewSubItemLinkButtonDriver : ListViewSubItemDriver
    {
        private IWebElement CheckButton => SubItemElement.FindElement(By.XPath("a[@href]"));
        IWebElement LinkButton => SubItemElement.FindElement(By.TagName("a"));
        public string Text => SubItemElement.Text;
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
