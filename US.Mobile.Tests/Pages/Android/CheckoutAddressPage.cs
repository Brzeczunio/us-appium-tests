using OpenQA.Selenium;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.Android
{
    internal class CheckoutAddressPage : AndroidBasePage
    {
        public TextField CheckoutText { get; private set; }

        public CheckoutAddressPage(IWebDriver driver) : base(driver, "mydemoapprn://checkout-address")
        {
            CheckoutText = new TextField(Driver, By.XPath("//android.widget.TextView[@text=\"Checkout\"]"));
        }

        public void MoveToCheckoutAddressPage() => MoveToPageDeepLink();
    }
}
