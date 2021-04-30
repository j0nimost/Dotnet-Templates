using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class ServiceCollectionExtensions
    {
        
        public static void AddClassLibrary(this IServiceCollection services)
        {
            services.AddSingleton<IClassLibrary, ClassLibrary>(v => new ClassLibrary(/*Add properties to inject*/));
        }
    }
}
