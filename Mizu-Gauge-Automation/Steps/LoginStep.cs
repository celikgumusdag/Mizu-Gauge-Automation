using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeProjectTemplate.Steps
{
    public class LoginStep
    {
        private IWebDriver _driver;

        [BeforeSuite]
        public void Initialize()
        {
            _driver = DriverFactory.GetDriver();
        }

        [AfterSuite]
        public void Cleanup()
        {
            _driver.Quit();
        }

        [Step("Go to <url>")]
        public void NavigateTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [Step("Click <css> element")]
        public void ClickElement(string css)
        {
            var element = _driver.FindElement(By.CssSelector(css));
            element.Click();
        }

        [Step("Fill <css> as <text>")]
        public void ClickElementAs(string css, string text)
        {
            var element = _driver.FindElement(By.CssSelector(css));
            element.Clear();
            element.SendKeys(text);
        }
    }
}