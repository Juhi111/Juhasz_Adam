using OpenQA.Selenium;
using TestFrameWork.Helpers;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class PayGradeContext : DefaultContext
    {
        private readonly PayGradePage _payGradePage;
        public PayGradeContext(IWebDriver driver) : base(driver)
        {
            _payGradePage = new PayGradePage(driver);
        }
        public void ClickAddButton()
        {            
            _payGradePage.AddButton.Click();
        }
        public void DeleteData()
        { 
            _payGradePage.DeleteButton.Click();
            _payGradePage.DeleteComfirmButton.Click();
        }
    }
}
