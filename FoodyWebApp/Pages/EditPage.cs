using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFoodyWebApp.Pages
{
    public class EditPage : BasePage
    {

        public EditPage(IWebDriver driver) : base(driver)
        {
            
        }

        public string Url = BaseUrl + "/Food/Edit";

        public IWebElement NameField => driver.FindElement(By.XPath("//input[@id='name']"));
        public IWebElement DescriptionField => driver.FindElement(By.XPath("//input[@id='description']"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']"));

        public void Edit(string name, string description)
        {
            NameField.Clear();
            DescriptionField.Clear();
            NameField.SendKeys(name);
            DescriptionField.SendKeys(description);
            AddButton.Click();
        }



    }
}
