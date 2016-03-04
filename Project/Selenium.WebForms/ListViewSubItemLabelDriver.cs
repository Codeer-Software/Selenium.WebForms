namespace Selenium.WebForms
{
    public class ListViewSubItemLabelDriver : ListViewSubItemDriver
    {
        public string Text => SubItemElement.Text;
        public ListViewSubItemLabelDriver(ListViewSubItemDriver src) : base(src) { }
    }

    public static class ListViewSubItemLabelDriverExtensions
    {
        public static ListViewSubItemLabelDriver AsLabel(this ListViewSubItemDriver subItem) => new ListViewSubItemLabelDriver(subItem);
    }
}
