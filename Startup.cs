﻿using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using InprocDniStartupFailure;
using System.Reflection;
using System;

[assembly: FunctionsStartup(typeof(Startup))]
namespace InprocDniStartupFailure
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Environment.CurrentDirectory)
               .AddJsonFile("secrets.json")
               .AddUserSecrets(Assembly.GetExecutingAssembly())
               .AddEnvironmentVariables()
               .Build();

            builder.Services.AddSingleton<IConfiguration>(config);
        }
    }
}
