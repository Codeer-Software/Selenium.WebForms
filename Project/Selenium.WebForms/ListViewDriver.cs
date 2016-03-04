using System;
using OpenQA.Selenium;
using Selenium.WebForms.Inside;

namespace Selenium.WebForms
{
    public class ListViewDriver
    {
        public IWebDriver Driver { get; }
        public string Id { get; }
        public ListViewMode Mode { get; set; }
        public int ItemCount => Layout().ItemCount - 1;
        public ListViewDriver(IWebDriver driver, string id)
        {
            Driver = driver;
            Id = id;
            Mode = ListViewMode.Grid;
        }

        internal IListViewLayout Layout()
        {
            switch (Mode)
            {
                case ListViewMode.Grid: return new GridLayout.ListViewLayout(this);
            }
            throw new NotSupportedException();
        }

        public ListViewItemDriver GetItem(int index) => new ListViewItemDriver(this, index);
        public ListViewHeaderDriver GetHeaderItem(int index) => new ListViewHeaderDriver(this, index);
    }
}
