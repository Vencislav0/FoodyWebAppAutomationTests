using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFoodyWebApp.Pages
{
    public class AddFood : BasePage
    {
        public AddFood(IWebDriver driver) : base(driver)
        {
            
        }

        public string Url = BaseUrl + "/Food/Add";


        public IWebElement NameField => driver.FindElement(By.XPath("//input[@class='form-control' and @id='name']"));
        public IWebElement DescribeField => driver.FindElement(By.XPath("//input[@class='form-control' and @id='description']"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']"));
        public IWebElement ErrorMessage1 => driver.FindElement(By.XPath("//div[@class='text-danger validation-summary-errors']"));
        public IWebElement ErrorMessage2 => driver.FindElements(By.XPath("//span[@class='text-danger field-validation-error']"))[0];
        public IWebElement ErrorMessage3 => driver.FindElements(By.XPath("//span[@class='text-danger field-validation-error']"))[1];

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void AddItem(string name, string describe)
        {
            NameField.Clear();
            NameField.SendKeys(name);
            DescribeField.Clear();
            DescribeField.SendKeys(describe);
            AddButton.Click();
        }

        public void AssertErrorMessages()
        {
            Assert.That(ErrorMessage1.Text.Trim(), Is.EqualTo("Unable to add this food revue!"), "Error message is not as expected");
            Assert.That(ErrorMessage2.Text.Trim(), Is.EqualTo("The Name field is required."), "Error message is not as expected");
            Assert.That(ErrorMessage3.Text.Trim(), Is.EqualTo("The Description field is required."), "Error message is not as expected");
        }


    }
}
