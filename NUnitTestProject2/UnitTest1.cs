using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject2
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = "D:\\driver\\chromedriver";
            driver = new ChromeDriver("D:\\driver\\chromedriver");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("t");

            driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            IWebElement comboControl = driver.FindElement(By.Id("ContentPlaceHolder1_AllMealsCombo-awed"));
            comboControl.Clear();
            comboControl.SendKeys("Almond");
            comboControl.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();
            


            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}