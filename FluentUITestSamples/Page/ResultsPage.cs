namespace FluentUITestSamples.Page
{
    using FluentAutomation;

    public class ResultsPage : PageObject<ResultsPage>
    {
        public ResultsPage(FluentTest test)
            : base(test)
        {
            // the element to search for to make sure we are on the right page
            At = () => I.Expect.Exists("#atfResults");
        }

        public void ValidateFirstResultHeading(string expectedHeadingText)
        {
            // verify expectations
            var actualHeadingText = I.Find("h2[data-attribute]:first-child").Element.Text;

            // read the heading of the first result and verify the value is as expected
            I.Assert.True(() => actualHeadingText == expectedHeadingText);
        }
    }
}