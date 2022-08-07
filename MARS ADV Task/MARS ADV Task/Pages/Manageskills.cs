using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class Manageskills : Commondriver
    {
        //Identify Skills Tab            
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)")]
        public IWebElement skillTab { get; set; }

        //Identify Addnew button 
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        public IWebElement addNewSkillbutton { get; set; }

        //Add Skill
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]")]
        public IWebElement addSkill { get; set; }

        //Skill level
        [FindsBy(How = How.Name, Using = "level")]
        public IWebElement skillLevelDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)")]
        public IWebElement skillLevelOption { get; set; }

        //Click the Add Button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button")]
        public IWebElement skillAddButton { get; set; }

     //  [FindsBy(How = How.XPath, Using = "/html/body/div[1]/a")]
     //   public IWebElement errMsg { get; set; }



        public void AddSkills() 
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)", 2);
            skillTab.Click();
            addNewSkillbutton.Click();
           
          //  Wait.WaitForvisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]", 4);
            addSkill.SendKeys("Designing");
            skillLevelDropdown.Click();
           // Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select > option:nth-child(3)", 1);
            skillLevelOption.Click();
          //  Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button", 1);
            skillAddButton.Click();
           
            Thread.Sleep(2000);
        }


        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(1)")]
        public IWebElement actualSkill { get; set; }

        public string GetSkills(IWebDriver driver) 
        {
            return actualSkill.Text;
        }
    }
}
