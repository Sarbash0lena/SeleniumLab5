using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class BasicAuthTests : BaseTest
    {
        [Test]
        public void SuccessfulAuthorization()
        {
            driver!.Navigate().GoToUrl("https://admin:admin@the-internet.herokuapp.com/basic_auth");

            var text = driver.FindElement(By.TagName("p")).Text;
            Assert.That(text, Does.Contain("Congratulations"));
        }
    }
}
