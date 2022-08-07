using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace MARS_ADV_Task.Pages
{
    internal class Homepage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        public IWebElement signInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        public IWebElement joinWebBtn { get; set; }
    }
}
