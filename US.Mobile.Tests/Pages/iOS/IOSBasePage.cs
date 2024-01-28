using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;

namespace US.Mobile.Tests.Pages.iOS
{
    internal class IOSBasePage
    {
        protected IWebDriver Driver;
        protected string DeepLink;

        protected IOSBasePage(IWebDriver driver, string deepLink)
        {
            Driver = driver;
            DeepLink = deepLink;
        }

        protected void MoveToPageDeepLink()
        {
            ((IOSDriver<IOSElement>)Driver).ExecuteScript("mobile:terminateApp",
                new Dictionary<string, string>
                {
                    { "bundleId", "com.saucelabs.mydemoapp.rn" }
                });

            Driver.Navigate().GoToUrl(DeepLink);
            Driver.FindElement(MobileBy.AccessibilityId("Open")).Click();
        }
    }
}
