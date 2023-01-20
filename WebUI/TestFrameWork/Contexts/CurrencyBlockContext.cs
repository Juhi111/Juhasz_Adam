using OpenQA.Selenium;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class CurrencyBlockContext
    {
        private readonly CurrencyBlock _currencyBlock;
        private readonly IWebDriver _driver;
        public CurrencyBlockContext(IWebDriver driver)
        {
            _currencyBlock = new CurrencyBlock(driver);
            _driver = driver;
        }

        public string MinimumSalary()
        {
            var minimumSalary = _currencyBlock.Min.Text;
            return minimumSalary;
        }
        public string MaximumSalary()
        {
            var maximumSalary = _currencyBlock.Max.Text;
            return maximumSalary;
        }

    }
}
