using OpenQA.Selenium;
using US.Mobile.Tests.Extensions;

namespace US.Mobile.Tests.Components
{
    internal class Input
    {
        private IWebDriver _driver;
        private By _by;

        public Input(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void SendKeys(string text) => _driver.WaitForVisible(_by).SendKeys(text);
        public void SendKeysWithEnter(string text) => _driver.WaitForVisible(_by).SendKeys(text + "\n");
    }
}
