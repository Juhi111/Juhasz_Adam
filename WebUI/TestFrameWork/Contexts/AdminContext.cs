using OpenQA.Selenium;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class AdminContext
    {
        private readonly AdminPage _adminPage;
        private readonly IWebDriver _driver;
        public AdminContext(IWebDriver driver)
        {
            _adminPage = new AdminPage(driver);
            _driver = driver;
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
