using OpenQA.Selenium;

namespace Selenium.WebForms
{
    public class ListViewSubItemCheckButtonDriver : ListViewSubItemDriver
    {
        private IWebElement CheckButton => SubItemElement.FindElement(By.XPath("input[@type='checkbox']"));
        public string Text => SubItemElement.Text;
        public ListViewSubItemCheckButtonDriver(ListViewSubItemDriver src) : base(src) { }

        public void Click()
        {
            CheckButton.Click();
        }
        public void Select(bool check)
        {
            if (CheckButton.Selected != check) Click();
        }
    }

    public static class ListViewSubItemCheckButtonDriverExtensions
    {
        public static ListViewSubItemCheckButtonDriver AsCheckButton(this ListViewSubItemDriver subItem) => new ListViewSubItemCheckButtonDriver(subItem);
    }
}
