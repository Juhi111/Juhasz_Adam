using OpenQA.Selenium;
using TestFrameWork.Helpers;

namespace TestFrameWork.Pages
{
    public class AddPayGradePage : DefaultPage
    {
        public AddPayGradePage(IWebDriver driver) : base(driver){}
        public IWebElement NameTextBox => _driver.FindElement(By.CssSelector(".oxd-form-row .oxd-input"));
        public IWebElement SaveButton => _driver.FindElement(By.CssSelector(".orangehrm-left-space.oxd-button.oxd-button--medium.oxd-button--secondary"));
        public IWebElement AddButton => _driver.FindElement(By.CssSelector(".orangehrm-action-header .oxd-button--secondary"));
        public IWebElement SelectedCurrency => _driver.FindElement(By.XPath("//div[contains(text(),'-- Select --')]")); 
        public IWebElement MinimumSalary => _driver.FindElement(By.CssSelector(".oxd-layout-context .orangehrm-card-container:nth-of-type(2) .oxd-grid-item--gutters:nth-of-type(1) input"));
        public IWebElement Maximumsalary => _driver.FindElement(By.CssSelector("div:nth-of-type(2) > .oxd-input-field-bottom-space.oxd-input-group > div:nth-of-type(2) > .oxd-input"));
        public IWebElement SaveButton2 => _driver.FindElement(By.CssSelector(".oxd-layout-context > .orangehrm-card-container > .oxd-form  .orangehrm-left-space.oxd-button.oxd-button--medium.oxd-button--secondary"));
        public IWebElement CancelButton => _driver.FindElement(By.CssSelector(".oxd-layout-context > .orangehrm-card-container > .oxd-form  .oxd-button.oxd-button--ghost.oxd-button--medium")); //ide kell új locator
    }
}
