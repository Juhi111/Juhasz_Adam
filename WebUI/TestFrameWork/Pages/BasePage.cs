using OpenQA.Selenium;

namespace TestFrameWork.Pages
{
    public class BasePage
    {
        private readonly IWebDriver _driver;
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement SearchTextField => _driver.FindElement(By.CssSelector(".oxd-input"));
        public IWebElement AdminMenuItem => _driver.FindElement(By.CssSelector(".oxd-main-menu-item"));
        

    }
}
