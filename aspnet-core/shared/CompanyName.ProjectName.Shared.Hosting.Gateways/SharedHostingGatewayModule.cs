﻿using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace CompanyName.ProjectName.Shared.Hosting.Gateways
{
    [DependsOn(
        typeof(AbpSwashbuckleModule),
        typeof(AbpAutofacModule))]
    public class SharedHostingGatewayModule : AbpModule
    {
   
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            ConfigureOcelot(context);
        }

        /// <summary>
        /// Ocelot配置
        /// </summary>
        private static void ConfigureOcelot(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            context.Services.AddOcelot(configuration);
        }

    }
}