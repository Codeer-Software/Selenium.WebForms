using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Selenium.WebForms;
using System.Threading;

namespace Test
{
    [TestClass]
    public class ListViewTest
    {
        ListViewDriver _listView;
        IWebDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            DBDriver.InitDB();

            _driver = BrowserUtil.GetDriver(BrowserUtil.Browser.Chrome);
            _driver.Url = "http://localhost:1776/Default";
            _listView = new ListViewDriver(_driver, "MainContent_ListViewTestTarget");
            while (_driver.FindElements(By.ClassName("jumbotron")).Count == 0)
            {
                Thread.Sleep(10);
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void Edit_Add_DeleteTest()
        {
            _listView.GetHeaderItem(1).Text.Is("Label");
            _listView.GetItem(1).StartEdit();
            _listView.GetItem(1).GetSubItem(2).AsTextBox().Edit("tt2");
            _listView.GetItem(1).Cancel();
            _listView.GetItem(1).GetSubItem(3).AsButton().Click();
            _listView.GetItem(1).GetSubItem(4).AsLinkButton().Click();
            _listView.GetItem(1).GetSubItem(5).AsCheckButton().Edit(false);
            _listView.GetItem(1).GetSubItem(5).AsCheckButton().Edit(true);

            var insert = _listView.GetItem(_listView.ItemCount - 1);
            insert.GetSubItem(0).AsTextBox().Edit("100");
            insert.Insert();
            insert.StartEdit();
            insert.GetSubItem(1).AsTextBox().Edit("XXX");
            insert.GetSubItem(5).AsCheckButton().Edit(false);
            insert.Update();
            insert.Delete();
        }

        [TestMethod]
        public void ElementTest()
        {
            //納得がいく形に。

            //The difference of the browser , divide the test if necessary
            var Info = _listView.GetItem(1).GetSubItem(1).Info;
            Info.FontItalic.IsFalse();
            Info.FontBold.IsFalse();
            Info.FontSize.Is("14px");
            Info.TextUnderline.IsFalse();
            Info.TextLineThrough.IsFalse();
            //Info.ImeMode.Is("auto");         //f:auto c,i:""
            Info.Text.IsNull();
            Info.Value.IsNull();
            Info.InnerHtml.Contains(" <span id=\"MainContent_ListViewTestTarget_LabelLabel_1\">").IsTrue();
            //Info.InnerText.IsNull();        //f:"" c,i:"E2"
            //Info.Width.Is("155.067px");         //f c i
            //Info.Height.Is("27.4px");           //f c i
            Info.Font.Contains("Helvetica Neue").IsTrue();
            Info.Font.Contains("Helvetica").IsTrue();
            Info.Font.Contains("Arial").IsTrue();
            Info.Font.Contains("sans-serif").IsTrue();
            Info.Color.Is("rgba(51, 51, 51, 1)");
            //Info.BackGroundColor.Is("transparent");    //f,i:transparent c:0,0,0
            //Info.TextAlign.Is("start");               //f,c:start i:left
            Info.Class.Is("");
            //Info.TabIndex.Is(-1);                        //f,c:-1 i:0
            Info.MaxLength.IsNull();
        }
    }
}
