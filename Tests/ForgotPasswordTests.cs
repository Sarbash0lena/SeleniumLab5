using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class ForgotPasswordTests : BaseTest
    {
        [Test]
        public void ForgotPasswordPageLoads()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/forgot_password");

            // перевірка заголовка сторінки
            var heading = driver.FindElement(By.TagName("h2"));
            Assert.That(heading.Text, Does.Contain("Forgot Password"));

            // перевірка кнопки Submit
            var submitBtn = driver.FindElement(By.CssSelector("button#form_submit"));
            Assert.That(submitBtn.Displayed && submitBtn.Enabled, Is.True);
        }
    }
}
