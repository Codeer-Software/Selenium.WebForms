using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class ListViewSubItemDriver
    {
        internal ListViewItemDriver Parent { get; }

        internal IWebElement SubItemElement => Parent.Parent.Layout().GetItem(Parent.Index).GetSubItem(Index).Core;

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

        public ElementDriver GetElement() => new ElementDriver(SubItemElement);
    }
}