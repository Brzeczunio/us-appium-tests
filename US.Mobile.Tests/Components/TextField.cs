using OpenQA.Selenium;
using US.Mobile.Tests.Extensions;

namespace US.Mobile.Tests.Components
{
    internal class TextField
    {
        private IWebDriver _webDriver;
        private By _by;

        public TextField(IWebDriver webDriver, By by)
        {
            _webDriver = webDriver;
            _by = by;
        }

        public string GetText() => _webDriver.WaitForVisible(_by).Text;
        public bool IsDiplayed() => _webDriver.WaitForVisible(_by).Displayed;
    }
}
