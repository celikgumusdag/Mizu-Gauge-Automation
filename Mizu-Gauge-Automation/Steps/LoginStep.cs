using Gauge.CSharp.Lib.Attribute;
using GaugeProjectTemplate.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace GaugeProjectTemplate.Steps
{
    public class LoginStep
    {
        private IWebDriver _driver;

        [BeforeSuite]
        public void Initialize()
        {
            _driver = DriverFactory.GetDriver();
            _driver.Manage().Window.Maximize();
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

        [Step("I see url is <url>")]
        public void ISeeUrlIs(string url)
        {
            string current = _driver.Url;
            current.Should().Be(url);
        }
    }
}