using OpenQA.Selenium;
using System;
using System.Threading;

namespace Selenium.WebForms
{
    public class UpdatePanelDriver
    {
        public static void WaitForUpdate(IWebDriver driver, Action action, string uniqueName = "Selenium_StandardControls_UpdatePanelEndRequest")
        {
            var flg = uniqueName + "_UpdatedFlg";
            var func = uniqueName;

            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(
                flg + " = false;" +
                "Sys.WebForms.PageRequestManager.getInstance().remove_endRequest(" + func + ");" +
                "Sys.WebForms.PageRequestManager.getInstance().add_endRequest(" + func + ");" +
                "function " + func + "(sender, args) {" +
                    flg + " = true;" +
                "}"
                );

            action();

            while (!(bool)js.ExecuteScript("return " + flg + ";"))
            {
                Thread.Sleep(50);
            }
        }
    }
}
