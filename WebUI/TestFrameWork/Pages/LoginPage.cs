using OpenQA.Selenium;
using TestFrameWork.Helpers;

namespace TestFrameWork.Pages
{
    public class LoginPage : DefaultPage
    {
        public LoginPage(IWebDriver driver) : base(driver){}
        public IWebElement UsernameTextField => _driver.FindElement(By.CssSelector("input[name=username]"));
        public IWebElement PasswordTextField => _driver.FindElement(By.CssSelector("input[name=password]"));
        public IWebElement LoginButton => _driver.FindElement(By.CssSelector("button[class*=login]"));
    }
}
