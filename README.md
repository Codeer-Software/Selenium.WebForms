# Selenium.WebForms

Created by Ishikawa-Tatsuya Matsui-Bin  
[![NuGet Version and Downloads count](https://buildstats.info/nuget/Selenium.WebForms)](https://www.nuget.org/packages/Selenium.WebForms/)

What is Selenium.WebForms?
---
The Selenium.WebForms, wraps the Seleinum in C#, test libraries to handle the controls of ASP.NET Web applications in a simple manner.
![image](/image.png)

Sample Code
---
```cs  
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace Test
{
    [TestClass]
    public class TestInfragistics
    {
        FirefoxDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
          _driver = new FirefoxDriver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
          _driver.Dispose();
        }

        [TestMethod]
        public void TextBox()
        {
          var _listView = new ListViewDriver(_driver, "MainContent_ListViewTestTarget");
          _listView.GetItem(1).StartEdit();
          _listView.GetItem(1).GetSubItem(2).AsTextBox().Edit("tt2");
          _listView.GetItem(1).Cancel();
        }
    }
}
```
Corresponding control
---
- ListView


ListView
---
Be placed in the list view can be edited or obtained for each control

- Button
```cs 
_listView.GetItem(1).GetSubItem(1).AsButton().Click();
```
- CheckButton
```cs 
_listView.GetItem(1).GetSubItem(2).AsCheckButton().Click();
_listView.GetItem(1).GetSubItem(2).AsCheckButton().Select(false);
_listView.GetItem(1).GetSubItem(2).AsCheckButton().Select(true);
```
- Label
```cs 
_listView.GetItem(1).GetSubItem(3).AsLabel().Text.Is("Label");
```
- LinkButton
```cs 
_listView.GetItem(1).GetSubItem(4).AsLinkButton().Click();
```
- RadioButton
```cs 
_listView.GetItem(1).GetSubItem(5).AsRadioButton().Click();
_listView.GetItem(1).GetSubItem(5).AsRadioButton().Select(false);
_listView.GetItem(1).GetSubItem(5).AsRadioButton().Select(true);
```
- TextBox
```cs 
_listView.GetItem(1).GetSubItem(6).AsTextBox().Edit("100");
```

Element & ElementInfo
---
Each control has a IWebElement and ElementInfo to each . Please operate using the IWebElement directly depending on the situation . Also ElementInfo is useful to get the information of the attributes([Detail](https://github.com/Codeer-Software/Selenium.StandardControls/blob/master/README.md#about-element--elementinfo)).

```cs 
_listView.GetItem(1).GetSubItem(1).Element.SendKeys(Keys.Enter);

var Info = _listView.GetItem(1).GetSubItem(1).Info;
Info.InnerHtml.Is("1");
Info.FontBold.IsFalse();
Info.BackGroundColor.Is("rgba(219, 112, 147, 1)");
Info.TextAlign.Is("left");
```
Author Info
---
Ishikawa-Tatsuya & Matsui-Bin is a software developer in Japan at Codeer, Inc.  
Ishikawa-Tatsuya & Matsui-Bin is awarding Microsoft MVP.

License
---
This library is under the Apache License.
