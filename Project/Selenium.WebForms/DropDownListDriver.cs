using System.Collections.Generic;
using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class DropDownListDriver : ControlBaseDriver
    {
        public DropDownListDriver(IWebDriver driver, string id) : base(driver, id)
        {
        }

        public string Text => Items[SelectedIndex];
        public long SelectedIndex => (long)Js.ExecuteScript("return document.getElementById(\"" + Id + "\").selectedIndex;");
        public string[] Items => GetItems();
        public ElementDriver Element => new ElementDriver(IdElement);

        public void Edit(string text)
        {
            IdElement.SendKeys(text);
        }

        public void Edit(int index)
        {
            Js.ExecuteScript("return document.getElementById(\"" + Id + "\").blur();");
            IdElement.SendKeys(Items[index]);
        }

        public void Check()
        {
            var x = Js.ExecuteScript("return document.getElementById(\"" + Id + "\").selectedIndex;");
        }

        public string[] GetItems()
        {
            dynamic items = Js.ExecuteScript("return document.getElementById(\"" + Id + "\").options;");
            var l = new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                l.Add(items[i].Text);
            }
            return l.ToArray();
        }
    }
}