namespace Selenium.WebForms
{
    /// <summary>
    /// ListViewSubItemLabel Driver
    /// </summary>
    public class ListViewSubItemLabelDriver : ListViewSubItemDriver
    {
        /// <summary>
        /// Label text
        /// </summary>
        public string Text => Element.Text;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemDriver</param>
        public ListViewSubItemLabelDriver(ListViewSubItemDriver src) : base(src) { }
    }

    public static class ListViewSubItemLabelDriverExtensions
    {
        /// <summary>
        /// Get of ListViewSubItemLabelDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemLabelDriver</returns>
        public static ListViewSubItemLabelDriver AsLabel(this ListViewSubItemDriver subItem) => new ListViewSubItemLabelDriver(subItem);
    }
}
