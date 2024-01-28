using OpenQA.Selenium;
using US.Mobile.Tests.Extensions;

namespace US.Mobile.Tests.Components
{
    internal class Button
    {
        private IWebDriver _driver;
        private By _by;

        public Button(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void Click() => _driver.WaitForClickable(_by).Click();
        public string GetText() => _driver.WaitForClickable(_by).Text;
    }
}
