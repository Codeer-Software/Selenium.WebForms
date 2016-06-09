using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO;

namespace Test
{
    //[TestClass]
    public class XPathTest
    {
        IWebDriver _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            _driver = new FirefoxDriver();
            _driver.Url = Path.GetFullPath("../../../Test/XPathTarget.html");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void TestXPath()
        {
            _driver.FindElements(By.XPath("/html/body"))[0].FindElements(By.XPath("table/tbody/tr/td")).Count.Is(1);
        }
    }
}
