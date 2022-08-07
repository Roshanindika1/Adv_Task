using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class Profilepageloc : Commondriver
    {
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        public IWebElement availability { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select")]
        public IWebElement availabilityOpt { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]")]
        public IWebElement availabilityOpt2 { get; set; }

     
        /// ///////////////////////////////////////////////////////////
   
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        public IWebElement hours { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select")]
        public IWebElement hoursOpt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select > option:nth-child(4)")]
        public IWebElement hoursOpt2 { get; set; }
        ////////////////////////////////////////////////////////////////

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i")]
        public IWebElement earnTgt { get; set; }

        [FindsBy(How = How.Name, Using = "availabiltyTarget")]
        public IWebElement earnTgtOpt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select > option:nth-child(2)")]
        public IWebElement earnTgtOpt2 { get; set; }



        public void Profilemanageloc()
        {
            Thread.Sleep(1000);
            jse.ExecuteScript("window.scrollBy(0,200)");
            
            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i", 2);
            availability.Click();
            availabilityOpt.Click();
            availabilityOpt2.Click();

            Wait.WaitForclicable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 2);
            hours.Click();
            hoursOpt.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(3) > div > span > select > option:nth-child(4)", 2);
            hoursOpt2.Click();

            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > i", 2);
            earnTgt.Click();
            earnTgtOpt.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(4) > div > span > select > option:nth-child(2)", 2);
            earnTgtOpt2.Click();
        }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span")]
        public IWebElement actualavailability { get; set; }

        public string Getavailability(IWebDriver driver)
        {
            Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.four.wide.column > div > div > div > div > div > div.extra.content > div > div:nth-child(2) > div > span", 2);
            return actualavailability.Text;
        }

    }
        
}
