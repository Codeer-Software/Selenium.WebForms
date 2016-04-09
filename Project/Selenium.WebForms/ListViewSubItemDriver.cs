using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class ListViewSubItemDriver
    {
        internal ListViewItemDriver Parent { get; }
        public ElementInfo Info => new ElementInfo(Element);
        public IWebElement Element => Parent.Parent.Layout().GetItem(Parent.Index).GetSubItem(Index).Core;

        public int Index { get; }

        public ListViewSubItemDriver(ListViewItemDriver parent, int index)
        {
            Parent = parent;
            Index = index;
        }

        public ListViewSubItemDriver(ListViewSubItemDriver src)
        {
            Parent = src.Parent;
            Index = src.Index;
        }
    }
}