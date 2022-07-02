using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpTestProject1
{
    public  class DriverHelper
    {
        public static IWebDriver Driver = new ChromeDriver();
    }
}
