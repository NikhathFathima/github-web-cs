using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MagicBricks
{
    [Binding]
    public class HomePageStepDefinitions : ApplicationHooks
    {
        private object wait;

        [Given(@"Chrome is launched and MagicBricks app is launch")]
        public void GivenChromeIsLaunchedAndMagicBricksAppIsLaunch()
        {
            Thread.Sleep(5000);
            string expectedUrl = "https://www.magicbricks.com/";
            string actualUrl = ValidatePageUrl();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
            Console.WriteLine(actualUrl);
             
        }


        [Then(@"Homepage is displayed")]
        public void ThenHomepageIsDisplayed()
        {
            Thread.Sleep(5000);
            string expectedTitle = "Real Estate | Property in India | Buy/Sale/Rent Properties | MagicBricks";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);


        }

        [When(@"user mousehovering on bangalore,MB Prime and login icons")]
        public void WhenUserMousehoveringOnBangaloreMBPrimeAndLoginIcons()
        {
            hp.JustMouseHover();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var Bangalore = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//[@id='commercialIndex']/header/section[1]/div/div[2]/a")));
            var MBPrime= wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='commercialIndex']/header/section[1]/div/div[3]/a")));
            var login = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='commercialIndex']/header/section[1]/div/div[4]")));
            action.MoveToElement(Bangalore).Perform();
            action.MoveToElement(MBPrime).Perform();
            action.MoveToElement(login).Perform();
            Thread.Sleep(5000);
        }

        [Then(@"All options are displayed")]
        public void ThenAllOptionsAreDisplayed()
        {
            IWebElement Bangalore = driver.FindElement(By.XPath("//a[@class='mb-header__main__link js-menu-link active']"));
            Bangalore.Click();
            Thread.Sleep(5000);
            IWebElement MbPrime = driver.FindElement(By.XPath("//a[@class='mb-header__main__link js-menu-link active']"));
            MbPrime.Click();
            Thread.Sleep(5000);
            IWebElement login = driver.FindElement(By.XPath("//a[@class='mb-header__main__link js-menu-link active']"));
            login.Click();
            Thread.Sleep(5000);

        }


        [When(@"user mousehovering on Buy,Rent,Sell,Tools & Advice,What's New,Homeloans,Blog,Help dropdowns")]
        public void WhenUserMousehoveringOnBuyRentSellToolsAdviceWhatsNewHomeloansBlogHelpDropdowns()
        {
            hp.JustMouseHover();
            Thread.Sleep(5000);
        }

        [Then(@"All properties are displayed")]
        public void ThenAllPropertiesAreDisplayed()
        {
            Thread.Sleep(5000);
            string expectedUrl = "https://www.magicbricks.com/";
            string actualUrl = ValidatePageUrl();
            Assert.That(actualUrl, Is.EqualTo(expectedUrl));
            Console.WriteLine(actualUrl);
        }



    }
}
