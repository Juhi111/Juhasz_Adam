using OpenQA.Selenium;
using TestFrameWork.Helpers;

namespace TestFrameWork.Pages
{
    public class CurrencyBlock : DefaultPage
    {
        public CurrencyBlock(IWebDriver driver) :base(driver){}
        public IWebElement Min => _driver.FindElement(By.XPath("//div[contains(text(),'10.00')]"));
        public IWebElement Max => _driver.FindElement(By.XPath("//div[contains(text(),'100.00')]"));
    }
}
