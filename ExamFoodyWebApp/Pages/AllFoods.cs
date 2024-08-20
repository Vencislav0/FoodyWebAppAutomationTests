using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFoodyWebApp.Pages
{
    public class AllFoods : BasePage
    {
        public AllFoods(IWebDriver driver) : base(driver)
        {
            
        }

        public IReadOnlyCollection<IWebElement> FoodItems => driver.FindElements(By.XPath("//section[@id='scroll']"));
        public IWebElement LastEditButton => FoodItems.Last().FindElement(By.XPath(".//a[@class='btn btn-primary btn-xl rounded-pill mt-5' and text()='Edit']"));
        public IWebElement LastDeleteButton => FoodItems.Last().FindElement(By.XPath(".//a[@class='btn btn-primary btn-xl rounded-pill mt-5' and text()='Delete']"));
        public IWebElement LastTitle => FoodItems.Last().FindElement(By.XPath(".//h2[@class='display-4']"));
        public IWebElement SearchButton => driver.FindElement(By.XPath("//button[@class='btn btn-primary rounded-pill mt-5 col-2']"));
        public IWebElement SearchField => driver.FindElement(By.XPath("//input[@class='form-control rounded mt-5 xl']"));
        public IWebElement NoFoodsFoundMessage => driver.FindElement(By.XPath("//h2[@class='display-4']"));
        public IWebElement AddButtonFromSearchResult => driver.FindElement(By.XPath("//a[@class='btn btn-primary btn-xl rounded-pill mt-5']"));


        public void PerformSearch(string keywords)
        {
            SearchField.Clear();
            SearchField.SendKeys(keywords);
            SearchButton.Click();
        }


    }
}
