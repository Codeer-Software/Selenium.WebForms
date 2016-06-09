using System;
using OpenQA.Selenium;
using Selenium.WebForms.Inside;

namespace Selenium.WebForms
{
    /// <summary>
    /// ListView Driver
    /// </summary>
    public class ListViewDriver
    {
        /// <summary>
        /// Simple to WebDriver accessor
        /// </summary>
        public IWebDriver Driver { get; }
        /// <summary>
        /// ID of ListView
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Display mode of the list view
        /// </summary>
        public ListViewMode Mode { get; set; }
        /// <summary>
        /// The number of ListViewItemDriver
        /// </summary>
        public int ItemCount => Layout().ItemCount - 1;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="driver">Drivers to access</param>
        /// <param name="id">ID of ListView</param>
        public ListViewDriver(IWebDriver driver, string id)
        {
            Driver = driver;
            Id = id;
            Mode = ListViewMode.Grid;
        }

        /// <summary>
        /// Get of ListViewItemDriver
        /// </summary>
        /// <param name="index">Index of ListViewItemDriver</param>
        /// <returns>ListViewItemDriver</returns>
        public ListViewItemDriver GetItem(int index) => new ListViewItemDriver(this, index);

        /// <summary>
        /// Get of ListViewHeaderDriver
        /// </summary>
        /// <param name="index">Index of ListViewHeaderDriver</param>
        /// <returns></returns>
        public ListViewHeaderDriver GetHeaderItem(int index) => new ListViewHeaderDriver(this, index);

        internal IListViewLayout Layout()
        {
            switch (Mode)
            {
                case ListViewMode.Grid: return new GridLayout.ListViewLayout(this);
            }
            throw new NotSupportedException();
        }

    }
}
