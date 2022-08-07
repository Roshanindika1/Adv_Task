using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class ManageLanguage : Commondriver
    {
        //Identify the Add new button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        public IWebElement addNewButton { get; set; }

        //Identify Add new language box 
        [FindsBy(How = How.Name, Using = "name")]
        public IWebElement addNewLanguage { get; set; }

        //Identify Choose language level drop down button
        [FindsBy(How = How.Name, Using = "level")]
        public IWebElement languageLevelDropdown { get; set; }

        //Language level Option
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)")]
        public IWebElement languageLevelOption { get; set; }

        //Identify the add button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button")]
        public IWebElement addButton { get; set; }

        



        public void addLanguage()
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div", 2);
            addNewButton.Click();
            addNewLanguage.SendKeys("Spanish");
            languageLevelDropdown.SendKeys("Basic");
            addButton.Click();
            Thread.Sleep(2000);
            
        }

        //Identify and initializing actual Language 
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(1)")]
        public IWebElement actualLanguage { get; set; }


        public string GetLanguage(IWebDriver driver)
        {
            return actualLanguage.Text;
        }
    }
}
