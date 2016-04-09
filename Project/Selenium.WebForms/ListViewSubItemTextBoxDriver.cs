using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public class ListViewSubItemTextBoxDriver : ListViewSubItemDriver
    {
        private IWebElement TextBox => Element.FindElement(By.XPath("input[@type='text']"));

        public string Text => TextBox.Text;

        public ListViewSubItemTextBoxDriver(ListViewSubItemDriver src) : base(src) { }

        public void Edit(string text)
        {
            TextBox.Clear();
            TextBox.SendKeys(text);
        }
    }

    public static class ListViewSubItemTextBoxDriverExtensions
    {
        public static ListViewSubItemTextBoxDriver AsTextBox(this ListViewSubItemDriver subItem) => new ListViewSubItemTextBoxDriver(subItem);
    }
}
