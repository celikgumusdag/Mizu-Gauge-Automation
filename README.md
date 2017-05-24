# Mizu-Gauge-Automation

Description
------------
Simple implementation of ThoughtWorks Inc. Test Automation Framework "Gauge" with using C#.

About
------------
This example project helps you understand Gauge Framework with Selenium in C# language.

More information about gauge in this webpage: https://www.getgauge.io

More information about selenium in this webpage: http://www.seleniumhq.org

Usage
------------
For compile this project you need to use Visual Studio 2012 or more. (Which is support .Net Framework version 4.5.1)

You can open project by double click solution file (Mizu-Gauge-Automation.sln) or Visual Studio -> File -> Open -> Project/Solution

For running the test cases you need to add "Gauge plugin for VisualStudio" extension from the menu Tools -> Extensions and Updates :

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/extension.PNG)

After the download this extension you can see and execute Test Cases from the menu Test -> Windows -> Test Explorer :

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/test-explorer.PNG)

When you are complete to executing the test, Gauge Framework will create a report directory and report html file such as:

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/report.PNG)

Project Structure
------------
Under the solution "Mizu-Gauge-Automation" there are 4 types of packages they are:

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/project.PNG)

#### Env

This package include properties of Gauge project such as gauge report directory, overwrite existing report, screenshot on failure, log directory, selected browser etc.

#### Helpers

This package include critical classes for the automation such as DriverFactory.cs

In DriverFactory.cs, project bringing the setting about Webdriver and implement it.

This settings are Browser type and options about the browser.(capabilities)

For example you can change the value of "Browser" in environment value as chrome, firefox or ie.

#### Specs

This package include files which is written in Gauge Business language. Type of file is ending with ".spec"

Main purpose of writing with Gauge spec language is make the automation with an employee who has low know-how in software languages.

For Example:

```gherkin
Login
==========================

This automation for login test steps.

* Go to "http://www.mizu.com"
* I see url is "https://www.mizu.com/"
* Click ".header__login" element
* I see url is "https://www.mizu.com/uyelik"

Invalid Login
-----------

* Fill ".login__left #Email" as "invalidmail@example.com"
* Fill ".login__left #Password" as "invalidpassword"
* Click ".login__btn-member" element
* I see url is "https://www.mizu.com/uyelik"

Valid Login
-----------

* Fill ".login__left #Email" as "validmail@example.com"
* Fill ".login__left #Password" as "validpassword"
* Click ".login__btn-member" element
* I see url is "https://www.mizu.com/"
```

#### Steps

This include code-behind part of Gauge spec language which is written C#.

Such as initialize driver, closing driver, opening new page, click element in the page, fill textbox in the page etc.

FluentAssertions performing in this classes.

Example Assertion:
```csharp
[Step("I see url is <url>")]
public void ISeeUrlIs(string url)
{
    string current = _driver.Url;
    current.Should().Be(url);
}
```

NuGet Packages
------------

##### What is NuGet?

NuGet is the package manager for the Microsoft development platform including .NET. The NuGet client tools provide the ability to produce and consume packages. The NuGet Gallery is the central package repository used by all package authors and consumers.

In this project there are only use 3 packages: Gauge, Selenium, FluentAssertions

```xml
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Selenium.WebDriver" version="3.4.0" targetFramework="net451" />
  <package id="Gauge.CSharp.Lib" version="0.6.1" targetFramework="net451" />
  <package id="FluentAssertions" version="4.19.2" targetFramework="net451" />
</packages>
```
##### Gauge
Gauge is a light-weight cross-platform test automation tool with the ability to author test cases in the business language.  It uses markdown to author test cases and scenarios. Its modular architecture makes it flexible and scalable.

##### Selenium
Selenium is a set of different software tools each with a different approach to supporting browser automation. These tools are highly flexible, allowing many options for locating and manipulating elements within a browser, and one of its key features is the support for automating multiple browser platforms. This package contains the .NET bindings for the newer, more concise and object-based Selenium WebDriver API, which uses native OS-level events to manipulate the browser, bypassing the JavaScript sandbox, and does not require the Selenium Server to automate the browser.

##### FluentAssertions
FluentAssertions is a very extensive set of extension methods that allow you to more naturally specify the expected outcome of a TDD or BDD-style unit test. 

Help
------------
If you got any questions don't hesitate to contact with me: [celikgumusdag@gmail.com](mailto:celikgumusdag@gmail.com)

License
------------
This repository is open source software provided under the Apache License 2.0. 

This documentation and other similar content use the Creative Commons Attribution 3.0 Unported license. 

Most libraries and tools in the ecosystem are also open source, but they may use different licenses.



[![Gauge Badge](http://getgauge.io/Gauge_Badge.svg)](http://getgauge.io)
