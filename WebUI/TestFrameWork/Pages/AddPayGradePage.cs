using OpenQA.Selenium;

namespace TestFrameWork.Pages
{
    public class AddPayGradePage
    {
        private readonly IWebDriver _driver;

        public AddPayGradePage(IWebDriver driver)
        {
            _driver = driver;  
        }

        public IWebElement NameTextBox => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div/div/div[2]/input"));
        public IWebElement SaveButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]"));
        public IWebElement AddButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/div/div[1]/div/button"));
        public IWebElement SelectedCurrency => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[1]/div/div/div/div[2]/div/div/div[1]")); // possibly wrong, cause selection
        public IWebElement MinimumSalary => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[2]/div/div[1]/div/div[2]/input"));
        public IWebElement Maximumsalary => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[2]/div/div[2]/div/div[2]/input"));
        public IWebElement SaveButton2 => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[3]/button[2]"));
        public IWebElement CancelButton => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div[2]/form/div[3]/button[1]"));

    }
}
