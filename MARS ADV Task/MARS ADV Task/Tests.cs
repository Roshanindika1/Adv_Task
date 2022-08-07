using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using MARS_ADV_Task.Utilities;
using MARS_ADV_Task.Pages;
using System;
using OpenQA.Selenium;

namespace MARS_ADV_Task
{
    [TestFixture]
    internal class Tests : Commondriver
    {
        

        [OneTimeSetUp]

        public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var Homepage = new Homepage();
            PageFactory.InitElements(driver, Homepage);
            /*
            // Register the website
            Homepage.joinWebBtn.Click(); 
            var Registerpage = new Registerpage();
            PageFactory.InitElements(driver, Registerpage);
            Registerpage.Registersteps();
            */
            var Homepageobj = new Homepage();
            PageFactory.InitElements(driver, Homepageobj);

            Wait.WaitForvisible(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 3);
            Homepageobj.signInButton.Click();
            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();

        }
       
        [Test, Order(1)]
        public void CreateprofilelocationFunction()
        {
            var Profilepageloc = new Profilepageloc();
            PageFactory.InitElements(driver, Profilepageloc);
            Profilepageloc.Profilemanageloc();


            Profilepageloc Profilepagelocobj = new Profilepageloc();
            PageFactory.InitElements(driver, Profilepagelocobj);
            string newavailability = Profilepagelocobj.Getavailability(driver);
            Assert.That(newavailability == "Full Time", "Actual availability and Expected availability does not match");
          
        }

        [Test, Order(2)]
        public void ManagelanguageFunction()
        {
            var ManageLanguage = new ManageLanguage();
            PageFactory.InitElements(driver, ManageLanguage);
            ManageLanguage.addLanguage();


            ManageLanguage ManageLanguageObj = new ManageLanguage();
            PageFactory.InitElements(driver, ManageLanguageObj);
            string newLanguage = ManageLanguageObj.GetLanguage(driver);
            Assert.That(newLanguage == "Spanish", "Actual language and Expected language does not match");

        }

        [Test, Order(3)]
        public void ManageSkillsFunction()
        {
            var Manageskills = new Manageskills();
            PageFactory.InitElements(driver, Manageskills);
            Manageskills.AddSkills();


            Manageskills ManageskillsObj = new Manageskills();
            PageFactory.InitElements(driver, ManageskillsObj);
            string newSkill = ManageskillsObj.GetSkills(driver);
            Assert.That(newSkill == "Designing", "Actual Skill and Expected Skill does not match");

        }

        [Test, Order(4)]
        public void ManageEducationFunction()
        {
            var ManageEducation = new ManageEducation();
            PageFactory.InitElements(driver, ManageEducation);
            ManageEducation.addEducation();


            ManageEducation ManageEducationObj = new ManageEducation();
            PageFactory.InitElements(driver, ManageEducationObj);
            string newEducation = ManageEducationObj.GetEducation(driver);
            Assert.That(newEducation == "Otago", "Actual Education and Expected Education does not match");

        }

        [Test, Order(5)]
        public void ManageCertificationFunction()
        {
            var ManageCertification = new ManageCertification();
            PageFactory.InitElements(driver, ManageCertification);
            ManageCertification.AddCertification();


            ManageCertification ManageCertificationObj = new ManageCertification();
            PageFactory.InitElements(driver, ManageCertificationObj);
            string newCertification = ManageCertificationObj.GetCertification(driver);
            Assert.That(newCertification == "Diploma", "Actual Certification and Expected Certification does not match");

        }


        [Test, Order(6)]
        public void ManageDescriptionFunction()
        {
            var ManageDescription = new ManageDescription();
            PageFactory.InitElements(driver, ManageDescription);
            ManageDescription.AddDescription();


            ManageDescription ManageDescriptionObj = new ManageDescription();
            PageFactory.InitElements(driver, ManageDescriptionObj);
            string newDescription = ManageDescriptionObj.GetDescription(driver);
            Assert.That(newDescription == "Design expertise who creates solutions", "Actual Description and Expected Description does not match");

        }

        [Test, Order(7)]
        public void ManagePasswordFunction()
        {
            var ManagePassword = new ManagePassword();
            PageFactory.InitElements(driver, ManagePassword);
            ManagePassword.ChangePassword();


            ManagePassword ManagePasswordObj = new ManagePassword();
            PageFactory.InitElements(driver, ManagePasswordObj);
            string newPassword = ManagePasswordObj.GetNewpassword(driver);
            Assert.That(newPassword == "newPassword1", "Actual new Password and Expected new Password does not match");

        }

        [Test, Order(8)]
        public void ShareSkillsFunction()
        {
            var ShareSkills = new ShareSkills();
            PageFactory.InitElements(driver, ShareSkills);
            ShareSkills.ManageSkills();


            ShareSkills ShareSkillsObj = new ShareSkills();
            PageFactory.InitElements(driver, ShareSkillsObj);
            string Category = ShareSkillsObj.GetCategory(driver);
            Assert.That(Category == "Programming & Tech", "Actual Category and Expected Category does not match");

        }

        [OneTimeTearDown]

        public void Closedown()
        {
          //  driver.Close();
        }
    }
}

