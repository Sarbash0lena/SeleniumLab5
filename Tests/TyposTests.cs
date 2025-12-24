using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class TyposTests : BaseTest
    {
        [Test]
        public void TextContainsExpectedWord()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");

            var text = driver.FindElement(By.TagName("p")).Text;
            Assert.That(text, Does.Contain("won"));
        }
    }
}
