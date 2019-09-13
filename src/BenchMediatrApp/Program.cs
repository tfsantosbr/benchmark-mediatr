using System;
using System.IO;
using BenchmarkDotNet.Running;
using BenchMediatrApp.Data;
using BenchMediatrApp.Shared.Handlers;
using BenchMediatrApp.Users.Commands;
using BenchMediatrApp.Users.Handlers;
using BenchMediatrApp.Users.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BenchMediatrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var summary = BenchmarkRunner.Run<App>();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Empresas

            services.AddScoped<UserCommandsHandler>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IHandler<CreateUser>, UserCommandsHandler>();
            services.AddScoped<IHandler<UpdateUser>, UserCommandsHandler>();

            // Application

            services.AddTransient<App>();
        }
    }
}
