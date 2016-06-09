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
}