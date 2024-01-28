using OpenQA.Selenium;
using US.Mobile.Tests.Pages.Android.Header;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.Android
{
    internal class ShoppingCartPage : AndroidBasePage
    {
        public Button RemoveItemButton { get; private set; }
        public TextField NoItemsField { get; private set; }
        public PageHeader Header { get; private set; }

        public ShoppingCartPage(IWebDriver driver) : base(driver, string.Empty)
        {
            RemoveItemButton = new Button(Driver, By.XPath("//android.widget.TextView[@text=\"Remove Item\"]"));
            NoItemsField = new TextField(Driver, By.XPath("//android.widget.TextView[@text=\"No Items\"]"));
            Header = new PageHeader(Driver);
        }
    }
}
