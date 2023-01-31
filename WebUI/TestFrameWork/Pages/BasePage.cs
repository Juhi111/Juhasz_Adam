using OpenQA.Selenium;
using TestFrameWork.Helpers;

namespace TestFrameWork.Pages
{
    public class BasePage : DefaultPage
    {
        public BasePage(IWebDriver driver) :base(driver){}
        public IWebElement SearchTextField => _driver.FindElement(By.CssSelector(".oxd-input"));
        public IWebElement AdminMenuItem => _driver.FindElement(By.CssSelector(".oxd-main-menu-item"));
    }
}
