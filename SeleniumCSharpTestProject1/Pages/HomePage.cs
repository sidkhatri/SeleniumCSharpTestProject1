using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTestProject1.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
        public void ClickLogin() => lnkLogin.Click();
    }

    
}
