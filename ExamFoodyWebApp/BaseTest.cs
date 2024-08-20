using ExamFoodyWebApp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace ExamFoodyWebApp
{
    public class BaseTest
    {
        public IWebDriver driver;
        public LoginPage loginPage;
        public AddFood addFoodPage;
        public AllFoods allFoodsPage;
        public Actions actions;
        public EditPage editPage;

        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--disable-search-engine-choice-screen");
            options.AddArgument("--headless");
            options.AddArgument("--no-sandbox");
            options.AddArgument("--disable-dev-shm-usage");
            options.AddArgument("--disable-gpu");
            

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            loginPage = new LoginPage(driver);
            addFoodPage = new AddFood(driver);
            allFoodsPage = new AllFoods(driver);
            actions = new Actions(driver);
            editPage = new EditPage(driver);

            loginPage.OpenPage();
            loginPage.Login("Wamer", "123456");



        }


        [TearDown]
        public void TearDown() 
        {
            driver.Quit();
            driver.Dispose();
        }


        public string GenerateRandomTitle()
        {
            var random = new Random();
            return "TITLE: " + random.Next(1, 1000);

        }

        public string GenerateRandomDesc()
        {
            var random = new Random();
            return "DESC: " + random.Next(1, 1000);

        }



    }
}