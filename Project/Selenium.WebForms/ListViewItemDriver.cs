namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewItem Driver
    /// </summary>
    public class ListViewItemDriver
    {
        internal ListViewDriver Parent { get; }
        /// <summary>
        /// Index of ListViewItemDriver
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent">Instance of ListViewDriver</param>
        /// <param name="index">Index of ListViewItemDriver</param>
        public ListViewItemDriver(ListViewDriver parent, int index)
        {
            Parent = parent;
            Index = index;
        }

        /// <summary>
        /// Get of ListViewSubItemDriver
        /// </summary>
        /// <param name="index">Index of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemDriver</returns>
        public ListViewSubItemDriver GetSubItem(int index) => new ListViewSubItemDriver(this, index);

        /// <summary>
        /// The start of the editing Element
        /// </summary>
        public void StartEdit()
        {
            Parent.Layout().GetItem(Index).Edit.Invoke();
        }

        /// <summary>
        /// Delete of Element
        /// </summary>
        public void Delete()
        {
            Parent.Layout().GetItem(Index).Delete.Invoke();
        }

        /// <summary>
        /// Update of Element
        /// </summary>
        public void Update()
        {
            Parent.Layout().GetItem(Index).Update.Invoke();
        }

        /// <summary>
        /// Cancel of Element
        /// </summary>
        public void Cancel()
        {
            Parent.Layout().GetItem(Index).Cancel.Invoke();
        }

        /// <summary>
        /// Insert of Element
        /// </summary>
        public void Insert()
        {
            Parent.Layout().GetItem(Index).Insert.Invoke();
        }

        /// <summary>
        /// Clear of Element
        /// </summary>
        public void Clear()
        {
            Parent.Layout().GetItem(Index).Clear.Invoke();
        }
    }
}
