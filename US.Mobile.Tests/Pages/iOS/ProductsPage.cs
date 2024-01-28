using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.iOS
{
    internal class ProductsPage : IOSBasePage
    {
        public Products Products { get; private set; }

        public ProductsPage(IWebDriver driver) : base(driver, "mydemoapprn://store-overview")
        {
            Products = new Products(Driver,
                MobileBy.IosClassChain("**/XCUIElementTypeOther[`name BEGINSWITH \"Sauce Labs \" && accessible = true`]"));
        }

        public void MoveToProductsPage() => MoveToPageDeepLink();
    }
}
