using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestFrameWork.Contexts;

namespace WebUIHomework.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver? _driver;
        private readonly LoginContext _loginContext;
        private const string UserName = "Admin";
        private const string PassWord = "admin123";
        public LoginSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _loginContext = new LoginContext(_driver);
        }
        [When(@"I login as admin user")]
        public void WhenILoginAsAdminUser()
        {
            _loginContext.Login(UserName, PassWord);
        }
    }
}
