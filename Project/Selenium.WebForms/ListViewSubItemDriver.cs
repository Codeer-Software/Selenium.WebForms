using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewSubItem Driver
    /// </summary>
    public class ListViewSubItemDriver
    {
        internal ListViewItemDriver Parent { get; }
        /// <summary>
        /// ElementInfo of ListViewItemDriver
        /// </summary>
        public ElementInfo Info => new ElementInfo(Element);
        /// <summary>
        /// Element of ListViewItemDriver
        /// </summary>
        public IWebElement Element => Parent.Parent.Layout().GetItem(Parent.Index).GetSubItem(Index).Core;
        /// <summary>
        /// Index of ListViewItemDriver
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemDriver</param>
        public ListViewSubItemDriver(ListViewSubItemDriver src)
        {
            Parent = src.Parent;
            Index = src.Index;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent">Instance of ListViewSubItemDriver</param>
        /// <param name="index">Index of ListViewSubItemDriver</param>
        public ListViewSubItemDriver(ListViewItemDriver parent, int index)
        {
            Parent = parent;
            Index = index;
        }
    }
    public static class ListViewSubItemExtensions
    {
        /// <summary>
        /// Get of ButtonDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ButtonDriver</returns>
        public static ButtonDriver AsButton(this ListViewSubItemDriver subItem) => new ButtonDriver(subItem.Element.FindElement(By.XPath("input[@type='submit']")));
        /// <summary>
        /// Get of CheckBoxDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>CheckBoxDriver</returns>
        public static CheckBoxDriver AsCheckButton(this ListViewSubItemDriver subItem) => new CheckBoxDriver(subItem.Element.FindElement(By.XPath("input[@type='checkbox']")));
        /// <summary>
        /// Get of LabelDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>LabelDriver</returns>
        public static LabelDriver AsLabel(this ListViewSubItemDriver subItem) => new LabelDriver(subItem.Element);
        /// <summary>
        /// Get of ButtonDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ButtonDriver</returns>
        public static ButtonDriver AsLinkButton(this ListViewSubItemDriver subItem) => new ButtonDriver(subItem.Element.FindElement(By.TagName("a")));
        /// <summary>
        /// Get of TextBoxDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>TextBoxDriver</returns>
        public static TextBoxDriver AsTextBox(this ListViewSubItemDriver subItem) => new TextBoxDriver(subItem.Element.FindElement(By.XPath("input[@type='text']")));
    }
}