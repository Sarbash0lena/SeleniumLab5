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

            // очікуємо поки елемент з’явиться та текст стане ненульовим
            var finishElement = wait!.Until(d =>
            {
                var elem = d.FindElement(By.Id("finish"));
                return elem.Displayed && !string.IsNullOrEmpty(elem.Text) ? elem : null;
            });

            Assert.That(finishElement.Text, Is.EqualTo("Hello World!"));
        }
    }
}
