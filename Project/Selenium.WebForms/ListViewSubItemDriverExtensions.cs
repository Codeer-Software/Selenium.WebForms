using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public static class ListViewSubItemDriverExtensions
    {
        public static ButtonDriver AsButton(this ListViewSubItemDriver subItem) => new ButtonDriver(subItem.Element.FindElement(By.XPath("input[@type='submit']")));
        public static CheckBoxDriver AsCheckButton(this ListViewSubItemDriver subItem) => new CheckBoxDriver(subItem.Element.FindElement(By.XPath("input[@type='checkbox']")));
        public static LabelDriver AsLabel(this ListViewSubItemDriver subItem) => new LabelDriver(subItem.Element);
        public static RadioButtonDriver AsRadioButton(this ListViewSubItemDriver subItem) => new RadioButtonDriver(subItem.Element.FindElement(By.XPath("input[@type='radio']")));
        public static TextBoxDriver AsTextBox(this ListViewSubItemDriver subItem) => new TextBoxDriver(subItem.Element.FindElement(By.XPath("input[@type='text']")));
        public static AnchorDriver AsLinkButton(this ListViewSubItemDriver subItem) => new AnchorDriver(subItem.Element.FindElement(By.TagName("a")));
    }
}
