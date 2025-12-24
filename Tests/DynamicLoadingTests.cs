using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class DynamicLoadingTests : BaseTest
    {
        [Test]
        public void HelloWorldIsDisplayed()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");

            driver.FindElement(By.TagName("button")).Click();

            var text = wait!.Until(d => d.FindElement(By.Id("finish"))).Text;
            Assert.That(text, Is.EqualTo("Hello World!"));
        }
    }
}
