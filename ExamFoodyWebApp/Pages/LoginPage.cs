using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExamFoodyWebApp.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }

        public string Url = BaseUrl + "/User/Login";

        public IWebElement UsernameField => driver.FindElement(By.XPath("//input[@id='username']"));
        public IWebElement passwordField => driver.FindElement(By.XPath("//input[@id='password']"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']"));


        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            passwordField.SendKeys(password);
            LoginButton.Click();
        }



    }
}
