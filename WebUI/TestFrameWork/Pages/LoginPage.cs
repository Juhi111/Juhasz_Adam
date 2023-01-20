using OpenQA.Selenium;

namespace TestFrameWork.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement UsernameTextField => _driver.FindElement(By.CssSelector("input[name=username]"));
        public IWebElement PasswordTextField => _driver.FindElement(By.CssSelector("input[name=password]"));
        public IWebElement LoginButton => _driver.FindElement(By.CssSelector("button[class*=login]"));

    }
}
