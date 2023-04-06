using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;
using Xunit.Abstractions;
using OpenQA.Selenium;
using System.Threading;

namespace Xunit_Automation
{
    public class SeleniumWithoutContext
    {
        private readonly ITestOutputHelper testOutputHelper;
        private readonly ChromeDriver chromeDriver;
        public SeleniumWithoutContext(ITestOutputHelper testOutputHelper) {
            this.testOutputHelper = testOutputHelper;
            //var driver = new DriverManager().SetUpDriver(new ChromeConfig(),"109.0.5414.129");
            chromeDriver = new ChromeDriver(@"D:\Selenium_Jars\chromedriver_win32\chromedriver.exe");
        }

        [Fact]
        public void Test() {
           
        }
    }
}
