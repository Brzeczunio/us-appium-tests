using OpenQA.Selenium;
using US.Mobile.Tests.Components;
using US.Mobile.Tests.Pages.Android.Header;

namespace US.Mobile.Tests.Pages.Android
{
    internal class ProductsPage : AndroidBasePage
    {
        public Products Products { get; private set; }
        public PageHeader Header { get; private set; }

        public ProductsPage(IWebDriver driver) : base(driver, "mydemoapprn://store-overview")
        {
            Products = new Products(Driver,
                By.XPath("(//android.view.ViewGroup[@content-desc=\"store item\"])[*]/android.view.ViewGroup[*]/android.widget.ImageView"));
            Header = new PageHeader(Driver);
        }

        public void MoveToProductsPage() => MoveToPageDeepLink();
    }
}