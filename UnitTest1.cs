using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace HelloWorldQA
{
    public class Tests
    {
        String test_url = "https://www.google.com/";
        IWebDriver driver;

        [SetUp] // Localizar o ChromeDrive e Maximizar a Tela do Browser
        public void start_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_search() //Teste do site da Google
        {
            driver.Url = test_url; // Retorna a String declarada no inicio do código que seria a URL do Site 
            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));
            searchText.SendKeys("Primeira Automação"); //Digitar no campo de Text
            //Encontrar o XPath do site da Google
            IWebElement searchButton = driver.FindElement(By.XPath("//div[@class='FPdoLc tfB0Bf']//input[@name='btnK']"));
            searchButton.Click(); // Clicar no botão de Pesquisar
            System.Threading.Thread.Sleep(6000);
            Console.WriteLine("Teste Passou");
           
        }
        [TearDown]
        public void Close() // método de fechar o browser.
        {
        driver.Close();

        }
    }
}