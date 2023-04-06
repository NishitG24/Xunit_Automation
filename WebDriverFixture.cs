using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xunit_Automation
{
    public class WebDriverFixture : IDisposable
    {
         public ChromeDriver chromeDriver { get; private set; }

        public WebDriverFixture()
        {
            chromeDriver = new ChromeDriver(@"D:\Selenium_Jars\chromedriver_win32\chromedriver.exe");
        }
        public void Dispose()
        {
            chromeDriver.Quit();
            chromeDriver.Dispose();
        }
    }
}
