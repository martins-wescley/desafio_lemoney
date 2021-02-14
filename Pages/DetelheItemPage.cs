using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Desafio_lemoney.Pages
{
    public class DetelheItemPage
    {
        [FindsBy(How = How.Id, Using = "add_to_cart")]
        public IWebElement BotaoAdicionarAoCarrinho { get; set; }

        [FindsBy(How = How.Id, Using = "color_14")]
        public IWebElement BotaoTrocarCorItem { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[title='Return to Home']")]
        public IWebElement BotaoPaginaInicial { get; set; }

        public void AdicionarItemNoCarrinho()
        {
            BotaoAdicionarAoCarrinho.Click();
        }
    }
}
