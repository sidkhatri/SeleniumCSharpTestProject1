using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTestProject1.Pages;

namespace SeleniumCSharpTestProject1
{
    public class Tests : DriverHelper
    {

       
    
        [Test]
        //public void Test1()
        //{
        //    Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
        //    Driver.Manage().Window.Maximize(); 
        //    Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

        //    CustomControl.comboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

        //    try { Driver.Quit(); } catch (Exception e) { Console.WriteLine("Nothing to see here!"); }


        //}

        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com");

            HomePage homePage = new HomePage(); 
            LoginPage loginPage = new LoginPage();

            homePage.ClickLogin();
            loginPage.EnterUserNameAndPassword("admin", "password");
            loginPage.ClickLoginButton();

            try { Driver.Quit(); } catch (Exception e) { Console.WriteLine("Nothing to see here!"); }

        }
    }
}