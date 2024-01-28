using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace US.Mobile.Tests.Tests
{
    public class TestBase : ConfigurationBase
    {
        protected IWebDriver Driver;

        [TearDown]
        public void Teardown()
        {
            if (Driver == null) return;

            var isTestPassed = TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed;
            ((IJavaScriptExecutor)Driver).ExecuteScript("sauce:job-result=" + (isTestPassed ? "passed" : "failed"));
            Driver.Dispose();
        }
    }
}
