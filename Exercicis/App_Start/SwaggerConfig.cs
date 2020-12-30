using System.Web.Http;
using WebActivatorEx;
using Exercicis;
using Swashbuckle.Application;
using System.IO;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace Exercicis
{
    public class SwaggerConfig
    {
        protected static string GetXmlCommentsPath()
        {
            return Path.Combine(System.Web.HttpRuntime.AppDomainAppPath, "bin", "Exercicis.xml");
        }

        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {   
                        // Use "SingleApiVersion" to describe a single version API. Swagger 2.0 includes an "Info" object to
                        // hold additional metadata for an API. Version and title are required but you can also provide
                        // additional fields by chaining methods off SingleApiVersion.
                        //
                        c.SingleApiVersion("v1", "Exercicis")
                            .Description("API de prova per exercicis de formació en À Punt")
                            .License(x => x.Name("Sopra Steria"))
                            .Contact(p => p.Name("Rafa Requeni"));

                        // If you want the output Swagger docs to be indented properly, enable the "PrettyPrint" option.
                        //
                        c.PrettyPrint();

                        // If you annotate Controllers and API Types with
                        // Xml comments (http://msdn.microsoft.com/en-us/library/b2s063f7(v=vs.110).aspx), you can incorporate
                        // those comments into the generated docs and UI. You can enable this by providing the path to one or
                        // more Xml comment files.
                        //
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi();
        }
    }
}
