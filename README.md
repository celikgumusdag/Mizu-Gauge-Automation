# Mizu-Gauge-Automation

Description
------------
Simple implementation of Gauge Test Automation with using C#

About
------------
This example project helps you understand Gauge with Selenium in C# language.

You can find more information about gauge in this webpage: https://www.getgauge.io

You can find more information about selenium in this webpage: http://www.seleniumhq.org

Usage
------------
For compile this example you need to use Visual Studio 2012 or more. (Which is support .Net Framework version 4.5.1)

You can open project by double click solution file (Derivco-Automation-Assessment.sln) or Visual Studio -> File -> Open -> Project/Solution

For running the test cases you need to add "NUnit Test Adapter" extension from the menu Tools -> Extensions and Updates :

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/extension.PNG)

After the download this extension you can see and execute Test Cases from the menu Test -> Windows -> Test Explorer :

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/test-explorer.PNG)

When you execute the test, Gauge will create a report directory and report html file such as:

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/report.PNG)

Project Structure
------------
Under the solution "Mizu-Gauge-Automation" there are 4 types of packages they are:

-Env

-Helpers

-Specs

-Steps

![alt text](https://github.com/celikgumusdag/Mizu-Gauge-Automation/blob/master/img/project.PNG)

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
