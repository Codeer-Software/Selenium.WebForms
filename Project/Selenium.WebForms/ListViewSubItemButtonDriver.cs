using OpenQA.Selenium;

namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewSubItemButton Driver
    /// </summary>
    public class ListViewSubItemButtonDriver : ListViewSubItemDriver
    {
        private IWebElement Button => Element.FindElement(By.XPath("input[@type='submit']"));
        /// <summary>
        /// Button text
        /// </summary>
        public string Text => Element.Text;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemDriver</param>
        public ListViewSubItemButtonDriver(ListViewSubItemDriver src) : base(src) { }

        /// <summary>
        /// Click of a button
        /// </summary>
        public void Click()
        {
            Button.Click();
        }
    }

    public static class ListViewSubItemButtonDriverExtensions
    {
        /// <summary>
        /// Get of ListViewSubItemButtonDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemButtonDriver</returns>
        public static ListViewSubItemButtonDriver AsButton(this ListViewSubItemDriver subItem) => new ListViewSubItemButtonDriver(subItem);
    }
}
