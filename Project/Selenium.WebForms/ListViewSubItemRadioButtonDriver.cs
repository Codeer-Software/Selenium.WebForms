using OpenQA.Selenium;

namespace Selenium.WebForms
{
    //Todo 現状クリックはこれで良いが、本来ラジオボタン全体を取得してきて
    //IsSelectedから1個をクリックみたいな処理が必要かも。保留
    //http://toolsqa.com/selenium-webdriver/checkbox-radio-button-operations/

    public class ListViewSubItemRadioButtonDriver : ListViewSubItemDriver
    {
        private IWebElement CheckButton => SubItemElement.FindElement(By.XPath("input[@type='radio']"));
        public string Text => SubItemElement.Text;
        public ListViewSubItemRadioButtonDriver(ListViewSubItemDriver src) : base(src) { }

        public void Click()
        {
            CheckButton.Click();
        }
        public void Select(bool check)
        {
            if (CheckButton.Selected != check) Click();
        }
    }

    public static class ListViewSubItemRadioButtonDriverExtensions
    {
        public static ListViewSubItemRadioButtonDriver AsRadioButton(this ListViewSubItemDriver subItem) => new ListViewSubItemRadioButtonDriver(subItem);
    }
}
