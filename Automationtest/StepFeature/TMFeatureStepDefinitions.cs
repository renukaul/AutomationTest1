using Automationtest.Page;
using Automationtest.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Automationtest
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        //Initilization of page objects
        TmLogin login = new TmLogin();

        TMHome homepage = new TMHome();

        TmPage tmPageObject = new TmPage();
    
    [Given(@"I logged it sucessfully")]


        public void GivenILoggedItSucessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
                    
            login.LoginTest(driver);
           


        }

        [Given(@"I  nevigate  to  T & M page")]
        public void GivenINevigateToTMPage()
        {

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            homepage.GoToTMHomePage(driver);
            

        }

        [When(@"create T & M page")]
        public void WhenCreateTMPage()
        {

            
         //   homepage.GoToTMHomePage(driver);
;
            tmPageObject.createRecord(driver);

        }


        [Then(@"we will sucessfully create the T & M record")]
        public void ThenWeWillSucessfullyCreateTheTMRecord()
        {
            TmPage tmpageObj = new TmPage();
            string code = tmpageObj.getCode(driver);
            string typecode = tmpageObj.getTypeCode(driver);
            string description = tmpageObj.getDescription(driver);
            string price = tmpageObj.getPrice(driver);

            Assert.That(code == "Renu", "Actual code and expected result does not match");
                      
            Assert.That(typecode == "T", "Actual typecode and result does not match");
                       
            Assert.That(description == "Renu", "Actual description and result does not match");
                       
            Assert.That(price == "$13.00","Actual price and result does not match");


        }

        [When(@"Update '([^']*)','([^']*)','([^']*)' on an existing  T & M record")]
        public void WhenUpdateOnAnExistingTMRecord(string p0, string p1, string p2)
        {
            tmPageObject.editRecord(driver, p0, p1, p2);

        }

        [Then(@"The record shoub have the  updated '([^']*)' ,'([^']*)','([^']*)'")]
        public void ThenTheRecordShoubHaveTheUpdated(string p0, string p1, string p2)
        {
            string description = tmPageObject.GetEditedDescription(driver);
            string Typecode  = tmPageObject.GetEditedTypeCode(driver);
            string price = tmPageObject.GetEditedPrice(driver);

            Assert.That(description == p0, "Actual description and expected description does not match");

            Assert.That(Typecode == p1, "Actual code and expected code does not match");

          //  Assert.That(price == "$"+ p2 + ".00", "Actual price and expected price does not match");

        }


        /*[When(@"Update '([^']*)' on an existing  T & M record")]
        public void WhenUpdateOnAnExistingTMRecord(string p0)
        {
           // homepage.GoToTMHomePage(driver);
            tmPageObject.editRecord(driver, p0);


        }

        [Then(@"The record shoub have the  updated '([^']*)'")]
        public void ThenTheRecordShoubHaveTheUpdated(string p0)
        {
            string editeddescription = tmPageObject.GetEditedDescription(driver);
            Assert.That(editeddescription == p0, "Actual Description and Expected Descriptiondo not match");


        }*/

















    }
}
