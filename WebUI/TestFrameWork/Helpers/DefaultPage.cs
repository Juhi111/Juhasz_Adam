using OpenQA.Selenium;
namespace TestFrameWork.Helpers
{
    abstract public class DefaultPage
    {
        internal readonly IWebDriver _driver;
        internal DefaultPage(IWebDriver driver )
        {
            _driver = driver;
        }
    }
}
