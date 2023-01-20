using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestFrameWork.Contexts;

namespace WebUIHomework
{
    [Binding]
    public class Hooks
    {
        private readonly IWebDriver? _driver;
        private readonly ScenarioContext _scenarioContext;
        private readonly PayGradeContext _payGradeContext;

        public Hooks(ScenarioContext context)
        {
            _driver = new ChromeDriver();
            _scenarioContext = context;
            _payGradeContext = new PayGradeContext(_driver);
        }

        [BeforeScenario]
        public void StartDriver()
        {            
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
            _scenarioContext["Driver"] = _driver;
        }

        [AfterScenario]

        public void DeleteData()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewPayGrades");
            _payGradeContext.DeleteData();

        }

        [AfterScenario]
        public void StopDriver()
        {
            _driver.Close();
            _driver.Dispose();           
        }

    }
}
