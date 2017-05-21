namespace UITestSamples.StepDefinition
{
    using Page;
    using TechTalk.SpecFlow;

    [Binding]
    public class SearchStepDefinition
    {
        [Given(@"I navigated to Amazon home page")]
        public void NavigatedToAmazonHomePage()
        {
            Pages.Get<HomePage>().Navigate();
        }

        [When(@"I search for author ""(.*)""")]
        public void SearchForAuthor(string authorName)
        {
            Pages.Get<HomePage>().Search(authorName);
        }

        [Then(@"the first result on the screen should be ""(.*)""")]
        public void ValidateFirstResultHeading(string expectedHeading)
        {
            Pages.Get<ResultsPage>().ValidateFirstResultHeading(expectedHeading);
        }
    }
}
