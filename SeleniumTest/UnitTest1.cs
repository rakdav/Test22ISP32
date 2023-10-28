using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace SeleniumTest
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver=new ChromeDriver();
       // IWebDriver ege = new EdgeDriver(); 
        //[TestCase]
        //public void mainTitle()
        //{
        //    driver.Url = "https://kbkdist.ru";
        //    Assert.That(driver.Title, Is.EqualTo("Образовательная платформа Калининградского бизнес-колледжа"));
        //    ege.Url = "https://kbkdist.ru";
        //    Assert.That(ege.Title, Is.EqualTo("Образовательная платформа Калининградского бизнес-колледжа"));
        //}

        [TestCase]
        public void SignInTest() 
        {
            driver.Url = "https://kbkdist.ru";
            IWebElement signIn = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[2]/div/span/a"));
            signIn.Click();
        }
        [TestCase]
        public void SignUpTest()
        {
            driver.Url = "https://kbkdist.ru/login/index.php";
            IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/div[1]/input"));
            login.SendKeys("rakdav");
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/div[2]/input"));
            password.SendKeys("123456");
            IWebElement button = driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div/section/div/div[2]/div/div/div/div/div/div[1]/form/button"));
            button.Click();
        }

    }
}