using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace Selenium.WebForms.Inside
{
    static class GridLayout
    {
        internal class ListViewLayout : IListViewLayout
        {
            readonly ListViewDriver _driver;
            readonly IWebElement _listView;

            ReadOnlyCollection<IWebElement> Items => _listView.FindElements(By.TagName("tr"));
            public int ItemCount => Items.Count;

            internal ListViewLayout(ListViewDriver driver)
            {
                _driver = driver;
                _listView = _driver.Driver.FindElement(By.Id(driver.Id + "_itemPlaceholderContainer"));
            }
            public IListViewHeaderItemLayout GetHeaderItem(int index) => new ListViewHeaderItemLayout(_driver, index, Items[0]);
            public IListViewItemLayout GetItem(int index) => new ListViewItemLayout(_driver, index, Items[index + 1]);
        }


        private class ListViewHeaderItemLayout : IListViewHeaderItemLayout
        {
            readonly ListViewDriver _driver;
            readonly IWebElement _element;
            readonly int _index;

            public ListViewHeaderItemLayout(ListViewDriver driver, int index, IWebElement element)
            {
                _driver = driver;
                _element = element;
                _index = index;
            }
            public string Text => _element.FindElements(By.TagName("th"))[_index + 1].Text;
        }

        class ListViewItemLayout : IListViewItemLayout
        {
            readonly ListViewDriver _driver;
            readonly IWebElement _element;
            readonly int _index;

            public IWebElement Delete => GetButton("Delete");
            public IWebElement Edit => GetButton("Edit");
            public IWebElement Update => GetButton("Update");
            public IWebElement Cancel => GetButton("Cancel");
            public IWebElement Insert => _element.FindElement(By.Id(_driver.Id + "_InsertButton"));
            public IWebElement Clear => _element.FindElement(By.Id(_driver.Id + "_CancelButton"));

            public ListViewItemLayout(ListViewDriver driver, int index, IWebElement element)
            {
                _driver = driver;
                _element = element;
                _index = index;
            }

            IWebElement GetButton(string type) => _element.FindElement(By.Id(_driver.Id + "_" + type + "Button_" + _index));

            public IListViewSubItemLayout GetSubItem(int index)
            {
                //@@@XPathの方が良いかも。多分できる気がする
                return new ListViewSubItemLayout(_driver, _element.FindElements(By.TagName("td"))[index + 1]);
            }
        }

        class ListViewSubItemLayout : IListViewSubItemLayout
        {
            ListViewDriver _driver;

            public IWebElement Core { get; }

            public ListViewSubItemLayout(ListViewDriver driver, IWebElement element)
            {
                _driver = driver;
                Core = element;
            }
        }
    }
}
