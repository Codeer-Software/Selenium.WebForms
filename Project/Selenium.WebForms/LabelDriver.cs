﻿using OpenQA.Selenium;
using Selenium.StandardControls;

namespace Selenium.WebForms
{
    public class LabelDriver : ControlBaseDriver
    {
        public LabelDriver(IWebDriver driver, string baseId) : base(driver, baseId)
        {
        }

        public string Text => IdElement.Text;
        public ElementDriver Element => new ElementDriver(IdElement);
    }
}