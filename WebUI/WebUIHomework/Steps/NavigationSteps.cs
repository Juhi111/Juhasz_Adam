using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace WebUIHomework.Steps
{
    [Binding]
    public class NavigationSteps
    {
        private readonly IWebDriver? _driver;

        public NavigationSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
        }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }


    }
}
