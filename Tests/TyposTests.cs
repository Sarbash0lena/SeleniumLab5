using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class TyposTests : BaseTest
    {
        [Test]
        public void ParagraphIsNotEmpty()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/typos");

            var paragraph = driver.FindElement(By.TagName("p"));
            Assert.That(paragraph.Text, Is.Not.Empty);
        }
    }
}
