using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using US.Mobile.Tests.Components;

namespace US.Mobile.Tests.Pages.Android
{
    internal class LoginPage : AndroidBasePage
    {
        public Input LoginInput { get; private set; }
        public Input PasswordInput { get; private set; }
        public Button LogInButton { get; private set; }

        public LoginPage(IWebDriver driver) : base(driver, "mydemoapprn://login")
        {
            LoginInput = new Input(Driver, MobileBy.AccessibilityId("Username input field"));
            PasswordInput = new Input(Driver, MobileBy.AccessibilityId("Password input field"));
            LogInButton = new Button(Driver, MobileBy.AccessibilityId("Login button"));
        }

        public void MoveToLoginPage() => MoveToPageDeepLink();
    }
}
