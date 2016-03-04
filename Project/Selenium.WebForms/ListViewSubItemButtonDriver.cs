using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public class ListViewSubItemButtonDriver : ListViewSubItemDriver
    {
        private IWebElement Button => SubItemElement.FindElement(By.XPath("input[@type='submit']"));
        public string Text => SubItemElement.Text;
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
