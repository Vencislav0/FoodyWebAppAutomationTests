using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFoodyWebApp.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        protected static readonly string BaseUrl = "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85";
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            
        }

        

        public IWebElement HomePageLink => driver.FindElement(By.XPath("//a[@class='navbar-brand']"));
        public IWebElement SignUpLink => driver.FindElement(By.XPath("//a[@class='nav-link' and text()='Sign Up']"));
        public IWebElement LogInLink => driver.FindElement(By.XPath("//a[@class='nav-link' and text()='Log In']"));





    }
}
