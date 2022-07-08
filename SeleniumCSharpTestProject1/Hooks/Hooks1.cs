
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumCSharpTestProject1.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        private DriverHelper _driverHelper;
        public Hooks1(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            _driverHelper.Driver = new ChromeDriver(option); 
           

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            try { _driverHelper.Driver.Quit(); } catch (Exception) { Console.WriteLine("Nothing to see here!"); }
        }
    }
}