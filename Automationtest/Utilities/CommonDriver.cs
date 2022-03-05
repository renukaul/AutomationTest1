using Automationtest.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automationtest.Utilities
{
    internal class CommonDriver
    {
        public IWebDriver driver;


        [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            TmLogin login = new TmLogin();
            login.LoginTest(driver);
           /* TMHome homepage = new TMHome();
            homepage.TMHomePage(driver);*/



        }

        [OneTimeTearDown]
        public void CloseTM_Test()
        {
             driver.Quit();



        }
    }

}
