using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class ManageDescription : Commondriver
    {
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span > i")]
        public IWebElement descriptionBtn { get; set; }
        
        [FindsBy(How = How.Name, Using = "value")]
        public IWebElement descriptionBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button")]
        public IWebElement saveBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span")]
        public IWebElement actualDescription { get; set; }

      //  [FindsBy(How = How.XPath, Using = "/html/body/div[1]/a")]
      //  public IWebElement errMsg { get; set; }


        public void AddDescription()
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 2);
            descriptionBtn.Click();
            Thread.Sleep(1000);
            descriptionBox.Clear();
            descriptionBox.SendKeys("Design expertise who creates solutions");
            saveBtn.Click();
           // errMsg.Click();
            Thread.Sleep(1000);

        }

        //Get the Description
        public string GetDescription(IWebDriver driver)
        {
            return actualDescription.Text;
        }
    }
}

