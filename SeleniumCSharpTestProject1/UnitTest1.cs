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

            IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));

            comboControl.Clear();
            comboControl.SendKeys("Almond");
            IWebElement dropDropDownSelect = Driver.FindElement(By.XPath("//body/div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']/div[2]/ul[1]/li[1]"));

            dropDropDownSelect.Click(); 
            
            Console.WriteLine("Test1");
            Assert.Pass();
            Driver.Close();
            Driver.Quit(); 
        }
    }
}