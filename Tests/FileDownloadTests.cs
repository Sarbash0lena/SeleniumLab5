using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class FileDownloadTests : BaseTest
    {
        [Test]
        public void FileLinkIsClickable()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");

            var fileLink = driver.FindElement(By.CssSelector("#content a"));
            Assert.That(fileLink.Displayed, Is.True);
        }
    }
}
