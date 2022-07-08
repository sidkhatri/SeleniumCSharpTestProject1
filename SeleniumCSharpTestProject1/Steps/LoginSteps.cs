using Gherkin.Ast;
using SeleniumCSharpTestProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace SeleniumCSharpTestProject1.Steps
{
    [Binding]
    public class LoginSteps
    {
        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginPage; 

        public LoginSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
             homePage = new HomePage(_driverHelper.Driver);
             loginPage = new LoginPage(_driverHelper.Driver);
        }



        

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
            
        }


        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword((string)data.UserName, (string)data.Password);
            
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(loginPage.linkLogOffExist(), Is.True);
            
        }




    }
}
