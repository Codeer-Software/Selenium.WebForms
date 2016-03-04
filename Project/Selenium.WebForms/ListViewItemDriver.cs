using Selenium.WebForms.Inside;

namespace Selenium.WebForms
{
    public class ListViewItemDriver
    {
        internal ListViewDriver Parent { get; }
        public int Index { get; }

        public ListViewItemDriver(ListViewDriver parent, int index)
        {
            Parent = parent;
            Index = index;
        }

        public ListViewSubItemDriver GetSubItem(int index) => new ListViewSubItemDriver(this, index);

        public void StartEdit()
        {
            Parent.Layout().GetItem(Index).Edit.Click();
        }

        public void Delete()
        {
            Parent.Layout().GetItem(Index).Delete.Click();
        }

        public void Update()
        {
            Parent.Layout().GetItem(Index).Update.Click();
        }

        public void Cancel()
        {
            Parent.Layout().GetItem(Index).Cancel.Click();
        }

        public void Insert()
        {
            Parent.Layout().GetItem(Index).Insert.Click();
        }

        public void Clear()
        {
            Parent.Layout().GetItem(Index).Clear.Click();
        }
    }
}
