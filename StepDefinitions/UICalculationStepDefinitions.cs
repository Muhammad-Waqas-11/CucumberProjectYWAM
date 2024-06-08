using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using TechTalk.SpecFlow;

namespace Calculator.Specs
{
    [Binding]
    public class UICalculatorSteps
    {
        private IWebDriver driver;
        private IWebElement resultDisplay;

        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://localhost:44364/Home/Calculator");
            resultDisplay = driver.FindElement(By.Id("result"));
        }

        [AfterScenario]
        public void TearDown()
        {
            // Wait for 10 seconds before closing the browser
            Thread.Sleep(5000);

            driver.Quit();
        }

        [Given(@"I press ""(.*)"" on the calculator")]
        public void GivenIPressOnTheCalculator(string button)
        {
            var buttonElement = driver.FindElement(By.XPath($"//button[text()='{button}']"));
            buttonElement.Click();
        }

        [When(@"I press ""(.*)"" on the calculator")]
        public void WhenIPressOnTheCalculator(string button)
        {
            var buttonElement = driver.FindElement(By.XPath($"//button[text()='{button}']"));
            buttonElement.Click();
        }

        [Then(@"the result should be ""(.*)"" on the display")]
        public void ThenTheResultShouldBeOnTheDisplay(string expectedResult)
        {
            Assert.AreEqual(expectedResult, resultDisplay.GetAttribute("value"));
        }
    }
}
