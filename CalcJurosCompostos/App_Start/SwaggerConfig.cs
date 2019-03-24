using System.Web.Http;
using WebActivatorEx;
using CalcJurosCompostos;
using Swashbuckle.Application;
using System;
using System.Linq;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace CalcJurosCompostos
{
    /// <summary>
    /// SwaggerConfig
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Register 
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "Swagger_Exemplo");

                    c.IgnoreObsoleteActions();
                    c.IncludeXmlComments($@"{AppDomain.CurrentDomain.BaseDirectory}\bin\CalcJurosCompostos.xml");
                    c.IgnoreObsoleteProperties();

                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                })
                .EnableSwaggerUi(c =>
                {
                    c.DocumentTitle("Exemplo de utilização do Swagger");
                    c.DocExpansion(DocExpansion.List);
                });
        }
    }
}
