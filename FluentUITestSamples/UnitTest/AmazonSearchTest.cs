namespace UITestSamples.UnitTest
{
    using FluentAutomation;
    using NUnit.Framework;

    [TestFixture]
    public class AmazonSearchTest : FluentTest
    {
        [Test]
        public void Search_FindResult_ResultPageIsShown()
        {
            // prepare stage

            // bootstrap webdriver
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.InternetExplorer);

            // navigate to amazon page
            I.Open("http://www.amazon.com");

            // act stage

            // find search box element write down the text to search for and hit the enter key
            I.Enter("Emilian Balanescu{ENTER}").In("#twotabsearchtextbox");

            // assert stage

            // read the heading of the first result and verify the value is as expected
            I.Assert
             .Text("Beginning PHP and PostgreSQL E-Commerce: From Novice to Professional (Beginning, from Novice to Professional)")
             .In("h2[data-attribute]:first-child");
        }
    }
}