using OpenQA.Selenium;

namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewSubItemLinkButton Driver
    /// </summary>
    public class ListViewSubItemLinkButtonDriver : ListViewSubItemDriver
    {
        IWebElement LinkButton => Element.FindElement(By.TagName("a"));
        /// <summary>
        /// LinkButton text
        /// </summary>
        public string Text => Element.Text;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemLinkButtonDriver</param>
        public ListViewSubItemLinkButtonDriver(ListViewSubItemDriver src) : base(src) { }
        /// <summary>
        /// Click of a LinkButton
        /// </summary>
        public void Click()
        {
            LinkButton.Click();
        }
    }

    public static class ListViewSubItemLinkButtonDriverExtensions
    {
        /// <summary>
        /// Get of ListViewSubItemLinkButtonDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemLinkButtonDriver</returns>
        public static ListViewSubItemLinkButtonDriver AsLinkButton(this ListViewSubItemDriver subItem) => new ListViewSubItemLinkButtonDriver(subItem);
    }
}
