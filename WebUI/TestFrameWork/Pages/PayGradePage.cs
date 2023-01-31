using OpenQA.Selenium;
using TestFrameWork.Helpers;

namespace TestFrameWork.Pages
{
    public class PayGradePage : DefaultPage
    {
        public PayGradePage(IWebDriver driver) : base(driver){}
        public IWebElement AddButton => _driver.FindElement(By.CssSelector(".oxd-button.oxd-button--medium.oxd-button--secondary"));
        public IWebElement PayGradesPageAll => _driver.FindElement(By.XPath("//div[@class='oxd-table']"));
        public IWebElement DeleteButton => _driver.FindElement(By.CssSelector("[role] .--mobile:nth-of-type(6) .oxd-table-cell-actions [type='button']:nth-of-type(1)"));
        public IWebElement DeleteComfirmButton => _driver.FindElement(By.CssSelector(".orangehrm-button-margin.oxd-button.oxd-button--label-danger.oxd-button--medium"));
    }
}
