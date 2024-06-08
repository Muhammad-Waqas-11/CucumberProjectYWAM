using System.Security.Principal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CucumberProjectYWAM.StepDefinitions
{
    [Binding]
    public sealed class YoutubeSearchStepDefinitions
    {
        private IWebDriver driver;
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter the URL")]
        public void WhenEnterTheURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [When(@"Enter the URLFootballer")]
        public void WhenEnterTheURLFootballer()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"Search for the Cucumber Tutorials")]
        public void ThenSearchForTheCucumberTutorials()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Cucumber Tutorials");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);

            driver.Quit();
        }

        [Then(@"Search for the Footballer Tutorials")]
        public void ThenSearchForTheFootballerTutorials()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Cristiano Ronaldo");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(5000);

            driver.Quit();
        }


    }
}
