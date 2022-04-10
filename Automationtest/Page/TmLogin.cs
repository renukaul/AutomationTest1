using NUnit.Framework;      
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Automationtest.Page
{
    class TmLogin
    {
        
         public void LoginTest(IWebDriver driver)
        {
            Console.WriteLine("called");
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {


                // Identify Username Textbox and enter valid username
                IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");

                //  Identify Password Textbox and enter valid passwprd
                IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
                passwordTextBox.SendKeys("123123");
                // click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
                //Check if user is logged in sucessfully
               

            }
            catch (Exception ex)
            {

                Assert.Fail("Login Page TurnUp Page did not Logged ",ex.Message);

                throw;

            }

            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

        }

     
    }
}
