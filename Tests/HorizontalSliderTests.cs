using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class HorizontalSliderTests : BaseTest
    {
        [Test]
        public void SliderValueChanges()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/horizontal_slider");

            var slider = driver.FindElement(By.TagName("input"));
            var actions = new Actions(driver);

            actions.ClickAndHold(slider).MoveByOffset(50, 0).Release().Perform();

            var value = driver.FindElement(By.Id("range")).Text;
            Assert.That(value, Is.Not.Empty);
        }
    }
}
