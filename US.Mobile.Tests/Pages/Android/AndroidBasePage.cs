using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace US.Mobile.Tests.Pages.Android
{
    internal class AndroidBasePage
    {
        protected IWebDriver Driver;
        protected string DeepLink;

        protected AndroidBasePage(IWebDriver driver, string deepLink)
        {
            Driver = driver;
            DeepLink = deepLink;
        }

        protected void MoveToPageDeepLink()
        {
            ((AndroidDriver<AndroidElement>)Driver).ExecuteScript("mobile:deepLink", new Dictionary<string, string> { { "url", DeepLink }, { "package", "com.saucelabs.mydemoapp.rn" } });
        }
    }
}
