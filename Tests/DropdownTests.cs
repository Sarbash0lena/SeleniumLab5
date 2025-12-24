using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumLab5.Base;

namespace SeleniumLab5.Tests
{
    public class DropdownTests : BaseTest
    {
        [Test]
        public void SelectOption2()
        {
            driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/dropdown");

            var dropdown = new SelectElement(driver.FindElement(By.Id("dropdown")));
            dropdown.SelectByText("Option 2");

            Assert.That(dropdown.SelectedOption.Text, Is.EqualTo("Option 2"));
        }
    }
}
