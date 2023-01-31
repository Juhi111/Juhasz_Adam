using OpenQA.Selenium;
using TestFrameWork.Helpers;
using TestFrameWork.Pages;

namespace TestFrameWork.Contexts
{
    public class CurrencyBlockContext : DefaultContext
    {
        private readonly CurrencyBlock _currencyBlock;
        public CurrencyBlockContext(IWebDriver driver) : base(driver)
        {
            _currencyBlock = new CurrencyBlock(driver);
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
