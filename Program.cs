using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

internal class Program
{
    private static void Main(string[] args)
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        ChromeDriver driver = new ChromeDriver();
        
        driver.Navigate().GoToUrl("https://www.selenium.dev/selenium/web/web-form.html");
        
        IWebElement input = driver.FindElement(By.Id("my-text-id"));
        input.SendKeys("Teste");

        IWebElement password = driver.FindElement(By.Name("my-password"));
        password.SendKeys("teste123");

        driver.FindElement(By.TagName("button")).Click();

    }
}