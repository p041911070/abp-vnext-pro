using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace CompanyName.ProjectName.Blazor.Layout.AntDesignTheme
{
    [DependsOn(
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
)]
    public class ProjectNameBlazorLayoutAntDesignThemeModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var builder = context.Services.GetSingletonInstance<WebAssemblyHostBuilder>();
            
            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(ProjectNameBlazorLayoutAntDesignThemeModule).Assembly);
            });
      
        }


    }
}
