namespace UITestSamples.Page
{
    using FluentAssertions;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;
    using System.Collections.Generic;
    using System.Linq;

    public class ResultsPage
    {
        private readonly IWebDriver driver;

        public ResultsPage(IWebDriver driver)
        {
            // set the driver
            this.driver = driver;

            // initialize page elements
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How= How.CssSelector, Using= "h2[data-attribute]")]
        public IList<IWebElement> SearchResultHeadings { get; set; }

        public void ValidateFirstResultHeading(string expectedHeadingText)
        {
            // get the actual heading text for the first result
            var actualHeadingText = SearchResultHeadings.First().Text;

            // verify expectations
            actualHeadingText.Should().Be(expectedHeadingText);
        }
    }
}
