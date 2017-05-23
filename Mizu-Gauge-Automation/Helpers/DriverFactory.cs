using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GaugeProjectTemplate.Helpers
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver()
        {
            return new ChromeDriver();
        }
    }
}
