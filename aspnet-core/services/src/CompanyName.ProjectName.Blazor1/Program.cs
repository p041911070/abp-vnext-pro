using AntDesign.ProLayout;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyName.ProjectName.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            var application = builder.AddApplication<ProjectNameBlazorModule>(options =>
            {
                options.UseAutofac();
            });

            var host = builder.Build();
            await application.InitializeAsync(host.Services);
        }
    }
}