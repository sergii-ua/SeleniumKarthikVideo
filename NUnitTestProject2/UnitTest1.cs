using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitTestProject2.Pages;

namespace NUnitTestProject2
{
    public class Tests
    {
        public static IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            //ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.BinaryLocation = "D:\\driver\\chromedriver";
            driver = new ChromeDriver("D:\\driver\\chromedriver");
        }

        //[Test]
        public void Test1()
        {
            //driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            //driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("t");

            //driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

            //IWebElement comboControl = driver.FindElement(By.Id("ContentPlaceHolder1_AllMealsCombo-awed"));
            //comboControl.Clear();
            //comboControl.SendKeys("Almond");
            //comboControl.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();


            //Console.WriteLine("Test1");
            ////Added some TEST comments
            //Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            HomePage homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homePage.IsLogOffExist, Is.True, "Log off link is not there!");
        }
    }
}