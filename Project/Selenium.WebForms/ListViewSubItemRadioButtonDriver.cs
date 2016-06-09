using OpenQA.Selenium;

namespace Selenium.WebForms
{
    //Todo One from the entire radio button must be clicked like a handle?
    //http://toolsqa.com/selenium-webdriver/checkbox-radio-button-operations/

    /// <summary>
    /// ListViewSubItemRadioButton Driver
    /// </summary>
    public class ListViewSubItemRadioButtonDriver : ListViewSubItemDriver
    {
        private IWebElement RadioButton => Element.FindElement(By.XPath("input[@type='radio']"));
        /// <summary>
        /// RadioButton text
        /// </summary>
        public string Text => Element.Text;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="src">Instance of ListViewSubItemDriver</param>
        public ListViewSubItemRadioButtonDriver(ListViewSubItemDriver src) : base(src) { }

        /// <summary>
        /// Click of a RadioButton
        /// </summary>
        public void Click()
        {
            RadioButton.Click();
        }

        /// <summary>
        /// Select of a RadioButton
        /// </summary>
        /// <param name="check">true:checked false:unchecked</param>
        public void Select(bool check)
        {
            if (RadioButton.Selected != check) Click();
        }
    }

    public static class ListViewSubItemRadioButtonDriverExtensions
    {
        /// <summary>
        /// Get of ListViewSubItemRadioButtonDriver
        /// </summary>
        /// <param name="subItem">Instance of ListViewSubItemDriver</param>
        /// <returns>ListViewSubItemRadioButtonDriver</returns>
        public static ListViewSubItemRadioButtonDriver AsRadioButton(this ListViewSubItemDriver subItem) => new ListViewSubItemRadioButtonDriver(subItem);
    }
}
