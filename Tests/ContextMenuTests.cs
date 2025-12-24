using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class ContextMenuTests : BaseTest
    {
        [Test]
        public void AlertAppearsOnRightClick()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

            var box = driver.FindElement(By.Id("hot-spot"));
            new Actions(driver).ContextClick(box).Perform();

            var alert = driver.SwitchTo().Alert();
            Assert.That(alert.Text, Does.Contain("context menu"));
            alert.Accept();
        }
    }
}
