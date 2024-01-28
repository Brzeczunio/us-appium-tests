using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.iOS.Footer
{
    internal class PageFooter
    {
        private IWebDriver _driver;
        public Button ShoppingCartButton { get; private set; }

        public PageFooter(IWebDriver driver)
        {
            _driver = driver;
            ShoppingCartButton = new Button(_driver, MobileBy.AccessibilityId("tab bar option cart"));
        }
    }
}
