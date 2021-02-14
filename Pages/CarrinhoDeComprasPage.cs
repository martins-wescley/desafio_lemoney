using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace Desafio_lemoney.Pages
{
    public class CarrinhoDeComprasPage
    {

        [FindsBy(How = How.CssSelector, Using = ".layer_cart_product h2")]
        public IWebElement MsgItemAdicionadoNoCarrinho { get; set; }

        [FindsBy(How = How.Id, Using = "layer_cart_product_title")]
        public IWebElement NomeProduto { get; set; }

        [FindsBy(How = How.Id, Using = "layer_cart_product_quantity")]
        public IWebElement QuantidadeProduto { get; set; }

        [FindsBy(How = How.Id, Using = "layer_cart_product_price")]
        public IWebElement PrecoProduto { get; set; }

        [FindsBy(How = How.Id, Using = "layer_cart")]
        public IWebElement ModalCarrinhoDeCompras { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[title='Continue shopping']")]
        public IWebElement BotaoContinueShopping { get; set; }

        public void ValidarMensagemModal(String msgEsperada)
        {
            string msgAtual = MsgItemAdicionadoNoCarrinho.Text;
            Assert.AreEqual(msgEsperada, msgAtual);
        }

        public void ValidarDadosItem(String item)
        {
            String precoEsperado;
            int quantidadeEsperada = 1;

            if (item.Equals("T-shirt"))
            {
                precoEsperado = "$16.51";
            }
            else
            {
                precoEsperado = "$27.00";
            }

            String nome = NomeProduto.Text;
            String quantidadeAtual = QuantidadeProduto.Text;
            String precoAtual = PrecoProduto.Text;

            StringAssert.Contains(item, nome);
            Assert.AreEqual(quantidadeEsperada, int.Parse(quantidadeAtual));

            Assert.AreEqual(precoEsperado, precoAtual);
        }
    }
}
