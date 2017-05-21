namespace FluentUITestSamples.Page
{
    using FluentAutomation;

    public class HomePage : PageObject<HomePage>
    {
        public HomePage(FluentTest test)
            : base(test)
        {
            // the url of the page
            Url = @"http://www.amazon.com/";
            // the element to search for to make sure we are on the right page
            At = () => I.Expect.Exists("#twotabsearchtextbox");
        }

        public void Search(string textToSearchFor)
        {
            // enter text to search for in search textbox
            I.Enter(textToSearchFor).In("#twotabsearchtextbox");
            // press enter to submit form
            I.Press("{ENTER}");
        }
    }
}
