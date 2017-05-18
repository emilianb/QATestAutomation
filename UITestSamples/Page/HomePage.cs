namespace UITestSamples.Page
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePage
    {
        private readonly IWebDriver driver;

        private readonly string url = @"http://www.amazon.com/";

        public HomePage(IWebDriver driver)
        {
            // set the driver
            this.driver = driver;

            // initialize page elements
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How= How.Id, Using= "twotabsearchtextbox")]
        public IWebElement SearchBox { get; set; }

        public void Navigate()
        {
            driver.Navigate().GoToUrl(url);
        }

        public void Search(string textToSearchFor)
        {
            SearchBox.Clear();
            SearchBox.SendKeys(textToSearchFor);
            SearchBox.SendKeys(Keys.Enter);
        }
    }
}
