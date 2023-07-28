using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using desafio_lynx_process.Services;
using desafio_lynx_process.Services.interfaces;

namespace desafio_lynx_process.Middleware
{
    public static class ConfigServices
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<INumberService, NumberService>();
        }
    }
}