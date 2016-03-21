using System.Collections.Generic;
using OpenQA.Selenium;
using Selenium.StandardControls;
using OpenQA.Selenium.Support.UI;

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
        public SelectElement Core => new SelectElement(IdElement);

        public void Edit(string text)
        {
            Core.SelectByText(text);
        }

        public void Edit(int index)
        {
            Js.ExecuteScript("return document.getElementById(\"" + Id + "\").blur();");
            Core.SelectByIndex(index);
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