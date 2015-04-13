using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace katana.webapi
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://192.168.10.8:5000/";//"http://localhost:5000/";

            using (WebApp.Start<Startup>(new StartOptions(baseUrl) { ServerFactory = "Microsoft.Owin.Host.HttpListener" }))
            {
                // Launch the browser
                //Process.Start(baseUrl);

                // Keep the server going until we're done
                Console.WriteLine("Press Any Key To Exit");
                Console.ReadKey();
            }
        }
    }
}
