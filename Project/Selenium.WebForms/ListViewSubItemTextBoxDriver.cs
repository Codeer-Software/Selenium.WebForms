using OpenQA.Selenium;

namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewSubItemTextBox Driver
    /// </summary>
    public class ListViewSubItemTextBoxDriver : ListViewSubItemDriver
    {

        private IWebElement TextBox => Element.FindElement(By.XPath("input[@type='text']"));

        /// <summary>
        /// TextBox Text
        /// </summary>
        public string Text => TextBox.Text;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemDriver</param>
        public ListViewSubItemTextBoxDriver(ListViewSubItemDriver src) : base(src) { }

        /// <summary>
        /// Edit of a TextBox
        /// </summary>
        /// <param name="text">Text to be edited</param>
        public void Edit(string text)
        {
            TextBox.Clear();
            TextBox.SendKeys(text);
        }
    }

    public static class ListViewSubItemTextBoxDriverExtensions
    {
        /// <summary>
        /// Get of ListViewSubItemTextBoxDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemTextBoxDriver</returns>
        public static ListViewSubItemTextBoxDriver AsTextBox(this ListViewSubItemDriver subItem) => new ListViewSubItemTextBoxDriver(subItem);
    }
}
