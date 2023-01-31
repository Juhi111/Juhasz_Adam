using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWork.Helpers
{
    public abstract class DefaultContext
    {
        internal readonly IWebDriver _driver;
        public DefaultContext(IWebDriver driver)
        {
            _driver = driver;
        }

    }
}
