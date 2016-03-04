using OpenQA.Selenium;
using Selenium.WebForms.Inside;

namespace Selenium.WebForms
{
    public class ListViewDriver
    {
        public IWebDriver Driver { get; }
        public string Id { get; }
        public ListViewMode Mode { get; set; }
        public int ItemCount => this.Layout().ItemCount - 1;
        public ListViewDriver(IWebDriver driver, string id)
        {
            Driver = driver;
            Id = id;
            Mode = ListViewMode.Grid;
        }

        public ListViewItemDriver GetItem(int index) => new ListViewItemDriver(this, index);
        public ListViewHeaderDriver GetHeaderItem(int index) => new ListViewHeaderDriver(this, index);
    }
}
