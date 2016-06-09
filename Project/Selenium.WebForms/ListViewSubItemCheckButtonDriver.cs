using OpenQA.Selenium;

namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewSubItemCheckButton Driver
    /// </summary>
    public class ListViewSubItemCheckButtonDriver : ListViewSubItemDriver
    {
        private IWebElement CheckButton => Element.FindElement(By.XPath("input[@type='checkbox']"));
        /// <summary>
        /// CheckButton Text
        /// </summary>
        public string Text => Element.Text;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemDriver</param>
        public ListViewSubItemCheckButtonDriver(ListViewSubItemDriver src) : base(src) { }

        /// <summary>
        /// Click of a CheckButton
        /// </summary>
        public void Click()
        {
            CheckButton.Click();
        }

        /// <summary>
        /// Select of a CheckButton
        /// </summary>
        /// <param name="check">true:checked false:unchecked</param>
        public void Select(bool check)
        {
            if (CheckButton.Selected != check) Click();
        }
    }

    public static class ListViewSubItemCheckButtonDriverExtensions
    {
        /// <summary>
        /// Get of ListViewSubItemCheckButtonDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemCheckButtonDriver</returns>
        public static ListViewSubItemCheckButtonDriver AsCheckButton(this ListViewSubItemDriver subItem) => new ListViewSubItemCheckButtonDriver(subItem);
    }
}
