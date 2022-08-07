using MARS_ADV_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace MARS_ADV_Task.Pages
{
    internal class ManageEducation :Commondriver
    {
        //Identify Education Tab
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)")]
        public IWebElement educationTab { get; set; }

        //Identify the add new button
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div")]
        public IWebElement educationAddnewbutton { get; set; }

        //Identify the college details
        [FindsBy(How = How.Name, Using = "instituteName")]
        public IWebElement collegeUniName { get; set; }

        //Identify country dropdown box
        [FindsBy(How = How.Name, Using = "country")]
        public IWebElement countryDropdown { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > div.six.wide.field > select > option:nth-child(102)")]
        public IWebElement countryOption { get; set; }


        //Identify the graduate title and select the title option
        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(6)")]
        public IWebElement titleOption { get; set; }


        //Identify the degree qualification
        [FindsBy(How = How.Name, Using = "degree")]
        public IWebElement degreeQualification { get; set; }


        //Identify the year of graduation 

        [FindsBy(How = How.Name, Using = "yearOfGraduation")]
        public IWebElement yearOfGraduationdropdown { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > div.four.wide.field > select > option:nth-child(14)")]
        public IWebElement yearOfGraduationoption { get; set; }

        //Identify the education Add button

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(3) > div > input.ui.teal.button")]
        public IWebElement addEducationbutton { get; set; }

       // [FindsBy(How = How.XPath, Using = "/html/body/div[1]/a")]
      //  public IWebElement errMsg { get; set; }


        public void addEducation()
        {

            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(3)", 2);
            educationTab.Click();
            educationAddnewbutton.Click();
            collegeUniName.SendKeys("Otago");
            countryDropdown.Click();
            countryOption.Click();
            titleDropdown.Click();
            titleOption.Click();
            degreeQualification.SendKeys("Degree");
            yearOfGraduationdropdown.Click();
            yearOfGraduationoption.Click();
            addEducationbutton.Click();
           // errMsg.Click();
            Thread.Sleep(2000);

        }
        //Identify the new Education 
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:last-child > tr > td:nth-child(2)")]
        public IWebElement actualEducationUni { get; set; }

        public string GetEducation(IWebDriver driver)

        {
            return actualEducationUni.Text;
        }
    }
}
    
