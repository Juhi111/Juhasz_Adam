using OpenQA.Selenium;
using TestFrameWork.Helpers;

namespace TestFrameWork.Pages
{
    public class AdminPage : DefaultPage
    {
        public AdminPage(IWebDriver driver) :base(driver){}   
        public IWebElement JobMenuItem => _driver.FindElement(By.CssSelector("li:nth-of-type(2) > .oxd-topbar-body-nav-tab-item"));
        public IWebElement PayGradesMenuItem => _driver.FindElement(By.CssSelector("li:nth-of-type(2) > a[role='menuitem']"));
    }
}
