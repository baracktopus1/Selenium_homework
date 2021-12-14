using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumNUnit;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace SeleniumNUnit.StepDafinition
{
    [Binding]

    class StepDefinition
    {
        string url = "https://opensource-demo.orangehrmlive.com";
        IWebDriver webdriver;


        [Given(@"User navigates to the login page")]
        public void GivenUserNavigatesToTheLoginPage()
        {
            webdriver = new ChromeDriver(@"C:\chromedriver\chromedriver_");

            webdriver.Navigate().GoToUrl(url);

        }

        [When(@"User inputs username and password")]
        public void WhenUserInputsUsernameAndPassword()
        {
            IWebElement login = webdriver.FindElement(By.Id("txtUsername"));
            IWebElement password = webdriver.FindElement(By.Id("txtPassword"));

            login.SendKeys("Admin");

            password.SendKeys("admin123");


        }

        [When(@"Clicks on login button")]
        public void WhenClicksOnLoginButton()
        {
            IWebElement login_button = webdriver.FindElement(By.Id("btnLogin"));
            login_button.Click();


        }



        [Then(@"User is navigated to the homepagee")]
        public void ThenUserIsNavigatedToTheHomepagee()
        {
            Actions actions = new Actions(webdriver);


            System.Threading.Thread.Sleep(2000);

            IWebElement Admin_droplist = webdriver.FindElement(By.Id("menu_admin_viewAdminModule"));

            actions.MoveToElement(Admin_droplist).Build().Perform();

            System.Threading.Thread.Sleep(2000);




            IWebElement Job_droplist = webdriver.FindElement(By.Id("menu_admin_Job"));


            actions.MoveToElement(Job_droplist).Build().Perform();

            System.Threading.Thread.Sleep(2000);

            IWebElement Job_droplist_option = webdriver.FindElement(By.Id("menu_admin_viewJobTitleList"));

            Job_droplist_option.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"User is in the Job titles page")]
        public void GivenUserIsInTheJobTitlesPage()
        {
            webdriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/admin/viewJobTitleList");
        }


        [When(@"User clicks Add button")]
        public void WhenUserClicksAddButton()
        {
            IWebElement btnAdd = webdriver.FindElement(By.Id("btnAdd"));

            btnAdd.Click();
        }




        [When(@"Inputs (.*) (.*) and (.*)")]
        public void WhenInputsAnd(string p0, string p1, string p2)
        {
            IWebElement Job_title = webdriver.FindElement(By.Id("jobTitle_jobTitle"));
            IWebElement Job_description = webdriver.FindElement(By.Id("jobTitle_jobDescription"));
            IWebElement Job_note = webdriver.FindElement(By.Id("jobTitle_note"));

            Job_title.SendKeys("Student");
            Job_description.SendKeys("Description");
            Job_note.SendKeys("Note");
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"Clicks save button")]
        public void WhenClicksSaveButton()
        {
            IWebElement save_btn = webdriver.FindElement(By.Id("btnSave"));
            save_btn.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"User notices new data on the page")]
        public void ThenUserNoticesNewDataOnThePage()
        {
            IWebElement chkbox = webdriver.FindElement(By.XPath("//tr//td//a[text()=\"Student\"]"));
            Assert.IsNotNull(chkbox);
        }

        [When(@"User clicks on (.*)")]
        public void WhenUserClicksOn(string p0)
        {
            IWebElement chkbox = webdriver.FindElement(By.XPath("//tr//td//a[text()=\"Student\"]"
));
            chkbox.Click();
        }
        [When(@"User enters edit mode")]
        public void WhenUserEntersEditMode()
        {
            IWebElement chkbox = webdriver.FindElement(By.Id("btnSave"));

            chkbox.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"User saves changes")]
        public void WhenUserSavesChanges()
        {
            IWebElement save_btn = webdriver.FindElement(By.Id("btnSave"));
            save_btn.Click();
            System.Threading.Thread.Sleep(2000);
        }


        [When(@"User edits (.*)")]
        public void WhenUserEdits(string p0)
        {

            IWebElement Job_description = webdriver.FindElement(By.Id("jobTitle_jobDescription"));



            Job_description.Clear();

            Job_description.SendKeys("Hates life");
            System.Threading.Thread.Sleep(2000);
        }

        

        [Then(@"User notices edited data on the page")]
        public void ThenUserNoticesEditedDataOnThePage()
        {
            IWebElement chkbox = webdriver.FindElement(By.XPath("//tr//td//a[text()=\"Student\"]"));
            Assert.IsNotNull(chkbox);
        }

        [When(@"User ticks (.*)")]
        public void WhenUserTicks(string p0)
        {
            IWebElement chkbox = webdriver.FindElement(By.XPath("//tr//td//a[text()=\"Student\"]//..//..//td//input"
));
            chkbox.Click();
        }

        [When(@"clicks Delete button")]
        public void WhenClicksDeleteButton()
        {
            IWebElement delete_btn = webdriver.FindElement(By.Id("btnDelete"));
            delete_btn.Click();
            System.Threading.Thread.Sleep(2000);
        }



        [When(@"clicks ok button")]
        public void WhenClicksOkButton()
        {
            IWebElement delete_btn = webdriver.FindElement(By.Id("dialogDeleteBtn"));
            delete_btn.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"User notices his field deleted on Job title page")]
        public void ThenUserNoticesHisFieldDeletedOnJobTitlePage()
        {
            IWebElement chkbox = webdriver.FindElement(By.Id("btnDelete"));
            Assert.IsNotNull(chkbox);
        }

    
    }
}
