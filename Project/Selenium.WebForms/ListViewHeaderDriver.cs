namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewHeader Driver
    /// </summary>
    public class ListViewHeaderDriver
    {
        internal ListViewDriver Parent { get; }
        /// <summary>
        /// Index of ListViewHeaderDriver
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// Text of ListViewHeaderDriver
        /// </summary>
        public string Text => Parent.Layout().GetHeaderItem(Index).Text;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent">ListViewDriver</param>
        /// <param name="index">Instance of ListViewDriver</param>
        public ListViewHeaderDriver(ListViewDriver parent, int index)
        {
            Parent = parent;
            Index = index;
        }
    }
}
