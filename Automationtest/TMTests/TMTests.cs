using Automationtest.Page;
using Automationtest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Automationtest.TMTests
{
       [TestFixture]
    [Parallelizable]
    internal class TMTests : CommonDriver
    {
       

        [Test,Order(1), Description("This will create new records") ]
        public void TC001_CreateTM_Test()
        {

            TMHome homepage = new TMHome();
            homepage.GoToTMHomePage(driver);

             TmPage tmPageObject  = new TmPage();
            tmPageObject.createRecord(driver);
        }

        [Test, Order(2) ,Description("This will Edit  records")]
        public void TC002_CreditTM_Test()
        {

            TMHome homepage = new TMHome();
            homepage.GoToTMHomePage(driver);

            TmPage tmPageObject = new TmPage();
            tmPageObject.editRecord(driver);
        }

        [Test, Order(3), Description("This will Delete  records")]
        public void TC003_DeleteTM_Test()
        {
            TMHome homepage = new TMHome();
            homepage.GoToTMHomePage(driver);

            TmPage tmPageObject = new TmPage();
            tmPageObject.deleteRecord(driver);

        }

      
    }
}
