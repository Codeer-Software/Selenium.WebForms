using Selenium.WebForms.Inside;

namespace Selenium.WebForms
{
    public class ListViewHeaderDriver
    {
        internal ListViewDriver Parent { get; }
        public int Index { get; }

        public string Text => Parent.Layout().GetHeaderItem(Index).Text;

        public ListViewHeaderDriver(ListViewDriver parent, int index)
        {
            Parent = parent;
            Index = index;
        }
    }
}
