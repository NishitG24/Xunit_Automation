using FluentAssertions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Xunit_Automation.Test
{
    public class LoginToOrangeHRMTest : IClassFixture<WebDriverFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly WebDriverFixture _webDriverFixture;

         public LoginToOrangeHRMTest(ITestOutputHelper testOutputHelper,WebDriverFixture webDriverFixture)
        {
            this._testOutputHelper = testOutputHelper;
            this._webDriverFixture = webDriverFixture;
        }

        [Fact]
        public void Test_Login_to_Orange_HRM()
        {
            _testOutputHelper.WriteLine("Intiating the Orange HRM Url to login into the page");
            _webDriverFixture.chromeDriver.Manage().Window.Maximize();
            _webDriverFixture.chromeDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            _webDriverFixture.chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _webDriverFixture.chromeDriver.FindElement(By.CssSelector("input[placeholder='Username']")).SendKeys("Admin");
            _webDriverFixture.chromeDriver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("admin123");
            _webDriverFixture.chromeDriver.FindElement(By.CssSelector("button[type='submit']")).Click();
            string actualUserName = _webDriverFixture.chromeDriver.FindElement(By.CssSelector("span[class*='userdropdown']")).Text;
            _testOutputHelper.WriteLine(actualUserName);
            _webDriverFixture.chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            actualUserName.Should().BeEquivalentTo("VaishnaviAkash Collings");
        }
    }
}
