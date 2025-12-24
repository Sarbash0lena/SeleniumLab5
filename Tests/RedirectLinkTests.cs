using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class RedirectLinkTests : BaseTest
    {
        [Test]
        public void RedirectToStatusCodes()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/redirector");

            driver.FindElement(By.Id("redirect")).Click();

            Assert.That(driver.Url, Does.Contain("status_codes"));
        }
    }
}
