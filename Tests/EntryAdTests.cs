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

            // дочекатися, поки модалка з’явиться
            var modal = wait!.Until(d =>
            {
                var elem = d.FindElement(By.CssSelector(".modal"));
                return elem.Displayed ? elem : null;
            });

            // тепер дочекатися, поки кнопка закриття буде клікабельною
            var closeButton = modal.FindElement(By.CssSelector(".modal-footer p"));
            wait.Until(d => closeButton.Enabled && closeButton.Displayed);

            closeButton.Click();

            // перевірка: модалка тепер невидима
            Assert.That(modal.Displayed, Is.False);
        }
    }
}
