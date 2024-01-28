using OpenQA.Selenium;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.Android
{
    internal class SortingProductPage : AndroidBasePage
    {
        public Button DescendingButton { get; private set; }

        public SortingProductPage(IWebDriver driver) : base(driver, "mydemoapprn://checkout-address")
        {
            DescendingButton = new Button(Driver, By.XPath("//android.widget.TextView[@text=\"Name - Descending\"]"));
        }
    }
}