using OpenQA.Selenium;
using TestFrameWork.Helpers;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class AdminContext : DefaultContext
    {
        private readonly AdminPage _adminPage;
        public AdminContext(IWebDriver driver) : base(driver)
        {
            _adminPage = new AdminPage(driver);
        }
        public void ClickOnJobMenuItem()
        { 
            _adminPage.JobMenuItem.Click();
        }
        public void ClickOnPayGradesMenuItem()
        {
            _adminPage.PayGradesMenuItem.Click();
        }
    }
}
