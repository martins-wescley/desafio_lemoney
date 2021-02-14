using Desafio_lemoney.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Desafio_lemoney.Common
{
    public class BaseTests
    {
        public IWebDriver driver;
        WebDriverWait wait;
        public AutomationPracticePage automationPracticePage;
        public CarrinhoDeComprasPage carrinhoDeComprasPage;
        public DetelheItemPage detelheItemPage;

        [BeforeScenario]
        public void IniciarTeste()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            IniciarElementos(driver);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(7000));
        }

        public void EsperarElementoFicarVisivel(IWebElement elemento)
        {
            wait.Until(driver => elemento.Displayed);
        }

        public void IniciarElementos(IWebDriver driver)
        {
            automationPracticePage = new AutomationPracticePage();
            carrinhoDeComprasPage = new CarrinhoDeComprasPage();
            detelheItemPage = new DetelheItemPage();

            PageFactory.InitElements(driver, automationPracticePage);
            PageFactory.InitElements(driver, carrinhoDeComprasPage);
            PageFactory.InitElements(driver, detelheItemPage);
        }

        [AfterScenario]
        public void FinalizarTeste()
        {
            driver.Quit();
            driver = null;
        }
    }
}
