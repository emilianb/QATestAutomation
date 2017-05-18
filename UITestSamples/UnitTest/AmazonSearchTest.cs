namespace UITestSamples.UnitTest
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using System;

    [TestFixture]
    public class AmazonSearchTest
    {
        [Test]
        public void Search_FindResult_ResultPageIsShown()
        {
            // prepare stage

            // create a new driver instance
            var driver = new ChromeDriver();
            // set the period the driver should try to find an element before throwing an error
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // navigate to amazon page
            driver.Navigate().GoToUrl("http://www.amazon.com");
            // find search box element
            var searchInputElement = driver.FindElement(By.Id("twotabsearchtextbox"));

            // act stage

            // write down the text to search for and hit the enter key
            searchInputElement.SendKeys("Emilian Balanescu");
            searchInputElement.SendKeys(Keys.Enter);

            // assert stage

            // read the title of the first result
            var firstHeadingElement = driver.FindElement(By.CssSelector("h2[data-attribute]:first-child"));
            // verify the heading value is as expected
            Assert.AreEqual(
                "Beginning PHP and PostgreSQL E-Commerce: From Novice to Professional (Beginning, from Novice to Professional)",
                firstHeadingElement.Text);

            // close all windows and the browser
            driver.Quit();
        }
    }
}