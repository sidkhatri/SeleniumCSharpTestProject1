using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTestProject1
{
    public class Tests
    {

        public IWebDriver Driver; 
        
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Windows!");
            Driver = new ChromeDriver(); 

        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
           
            
            Console.WriteLine("Test1");
            Assert.Pass();
            Driver.Quit();
            Driver.Close();
        }
    }
}