using OpenQA.Selenium;

namespace TestFrameWork.Pages
{
    public class AdminPage
    {

        private readonly IWebDriver _driver;
        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
        }       
        
        public IWebElement JobMenuItem => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/span"));
        
        public IWebElement PayGradesMenuItem => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[2]/nav/ul/li[2]/ul/li[2]/a"));
    }
}
