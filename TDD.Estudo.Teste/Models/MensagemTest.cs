using System;
using TDD.Estudo.Models;
using NUnit.Framework;

namespace TDD.Estudo.Teste.Models
{
    [TestFixture]
    public class MensagemTest
    {
        public MensagemTest()
        {

        }


        [Test]
        public void Test_Mensagem_Constructor()
        {
            DateTime DataAtual = DateTime.Now;
            string sTexto = "Teste de Texto";

            //EXECUCAO
            Mensagem oMsg = new Mensagem();

            oMsg.Texto = sTexto;
            oMsg.DataCriacao = DateTime.Now;

            Assert.AreEqual(DataAtual, oMsg.DataCriacao);
            Assert.AreEqual(sTexto, oMsg.Texto);

        }
    }
}
