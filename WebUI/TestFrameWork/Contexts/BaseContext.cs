using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFrameWork.Helpers;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class BaseContext : DefaultContext
    {
        private readonly BasePage _basePage;
        public BaseContext(IWebDriver driver) : base(driver)
        {
            _basePage = new BasePage(driver);
        }
        public bool IsPageLoaded()
        {
            var searchTextField = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)).Until(d => _basePage.SearchTextField); 
            return _basePage.SearchTextField != null && _basePage.SearchTextField.Displayed;
        }
        public void ClickToAdmin()
        {
            _basePage.AdminMenuItem.Click();
        }
    }
}
