using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using Swashbuckle.Swagger;
using System.Web.Http;

namespace Exercicis
{
    public class AppConfig
    {
        public static void IoC()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.Load("Exercicis.Services"))
                .AsImplementedInterfaces();

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }

        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}