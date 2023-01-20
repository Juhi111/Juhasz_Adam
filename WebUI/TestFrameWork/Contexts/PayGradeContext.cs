using OpenQA.Selenium;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class PayGradeContext
    {
        
        private readonly PayGradePage _payGradePage;
        private readonly IWebDriver _driver;
        public PayGradeContext(IWebDriver driver)
        {
            _payGradePage = new PayGradePage(driver);
            _driver = driver;
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
