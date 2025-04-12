using MediatR;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieCollectionSystemBackend.Application.Extensions
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(DependencyInjections).Assembly;
            services.AddMediatR(assembly);

            services.AddValidatorsFromAssembly(assembly);

            return services;
        }
    }
}
