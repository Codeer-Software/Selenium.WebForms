using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.WebForms.Inside;

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

    }
    public static class WebElementExtensions
    {
        public static ElementDriver GetElement(this ListViewSubItemDriver subItem)
        {
            return new ElementDriver(subItem.Parent.Parent.Driver, subItem.SubItemElement);

            //var script = $"var {WebElement.VarName}=$('#{subItem.Parent.Parent.Id}_itemPlaceholderContainer').find('tr')[{subItem.Index}];";
            //return new WebElement(subItem.Parent.Parent.Driver, script);
        }
    }
}
