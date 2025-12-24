using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class ForgotPasswordTests : BaseTest
    {
        [Test]
        public void RetrievePasswordMessageIsDisplayed()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/forgot_password");

            driver.FindElement(By.Id("email")).SendKeys("test@test.com");
            driver.FindElement(By.Id("form_submit")).Click();

            var message = driver.FindElement(By.Id("content")).Text;
            Assert.That(message, Does.Contain("Your e-mail's been sent"));
        }
    }
}
