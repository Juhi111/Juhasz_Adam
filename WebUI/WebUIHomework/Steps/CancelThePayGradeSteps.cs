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
        private readonly AddPayGradeContext _addPayGradeContext;

        public CancelThePayGradeSteps(ScenarioContext context)
        {
            _driver = context.Get<IWebDriver>("Driver");
            _cancelPayGradeContext = new CancelPayGradeContext(_driver);
            _addPayGradeContext = new AddPayGradeContext(_driver);
        }

        [When(@"I add a new record but instead of saving, cancel it")]
        public void WhenIAddANewRecordButInsteadOfSavingCancelIt()
        {
            _cancelPayGradeContext.AddCurrencyAndCancel();
        }

        [Then(@"it shouldnt be on the PayGrade page")]
        public void ThenItShouldntBeOnThePayGradePage()
        {
            
            bool cont = _cancelPayGradeContext.CheckTheDataIsNotVisible().Contains("RandomName");
            bool notCont = _cancelPayGradeContext.CheckTheDataIsNotVisible().Contains("Haitian Gourde");

            cont.Should().BeTrue();
            notCont.Should().NotBe(true, "Because canceled the action"); // Couldnt really figure out how should i test it, so this is the result. I know its ugly. Please let me know a better way.
        }





    }
}
