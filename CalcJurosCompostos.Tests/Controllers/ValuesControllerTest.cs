using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcJurosCompostos;
using CalcJurosCompostos.Controllers;

namespace CalcJurosCompostos.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void GetShowMeTheCode_ShouldReturnShowMeTheCode()
        {
            var test = ShowMeTheCode();
            var controller = new ValuesController();

            var result = controller.ShowMeTheCode();
            Assert.AreEqual(test, result);
        }

        public string ShowMeTheCode()
        {
            string sRet = string.Empty;
            sRet = "URL: https://github.com/thiagoeleuterio/CalcJurosCompostos.git";

            return sRet;
        }

        [TestMethod]
        public void GetCalculaJuros_ShouldReturnCalculaJuros()
        {
            var test = CalculaJuros(100, 5);
            var controller = new ValuesController();

            var result = controller.CalculaJuros(100, 5);
            Assert.AreEqual(test, result);
        }

        public string CalculaJuros(decimal valorinicial, int meses)
        {
            // Valor
            decimal montante, principal = (decimal)valorinicial;
            // Parcelas
            int n = meses;
            // Taxa mensal
            double juros = 0.01; // 1% 

            montante = principal * (decimal)Math.Pow(1.0 + juros, meses);

            string sRet = string.Empty;
            sRet = "Valor Total: " + Math.Round(montante, 2) + "";

            return sRet;
        }
    }
}
