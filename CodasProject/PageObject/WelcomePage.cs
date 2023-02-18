using CodasProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodasProject.PageObject
{
    class WelcomePage
    {

        public WelcomePage()

        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement News => driver.FindElement(By.XPath("//*[@id='menu-item-920']/a/span"));
        IWebElement Article => driver.FindElement(By.XPath("//*[@id='blog-1-post-5457']/div[2]/h2/a"));
        IWebElement Readmore => driver.FindElement(By.XPath("//*[@id='blog-1-post-5457']/div[4]/div/a"));
        IWebElement Home => driver.FindElement(By.XPath("//*[@id='menu-item-25']/a/span"));
        IWebElement CodasIqo => driver.FindElement(By.XPath("//*[@id='post-2']/div/div[1]/div/div[2]/div/div[2]/div[2]/div/div[1]/a/h2"));
       // IWebElement IQODemo => driver.FindElement(By.XPath("//*[@id='post-462']/div/div[1]/div/div[3]/div/div[2]/a"));
        //IWebElement Article => driver.FindElement(By.XPath("//*[@id='blog-1-post-5457']/div[1]/div[1]/span[1]"));

       





        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickNews()
        {
            News.Click();
        }

        public bool IsArticleDisplayed()
        {
            return Article.Displayed;
        }
        public void ClickReadmore()

        {
            Readmore.Click();
            
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("ReadMoreScreenshot1.png", ScreenshotImageFormat.Png);
        }

        public void Clickhome()
        {
            Home.Click();
        }

        public void ClickCodasIqo()
        {
            CodasIqo.Click();
        }

       // public void ClickIQODemo()
       // {
          //  IQODemo.Click();

            //string str1 = driver.Title;
           // driver.SwitchTo().Window(driver.WindowHandles[1]);
           // string str = driver.Title;
       // }

    }









}

