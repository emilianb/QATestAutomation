namespace FluentUITestSamples.StepDefinition
{
    using Page;
    using Specflow.FluentAutomation.Ext;
    using TechTalk.SpecFlow;

    [Binding]
    public class SearchStepDefinition
    {
        [Given(@"I navigated to Amazon home page")]
        public void NavigatedToAmazonHomePage()
        {
            // navigate to HomePage url
            Pages.Get<HomePage>().Go();
        }

        [When(@"I search for author ""(.*)""")]
        public void SearchForAuthor(string authorName)
        {
            // check that we are on the right page
            Pages.Get<HomePage>().At();

            // enter the text to search for and submit the form
            Pages.Get<HomePage>().Search(authorName);
        }

        [Then(@"the first result on the screen should be ""(.*)""")]
        public void ValidateFirstResultHeading(string expectedHeading)
        {
            // check that we are on the right page
            Pages.Get<ResultsPage>().At();

            // verify if our expectations are met
            Pages.Get<ResultsPage>().ValidateFirstResultHeading(expectedHeading);
        }
    }
}
