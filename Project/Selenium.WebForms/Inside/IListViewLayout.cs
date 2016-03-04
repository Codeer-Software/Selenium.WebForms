namespace Selenium.WebForms.Inside
{
    interface IListViewLayout
    {
        int ItemCount { get; }
        IListViewItemLayout GetItem(int index);

        IListViewHeaderItemLayout GetHeaderItem(int columnIndex);
    }
}
