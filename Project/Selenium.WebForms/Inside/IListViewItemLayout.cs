using OpenQA.Selenium;

namespace Selenium.WebForms.Inside
{
    interface IListViewItemLayout
    {
        IWebElement Edit { get; }
        IWebElement Delete { get; }
        IWebElement Update { get; }
        IWebElement Cancel { get; }
        IWebElement Insert { get; }
        IWebElement Clear { get; }
        IListViewSubItemLayout GetSubItem(int index);
    }
}
