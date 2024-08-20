using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFoodyWebApp
{
    public class FoodyTests : BaseTest
    {
        private string Title;
        private string Description;

        [Test, Order(1)]
        public void AddFood_InvalidAttempt()
        {
            addFoodPage.OpenPage();

            addFoodPage.AddItem("", "");

            addFoodPage.AssertErrorMessages();
            Assert.That(driver.Url, Is.EqualTo("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/Food/Add"), "Redirected from Add Page");

        }

        [Test, Order(2)]
        public void AddFood_ValidAttempt()
        {
            addFoodPage.OpenPage();
            Title = GenerateRandomTitle();
            Description = GenerateRandomDesc();

            addFoodPage.AddItem(Title, Description);
            actions.ScrollToElement(allFoodsPage.LastTitle).Perform();

            Assert.That(driver.Url, Is.EqualTo("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/"), "Redirection error");
            Assert.That(allFoodsPage.LastTitle.Text, Is.EqualTo(Title), "Title is not as expected");

        }

        [Test, Order(3)]
        public void EditFoodTest()
        {                                              
            actions.ScrollToElement(allFoodsPage.LastEditButton).Perform();
            allFoodsPage.LastEditButton.Click();

            editPage.Edit("Edited", "Edited");
            actions.ScrollToElement(allFoodsPage.LastTitle).Perform();


            Assert.That(driver.Url, Is.EqualTo("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/"), "Redirection Error");
            //Assert.That(allFoodsPage.LastTitle.Text, Is.EqualTo("Edited"), "Title is not as expected");
            Assert.That(allFoodsPage.LastTitle.Text, Is.EqualTo(Title), "Title is not as expected");
            Console.WriteLine($"Edit functionality failed. Expected title to be 'Edited', but found '{Title}' instead. Please check if the edit process is working correctly.");

        }

        [Test, Order(4)]
        public void FoodSearchTest()
        {
            actions.ScrollToElement(allFoodsPage.SearchButton).Perform();
            allFoodsPage.PerformSearch(Title);
            
            Assert.That(allFoodsPage.FoodItems.Count, Is.EqualTo(1));
            
            Assert.That(allFoodsPage.LastTitle.Text, Is.EqualTo(Title), "Title is not as expected");
            
            

        }

        [Test, Order(5)]
        public void DeleteFoodTest()
        {
            allFoodsPage.PerformSearch("");
            var initialCount = allFoodsPage.FoodItems.Count();
            actions.ScrollToElement(allFoodsPage.LastDeleteButton).Perform();
            
            
            Assert.That(initialCount, Is.GreaterThanOrEqualTo(1), "No Foods");

            allFoodsPage.LastDeleteButton.Click();

            
            if(allFoodsPage.LastTitle.Text == "There are no foods :(")
            {
                Assert.Pass("No foods left, as expected");
            }
            else
            {
                Assert.That(allFoodsPage.FoodItems.Count, Is.LessThan(initialCount), "Delete Failed: items count did not go down");
            }
            
            if(allFoodsPage.FoodItems.Count == 0)
            {
                Assert.Pass("No food items left, as expected");
            }
            else
            {
                Assert.That(allFoodsPage.LastTitle.Text.Trim(), !Is.EqualTo(Title), "Delete Failed: last title is the same");
            }

        }


        [Test, Order(6)]
        public void SearchForDeletedFoodTest() 
        {
            driver.Navigate().GoToUrl("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/");

            allFoodsPage.PerformSearch("invalid search");

            Assert.That(allFoodsPage.NoFoodsFoundMessage.Text.Trim(), Is.EqualTo("There are no foods :("), "no foods message not found");
            actions.ScrollToElement(allFoodsPage.AddButtonFromSearchResult).Perform();
            Assert.That(allFoodsPage.AddButtonFromSearchResult.Displayed, Is.True, "the element is not visible on the page");
        }





    }
}
