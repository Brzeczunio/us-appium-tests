using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;

namespace US.Mobile.Tests.Helpers
{
    internal static class SauceLabsHelper
    {
        public static IWebDriver CreateAndroidConnection(string appVesrion, string hubUrl, string testName)
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("appium:app", "storage:filename=Android-MyDemoAppRN.1.3.0.build-244.apk");
            options.AddAdditionalCapability("appium:deviceName", "Android GoogleAPI Emulator");
            options.AddAdditionalCapability("appium:platformVersion", "12.0");
            options.AddAdditionalCapability("appium:automationName", "UiAutomator2");
            options.AddAdditionalCapability("appium:newCommandTimeout", 90);
            var sauceOptions = new Dictionary<string, object>
            {
                { "username", "username" },
                { "accessKey", "accessKey" },
                { "deviceOrientation", "PORTRAIT" },
                { "appiumVersion", "2.0.0" },
                { "build", $"build-{appVesrion}" },
                { "name", testName },
            };

            options.AddAdditionalCapability("sauce:options", sauceOptions);

            var url = new Uri(hubUrl);
            return new AndroidDriver<AndroidElement>(url, options, TimeSpan.FromMinutes(5));
        }

        public static IWebDriver CreateIOSConnection(string appVesrion, string hubUrl, string testName)
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "iOS");
            options.AddAdditionalCapability("appium:app", "storage:filename=iOS-Simulator-MyRNDemoApp.1.3.0-162.zip");
            options.AddAdditionalCapability("appium:deviceName", "iPhone Simulator");
            options.AddAdditionalCapability("appium:platformVersion", "16.2");
            options.AddAdditionalCapability("appium:automationName", "XCUITest");
            options.AddAdditionalCapability("appium:newCommandTimeout", 90);
            var sauceOptions = new Dictionary<string, object>
            {
                { "username", "username" },
                { "accessKey", "accessKey" },
                { "deviceOrientation", "PORTRAIT" },
                { "appiumVersion", "2.0.0" },
                { "build", $"build-{appVesrion}" },
                { "name", $"{testName}" },
            };

            options.AddAdditionalCapability("sauce:options", sauceOptions);

            var url = new Uri(hubUrl);
            return new IOSDriver<IOSElement>(url, options, TimeSpan.FromMinutes(5));
        }
    }
}
