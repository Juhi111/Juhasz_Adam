using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class BaseContext
    {
        private readonly BasePage _basePage;
        private readonly IWebDriver _driver;
        public BaseContext(IWebDriver driver)
        {
            _basePage = new BasePage(driver);
            _driver = driver;
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
