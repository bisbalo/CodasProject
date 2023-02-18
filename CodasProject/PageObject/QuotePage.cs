using CodasProject.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodasProject.PageObject
{
    class QuotePage
    {

        public QuotePage()

        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Postcode => driver.FindElement(By.XPath("//*[@id='Postcode']"));
        IWebElement IQODemo => driver.FindElement(By.XPath("//*[@id='post-462']/div/div[1]/div/div[3]/div/div[2]/a"));
        IWebElement GetQuote => driver.FindElement(By.XPath("//*[@id='btnGetQuote']"));
        IWebElement Delivery => driver.FindElement(By.XPath("//*[@id='options']/tbody/tr[1]/td[5]/span/span"));
        public void ClickIQODemo()
        {
            IQODemo.Click();

            string str1 = driver.Title;
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            string str = driver.Title;
        }
        public void EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode);
        }

        public void ClickGetQuote()
        {
            GetQuote.Click();
        }
         
        public void SelectDelivery()
        {
            Delivery.Click();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("OrderScreenshot.png", ScreenshotImageFormat.Png);

        }

    }
    





}
