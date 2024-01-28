using FluentAssertions;
using US.Mobile.Tests.Helpers;
using US.Mobile.Tests.Pages.iOS;

namespace US.Mobile.Tests.Tests.iOS
{
    [Parallelizable(ParallelScope.All)]
    public class IOSTests : IOSTestBase
    {
        [Test]
        public void WhenUserLogIn_ShouldLogin()
        {
            Driver = SauceLabsHelper.CreateIOSConnection(AppVersion, HubUrl, TestContext.CurrentContext.Test.Name);

            var loginPage = new LoginPage(Driver);

            loginPage.MoveToLoginPage();
            loginPage.LoginInput.SendKeys("bob@example.com");
            loginPage.PasswordInput.SendKeysWithEnter("10203040");
            loginPage.LogInButton.Click();

            var checkoutAddressPage = new CheckoutAddressPage(Driver);

            checkoutAddressPage.CheckoutText.IsDiplayed().Should().BeTrue();
        }

        [Test]
        public void WhenUserAddsProduct_ShouldBeAdded()
        {
            Driver = SauceLabsHelper.CreateIOSConnection(AppVersion, HubUrl, TestContext.CurrentContext.Test.Name);

            var productPage = new ProductsPage(Driver);
            productPage.Products.Click(0);

            var productDetailsPage = new ProductDetailsPage(Driver);
            productDetailsPage.MoveToAddToCartButton();
            productDetailsPage.AddToCartButton.Click();
            productDetailsPage.Footer.ShoppingCartButton.GetText().Should().Be("1");
        }
    }
}
