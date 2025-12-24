using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class EntryAdTests : BaseTest
    {
        [Test]
        public void ModalWindowCanBeClosed()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/entry_ad");

            var closeButton = wait!.Until(d => d.FindElement(By.CssSelector(".modal-footer p")));
            closeButton.Click();

            Assert.Pass();
        }
    }
}
