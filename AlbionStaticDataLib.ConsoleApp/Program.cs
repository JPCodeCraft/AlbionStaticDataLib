using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AlbionStaticDataLib.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddAlbionServices(new HttpClient());
            builder.Services.AddHostedService<CraftWorker>();

            IHost host = builder.Build();



            host.Run();
        }

    }
}
