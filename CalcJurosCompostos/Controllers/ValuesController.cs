using System;
using System.Web.Http;

namespace CalcJurosCompostos.Controllers
{
    /// <summary>
    /// ApiController
    /// </summary>
    [RoutePrefix("api")]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Calcula Juros 
        /// </summary>
        /// <remarks>
        /// Faz um cálculo em memória, de juros compostos (1%).        
        /// </remarks> 
        /// <param name="valorinicial">Valor inicial</param>
        /// <param name="meses">Meses</param>
        /// <response code="400">Ocorreu um erro na exceção</response>
        [HttpGet, Route("calculajuros")]
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

        /// <summary>
        /// Show me the code 
        /// </summary>  
        /// <remarks>
        /// Retornar a url de onde encontra-se o fonte no github.
        /// </remarks>  
        /// <response code="400">Ocorreu um erro na exceção</response>
        [HttpGet, Route("showmethecode")]
        public string ShowMeTheCode()
        {
            string sRet = string.Empty;
            sRet = "URL: https://github.com/thiagoeleuterio/CalcJurosCompostos.git";

            return sRet;
        }
    }
}