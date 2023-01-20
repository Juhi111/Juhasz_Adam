using OpenQA.Selenium;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class LoginContext
    {
        private readonly LoginPage _loginPage;
        public LoginContext(IWebDriver driver)
        {
            _loginPage = new LoginPage(driver);
        }

        public void Login(string username, string password)
        {
            _loginPage.UsernameTextField.SendKeys(username);
            _loginPage.PasswordTextField.SendKeys(password);
            _loginPage.LoginButton.Click();
        }

    }
}
