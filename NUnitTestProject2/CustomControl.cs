using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace NUnitTestProject2
{
    public class CustomControl : DriverHelper
    {

        //public static void ComboBox(string controlName, string value)
        //{
        //    IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
        //    comboControl.Clear();
        //    comboControl.SendKeys(value);
        //    Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        //}

        public static void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

        public static void Click(IWebElement webElement) => webElement.Click();

    }
}
