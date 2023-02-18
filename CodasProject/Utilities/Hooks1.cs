using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CodasProject.Utilities
{
    [Binding]
    public  class Hooks1



    {
        public static IWebDriver driver;

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before executing each scenario

            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
        }



        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario

            //driver.Quit();
        }

    }
}
