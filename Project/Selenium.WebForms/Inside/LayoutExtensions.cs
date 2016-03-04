using System;

namespace Selenium.WebForms.Inside
{
    static class LayoutExtensions
    {
        internal static IListViewLayout Layout(this ListViewDriver driver)
        {
            switch (driver.Mode)
            {
                case ListViewMode.Grid: return new GridLayout.ListViewLayout(driver);
            }
            throw new NotSupportedException();
        }
    }
}
