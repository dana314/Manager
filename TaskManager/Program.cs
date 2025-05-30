using Microsoft.Extensions.DependencyInjection;
using Manage.Core;
using Manage.Data;
namespace Manage.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            var provider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(provider.GetRequiredService<Manager>());
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IManagerRepository, ManagerRepository>();
            services.AddTransient<Manager>();
        }
    }
}