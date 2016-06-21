using Selenium.StandardControls;

namespace Selenium.WebForms.Inside
{
    interface IListViewItemLayout
    {
        ButtonDriver Edit { get; }
        ButtonDriver Delete { get; }
        ButtonDriver Update { get; }
        ButtonDriver Cancel { get; }
        ButtonDriver Insert { get; }
        ButtonDriver Clear { get; }
        IListViewSubItemLayout GetSubItem(int index);
    }
}
