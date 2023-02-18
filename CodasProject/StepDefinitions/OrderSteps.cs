using CodasProject.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace CodasProject.StepDefinitions
{
    [Binding]
    public class OrderSteps

    {
        WelcomePage welcomePage;
        QuotePage quotePage;

        public OrderSteps()
        {
            welcomePage = new WelcomePage();
            quotePage = new QuotePage();
        }


        [Given(@"I navigate to""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            welcomePage.NavigateToWebsite(url);
        }
        
        [When(@"I click on the news tab")]
        public void WhenIClickOnTheNewsTab()
        {
            welcomePage.ClickNews();
        }
        
        [Then(@"I can confirm the article dated March (.*)th (.*)")]
        public void ThenICanConfirmTheArticleDatedMarchTh()
        {
            Assert.That(welcomePage.IsArticleDisplayed);
        }

        [Then(@"I can confirm the  March article")]
        public void ThenICanConfirmTheMarchArticle()
        {
            Assert.That(welcomePage.IsArticleDisplayed);
        }
        [When(@"I click on read more and take a screenshoot")]
        public void WhenIClickOnReadMoreandTakeAScreenshoot()
        {
            welcomePage.ClickReadmore();
        }
        [When(@"I click on the Home link")]
        public void WhenIClickOnTheHomeLink()
        {
            welcomePage.Clickhome();
        }

        [When(@"I click on CODAS -IQO")]
        public void WhenIClickOnCODAS_IQO()
        {
            welcomePage.ClickCodasIqo();
        }

        [Then(@"I click on IQO Demo")]
        public void ThenIClickOnIQODemo()
        {
            quotePage.ClickIQODemo();
        }

        [When(@"i enter postcode ""(.*)""")]
        public void WhenIEnterPostcode(string postcode)
        {
            Thread.Sleep(4000);
            quotePage.EnterPostcode(postcode);
        }

        [When(@"I click on Get Quote")]
        public void WhenIClickOnGetQuote()
        {
            quotePage.ClickGetQuote();
        }
        [Then(@"I select day for delivery and take a screenshot")]
        public void ThenISelectDayForDeliveryAndTakeAScreenshot()
        {
            Thread.Sleep(3000);
            quotePage.SelectDelivery();
        }










    }
}
