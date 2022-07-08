using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTestProject1.Pages;
using TechTalk.SpecFlow;

namespace SeleniumCSharpTestProject1
{
    [Binding]
    public class Tests
    {

        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage;

        private void Test(DriverHelper driver)
        {
            this._driverHelper = driver;
            homePage = new HomePage(_driverHelper.Driver);
            loginPage = new LoginPage(_driverHelper.Driver);
        }


    
        [Test]
        public void Test1()
        {
            _driverHelper.Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            _driverHelper.Driver.Manage().Window.Maximize();
            _driverHelper.Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            //CustomControl.comboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

            try { _driverHelper.Driver.Quit(); } catch (Exception) { Console.WriteLine("Nothing to see here!"); }


        }
        //[Test]
        //public void LoginTest()
        //{
        //    _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com");

        //    homePage.ClickLogin();
        //    loginPage.EnterUserNameAndPassword("admin", "password");
        //    loginPage.ClickLoginButton();
        //    Assert.That(loginPage.linkLogOffExist(), Is.True);  

        //    try { _driverHelper.Driver.Quit(); } catch (Exception) { Console.WriteLine("Nothing to see here!"); }

        //}
    }
}