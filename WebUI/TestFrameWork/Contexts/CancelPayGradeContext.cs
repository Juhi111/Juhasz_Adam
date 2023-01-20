using OpenQA.Selenium;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class CancelPayGradeContext
    {
        private readonly IWebDriver _driver;
        private readonly PayGradePage _payGradepage;
        private readonly AddPayGradePage _addPayGradePage;
        private readonly AddPayGradeContext _addPayGradeContext;
        private const string MinimumSalary = "10";
        private const string MaximumSalary = "100";

        public CancelPayGradeContext(IWebDriver driver)
        {
            _driver = driver;
            _payGradepage = new PayGradePage(driver);
            _addPayGradePage = new AddPayGradePage(driver);
            _addPayGradeContext = new AddPayGradeContext(driver);
        }

        public void AddCurrencyAndCancel()
        {
            _payGradepage.AddButton.Click();
            _addPayGradeContext.FillTheTextBoxAndSave();
            _addPayGradePage.AddButton.Click(); //asdad
            _addPayGradePage.SelectedCurrency.SendKeys("hhhh\n");
            _addPayGradePage.MinimumSalary.SendKeys(MinimumSalary);
            _addPayGradePage.Maximumsalary.SendKeys(MaximumSalary);
            _addPayGradePage.CancelButton.Click();
        }

        public string CheckTheDataIsNotVisible()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/admin/viewPayGrades");            
            var valamiLista = _payGradepage.PayGradesPageAll.GetAttribute("innerText");
            return valamiLista;
        }

    }
}
