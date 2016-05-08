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
            Parent.Layout().GetItem(Index).Edit.Invoke();
        }

        public void Delete()
        {
            Parent.Layout().GetItem(Index).Delete.Invoke();
        }

        public void Update()
        {
            Parent.Layout().GetItem(Index).Update.Invoke();
        }

        public void Cancel()
        {
            Parent.Layout().GetItem(Index).Cancel.Invoke();
        }

        public void Insert()
        {
            Parent.Layout().GetItem(Index).Insert.Invoke();
        }

        public void Clear()
        {
            Parent.Layout().GetItem(Index).Clear.Invoke();
        }
    }
}
