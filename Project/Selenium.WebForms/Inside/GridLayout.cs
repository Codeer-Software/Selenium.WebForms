using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms.Inside
{
    internal static class GridLayout
    {
        internal class ListViewLayout : IListViewLayout
        {
            private readonly ListViewDriver _driver;
            private readonly IWebElement _listView;
            //TODO
            private ReadOnlyCollection<IWebElement> Items => _listView.FindElements(By.TagName("tr"));
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
            private readonly ListViewDriver _driver;
            private readonly IWebElement _element;
            private readonly int _index;

            public ListViewHeaderItemLayout(ListViewDriver driver, int index, IWebElement element)
            {
                _driver = driver;
                _element = element;
                _index = index;
            }

            //TODO
            public string Text => _element.FindElements(By.TagName("th"))[_index + 1].Text;
        }

        private class ListViewItemLayout : IListViewItemLayout
        {
            private readonly ListViewDriver _driver;
            private readonly IWebElement _element;
            private readonly int _index;

            public ButtonDriver Delete => GetButton("Delete");
            public ButtonDriver Edit => GetButton("Edit");
            public ButtonDriver Update => GetButton("Update");
            public ButtonDriver Cancel => GetButton("Cancel");
            public ButtonDriver Insert => new ButtonDriver(_element.FindElement(By.Id(_driver.Id + "_InsertButton")));
            public ButtonDriver Clear => new ButtonDriver(_element.FindElement(By.Id(_driver.Id + "_CancelButton")));

            public ListViewItemLayout(ListViewDriver driver, int index, IWebElement element)
            {
                _driver = driver;
                _element = element;
                _index = index;
            }

            private ButtonDriver GetButton(string type) => new ButtonDriver(_element.FindElement(By.Id(_driver.Id + "_" + type + "Button_" + _index)));

            public IListViewSubItemLayout GetSubItem(int index)
            {
                //TODO
                return new ListViewSubItemLayout(_driver, _element.FindElements(By.TagName("td"))[index + 1]);
            }
        }

        private class ListViewSubItemLayout : IListViewSubItemLayout
        {
            private ListViewDriver _driver;

            public IWebElement Core { get; }

            public ListViewSubItemLayout(ListViewDriver driver, IWebElement element)
            {
                _driver = driver;
                Core = element;
            }
        }
    }
}