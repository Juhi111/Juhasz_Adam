using OpenQA.Selenium;

namespace TestFrameWork.Pages
{
    public class CurrencyBlock
    {
        private readonly IWebDriver _driver;
        public CurrencyBlock(IWebDriver driver)
        {
            _driver = driver;
        }
        
        //public IWebElement MinumumSalary => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div/div[3]/div/div/div/div/div/div[2]/div[1]/div"));
        public IWebElement Min => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div/div[3]/div/div/div/div/div/div[2]/div[1]/div/div[2]"));
        public IWebElement Max => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div/div[3]/div/div/div/div/div/div[2]/div[2]/div/div[2]"));
        

    }
}
