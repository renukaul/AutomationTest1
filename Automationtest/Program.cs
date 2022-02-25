using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Automationtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Open chrome browser

            IWebDriver driver = new ChromeDriver();

            // Launch Turnup page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

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
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (hellohari.Text == "Hello hari")
            {
                Console.WriteLine("Login sucessfull,Test Pass");

            }

            else
            {
                Console.WriteLine(" Login failed");
            }
                 



            
        }
    }
}
