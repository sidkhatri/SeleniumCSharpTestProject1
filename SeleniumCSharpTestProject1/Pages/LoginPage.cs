using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTestProject1.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver; 
        public LoginPage(IWebDriver driver)
        {
            this.Driver = driver; 
        }
        IWebElement lgnField => Driver.FindElement(By.XPath("//input[@id='UserName']"));
        IWebElement pwdField => Driver.FindElement(By.XPath("//input[@id='Password']"));

        IWebElement lgnBtn => Driver.FindElement(By.XPath("//body/div[2]/div[1]/div[2]/section[1]/form[1]/div[4]/div[1]/input[1]"));

        IWebElement lgOffBtn => Driver.FindElement(By.LinkText("Log off"));

        public void EnterUserNameAndPassword (string userName, string password)
        {
            lgnField.SendKeys(userName); 
            pwdField.SendKeys(password);
        }       

        public void ClickLoginButton()
        {
            lgnBtn.Click(); 
        }

        public bool linkLogOffExist() => lgOffBtn.Displayed; 
 

    }
}
