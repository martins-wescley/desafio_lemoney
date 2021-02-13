using Desafio_lemoney.Common;
using System;
using TechTalk.SpecFlow;

namespace Desafio_lemoney.Steps
{
    [Binding]
    public class AutomationPracticeSteps : BaseTests
    {
        [Given(@"que o usuário acesse a aplicação")]
        public void DadoQueOUsuarioAcesseAAplicacao()
        {
            automationPracticePage.AcessarAplicacao(driver);
        }

        [When(@"o usuário pesquisar pelo item '(.*)'")]
        public void QuandoOUsuarioPesquisarPeloItem(string item)
        {
            automationPracticePage.PesquisarItem(item);
            ScenarioContext.Current["itemPesquisado"] = item;
        }

        [Then(@"deverá ser exibido um resultado que contenha o valor informado na pesquisa")]
        public void EntaoDeveraSerExibidoUmResultadoQueContenhaOValorInformadoNaPesquisa()
        {
            string itemPesquisado = (string)ScenarioContext.Current["itemPesquisado"];
            automationPracticePage.ValidarItemPesquisado(itemPesquisado);
        }

        [When(@"selecionar o item pesquisado")]
        public void QuandoSelecionarOItemPesquisado()
        {
            automationPracticePage.SelecionarItem();
        }

        [When(@"adicionar o item no carrinho de compras")]
        public void QuandoAdicionarOItemNoCarrinhoDeCompras()
        {
            detelheItemPage.AdicionarItemNoCarrinho();
        }

        [Then(@"deverá ser exibido um modal com a mensagem '(.*)'")]
        public void EntaoDeveraSerExibidoUmModalComAMensagem(string msgEsperada)
        {
            EsperarElementoFicarVisivel(carrinhoDeComprasPage.MsgItemAdicionadoNoCarrinho);
            carrinhoDeComprasPage.ValidarMensagemModal(msgEsperada);
        }

        [Then(@"deverá ser exibido os dados do produto selecionado")]
        public void EntaoDeveraSerExibidoOsDadosDoProdutoSelecionado()
        {
            string itemAdicionado = (string)ScenarioContext.Current["itemPesquisado"];
            carrinhoDeComprasPage.ValidarDadosItem(itemAdicionado);
        }
    }
}
