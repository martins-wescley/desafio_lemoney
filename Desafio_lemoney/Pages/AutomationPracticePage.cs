using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;

namespace Desafio_lemoney.Pages
{
    public class AutomationPracticePage
    {
        [FindsBy(How = How.Id, Using = "search_query_top")]
        public IWebElement CampoPesquisar { get; set; }

        [FindsBy(How = How.Name, Using = "submit_search")]
        public IWebElement BotaoPesquisar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column h5 > a")]
        public IWebElement ItemPesquisado { get; set; }

        [FindsBy(How = How.Id, Using = "slider_row")]
        public IWebElement SlideFotos { get; set; }

        public void AcessarAplicacao(IWebDriver driver)
        {
            string Url = ConfigurationManager.AppSettings["UrlAplicacao"].ToString();
            driver.Navigate().GoToUrl(Url);
        }

        public void PesquisarItem(string item)
        {
            CampoPesquisar.SendKeys(item);
            BotaoPesquisar.Click();
        }

        public void ValidarItemPesquisado(string item)
        {
            string resultado = ItemPesquisado.Text;
            StringAssert.Contains(item, resultado);
        }

        public void SelecionarItem()
        {
            ItemPesquisado.Click();
        }
    }
}
