using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MovieCollectionSystemBackend.Infrastructure.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjections).Assembly;
            services.AddMediatR(assembly);
            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
