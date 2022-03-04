using Automationtest.Page;
using Automationtest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Automationtest
{
       [TestFixture]
    
    internal class TMTests : CommonDriver
    {
       

       [SetUp]
       public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            TmLogin login = new TmLogin();
            login.LoginTest(driver);
            TMHome homepage = new TMHome();
            homepage.TMHomePage(driver);

        }

        [Test]
        public void CreateTM_Test()
        {
            TmPage tmPageObject  = new TmPage();
            tmPageObject.createRecord(driver);
        }

        [Test]
        public void CreditTM_Test()
        {

            TmPage tmPageObject = new TmPage();
            tmPageObject.editRecord(driver);
        }

        [Test]
        public void DeleteTM_Test()
        {
            TmPage tmPageObject = new TmPage();
            tmPageObject.deleteRecord(driver);

        }

        [TearDown]
        public void CloseTM_Test()
        {
            
           

        }
    }
}
