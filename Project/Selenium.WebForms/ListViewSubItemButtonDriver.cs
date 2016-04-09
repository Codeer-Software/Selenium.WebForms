using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public class ListViewSubItemButtonDriver : ListViewSubItemDriver
    {
        private IWebElement Button => Element.FindElement(By.XPath("input[@type='submit']"));
        public string Text => Element.Text;
        public ListViewSubItemButtonDriver(ListViewSubItemDriver src) : base(src) { }

        public void Click()
        {
            Button.Click();
        }
    }

    public static class ListViewSubItemButtonDriverExtensions
    {
        public static ListViewSubItemButtonDriver AsButton(this ListViewSubItemDriver subItem) => new ListViewSubItemButtonDriver(subItem);
    }
}
