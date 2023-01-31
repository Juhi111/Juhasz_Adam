using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestFrameWork.Contexts;

namespace WebUIHomework.Steps
{
    [Binding]
    public class AddANewRecordSteps
    {
        private readonly IWebDriver _driver;        
        private readonly BaseContext _baseContext;
        private readonly AdminContext _adminContext;
        private readonly PayGradeContext _payGradeContext;
        private readonly AddPayGradeContext _addPayGradeContext;
        private readonly CurrencyBlockContext _currencyBlockContext;
        public AddANewRecordSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _currencyBlockContext = new CurrencyBlockContext(_driver);
            _addPayGradeContext = new AddPayGradeContext(_driver);
            _payGradeContext = new PayGradeContext(_driver);            
            _adminContext = new AdminContext(_driver);
            _baseContext = new BaseContext(_driver);
        }
        [When(@"i navigate to AdminPage")]
        public void WhenINavigateToAdminPage()
        {
            _baseContext.ClickToAdmin();
        }
        [When(@"i navigate to PayGrades")]
        public void WhenINavigateToPayGrades()
        {
            _adminContext.ClickOnJobMenuItem();
            _adminContext.ClickOnPayGradesMenuItem();
        }
        [When(@"i add a new record and save it")]
        public void WhenIAddANewRecordAndSaveIt()
        {            
            _payGradeContext.ClickAddButton();
            _addPayGradeContext.FillTheTextBoxAndSave();
            _addPayGradeContext.AddCurrencyAndSave();
        }
        [Then(@"its should be in the Currencies block")]
        public void ThenItsShouldBeInTheCurrenciesBlock()
        {    
            _currencyBlockContext.MinimumSalary().Should().Contain("10");
            _currencyBlockContext.MaximumSalary().Should().Contain("100");
        }
    }
}
