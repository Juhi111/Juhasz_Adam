using OpenQA.Selenium;

namespace TestFrameWork.Pages
{
    public class PayGradePage
    {
        private readonly IWebDriver _driver;
        
        public PayGradePage(IWebDriver driver)
        {
            _driver = driver;
        }        
        public IWebElement AddButton => _driver.FindElement(By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div.orangehrm-header-container > div > button"));
        public IWebElement PayGrades => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[3]"));
        public IWebElement PayGradesPageAll => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[3]/div"));
        public IWebElement DeleteButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div[3]/div/div/div[6]/div/div/div[1]/div[2]/div/div/button[1]"));
        public IWebElement DeleteComfirmButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[3]/div/div/div/div[3]/button[2]"));

    }
}
