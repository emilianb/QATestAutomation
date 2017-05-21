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
            SeleniumWebDriver.Bootstrap(new[] { SeleniumWebDriver.Browser.Chrome });

            // navigate to amazon page
            I.Open("http://www.amazon.com");

            // act stage

            // wait until page loaded
            I.WaitUntil(() => I.Expect.Exists("#twotabsearchtextbox"));

            // find search box element write down the text to search for and hit the enter key
            I.Enter("Emilian Balanescu").In("#twotabsearchtextbox");
            // press enter to submit form
            I.Press("{ENTER}");

            // assert stage

            // wait until results page loaded
            I.WaitUntil(() => I.Expect.Exists("#atfResults"));

            // read the heading of the first result and verify the value is as expected
            I.Assert
             .Text("Beginning PHP and PostgreSQL E-Commerce: From Novice to Professional (Beginning, from Novice to Professional)")
             .In("h2[data-attribute]:first-child");
        }
    }
}
