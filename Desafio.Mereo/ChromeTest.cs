using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using FluentAssertions;

namespace Desafio.Mereo
{
    public class ChromeTest : IDisposable
    {
        private readonly ChromeDriver chromeDriver;
        public ChromeTest() 
        {
            var driver = new DriverManager().SetUpDriver(new ChromeConfig());
            chromeDriver = new ChromeDriver(driver);
        }

        [Fact]
        public void ShouldIdentifyTheTitle()
        {
            chromeDriver.Navigate().GoToUrl("https://www.google.com/");
            string pageTitle = chromeDriver.Title;
            pageTitle.Should().NotBeNull(pageTitle);
            pageTitle.Should( ).Be("Google");
        }

        public void Dispose()
        {
            chromeDriver.Dispose();
        }
    }
}