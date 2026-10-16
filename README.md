# Desafio.Mereo

Technical challenge: a UI test in **C#** using **Selenium WebDriver**, **xUnit** and **FluentAssertions**.

## What it does

`ChromeTest.ShouldIdentifyTheTitle` opens Google in Chrome and asserts that the page title is `Google`. The driver is downloaded automatically by **WebDriverManager** and released through `IDisposable` after each test.

## Stack

- .NET 6
- Selenium WebDriver 4.14
- xUnit 2.4
- FluentAssertions 6.12
- WebDriverManager 2.17

## Running

```bash
dotnet test
```

Requires the .NET 6 SDK and Google Chrome.
