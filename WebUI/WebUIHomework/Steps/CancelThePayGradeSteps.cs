using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestFrameWork.Contexts;

namespace WebUIHomework.Steps
{
    [Binding]
    public class CancelThePayGradeSteps
    {
        private readonly IWebDriver? _driver;
        private readonly CancelPayGradeContext _cancelPayGradeContext;
        public CancelThePayGradeSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _cancelPayGradeContext = new CancelPayGradeContext(_driver);
        }
        [When(@"I add a new record but instead of saving, cancel it")]
        public void WhenIAddANewRecordButInsteadOfSavingCancelIt()
        {
            _cancelPayGradeContext.AddCurrencyAndCancel();
        }
        [Then(@"it shouldnt be on the PayGrade page")]
        public void ThenItShouldntBeOnThePayGradePage()
        {
            _cancelPayGradeContext.CheckTheDataIsNotVisible().Should().NotContain("Hungarian Forint");
        }
    }
}
