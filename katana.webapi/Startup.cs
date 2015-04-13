using System.Net.Http.Formatting;
using System.Web.Http;
using Owin;

namespace katana.webapi
{
    public class Startup
    {
        // Invoked once at startup to configure your application.
        public void Configuration(IAppBuilder builder)
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute("Default", "{controller}/{customerID}", new { controller = "Customer", customerID = RouteParameter.Optional });

            //config.Formatters.XmlFormatter.UseXmlSerializer = true;
           // config.Formatters.Remove(config.Formatters.JsonFormatter);
            // config.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());
            
            builder.UseWebApi(config);
        }
    }
}
