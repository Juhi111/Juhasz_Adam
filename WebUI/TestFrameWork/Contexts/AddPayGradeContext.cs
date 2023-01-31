using OpenQA.Selenium;
using TestFrameWork.Helpers;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class AddPayGradeContext : DefaultContext
    {
        private readonly AddPayGradePage _addPayGradePage;
        private const string PayGradeName = "RandomName";
        private const string MinimumSalary = "10";
        private const string MaximumSalary = "100"; 
        public AddPayGradeContext(IWebDriver driver) : base(driver)
        {
            _addPayGradePage = new AddPayGradePage(driver);   
        }
        public void FillTheTextBoxAndSave()
        {
            _addPayGradePage.NameTextBox.SendKeys(PayGradeName);
            _addPayGradePage.SaveButton.Click();
        }
        public void AddCurrencyAndSave()
        {
            _addPayGradePage.AddButton.Click();
            _addPayGradePage.SelectedCurrency.Click();
            _addPayGradePage.SelectedCurrency.SendKeys("hhhhh\n");
            _addPayGradePage.MinimumSalary.SendKeys(MinimumSalary);
            _addPayGradePage.Maximumsalary.SendKeys(MaximumSalary);
            _addPayGradePage.SaveButton2.Click();
        }
    }
}
