using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//using ClassLibrary1;
//using System.Threading;
//using System;



namespace Tests
{
    [TestFixture]
    public class Tests
    {
        public string browser = "Chrome";
       // private Class1 obj = new Class1();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            // obj.IsPrime(1);
            //IWebDriver webdriver;
            if (browser.Equals("Chrome"))
            {
                IWebDriver driver = new ChromeDriver(@"C:\Users\ashish.baldota\source\repos\NUnitTestProject1\NUnitTestProject1\driver");
                driver.Navigate().GoToUrl("http://shop.demoqa.com/");
                driver.Close();
                
                //List<IWebElement> allLinks=driver.FindElements(By.PartialLinkText("MyA"));
               
            }
        }
    }
}