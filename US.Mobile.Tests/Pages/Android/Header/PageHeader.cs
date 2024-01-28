using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.Android.Header
{
    internal class PageHeader
    {
        private IWebDriver _driver;
        public Button ShoppingCartButton { get; private set; }
        public Button SortButton { get; private set; }
        public TextField ShoppingCartCount { get; private set; }

        public PageHeader(IWebDriver driver)
        {
            _driver = driver;
            ShoppingCartCount = new TextField(_driver, By.XPath("(//android.widget.TextView)[1]"));
            SortButton = new Button(_driver, By.XPath("//android.view.ViewGroup[@content-desc=\"sort button\"]/android.widget.ImageView"));
            ShoppingCartButton = new Button(_driver, MobileBy.AccessibilityId("cart badge"));
        }
    }
}
