using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace GaugeProjectTemplate.Helpers
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            var browser = Environment.GetEnvironmentVariable("BROWSER");
            switch (browser)
            {
                case "firefox":
                    return new FirefoxDriver();
                case "ie":
                    return new InternetExplorerDriver();
                default:
                    return new ChromeDriver();
            }
        }
    }
}
