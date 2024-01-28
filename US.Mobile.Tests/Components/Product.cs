using OpenQA.Selenium;
using US.Mobile.Tests.Extensions;

namespace US.Mobile.Tests.Components
{
    internal class Products
    {
        private IWebDriver _driver;
        private By _by;

        public Products(IWebDriver driver, By by)
        {
            _driver = driver;
            _by = by;
        }

        public void Click(int element) => _driver.WaitForPresenceOfAllElements(_by).ElementAt(element).Click();
        public List<string> GetTexts() => _driver.WaitForPresenceOfAllElements(_by).Select(x => x.Text).ToList();
    }
}
