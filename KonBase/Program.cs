﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace KonBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            // TEMP CONFIG BUILDER TO GET THE VALUES IN THE ELASTIC BEANSTALK CONFIG
            IConfigurationBuilder tempConfigBuilder = new ConfigurationBuilder();

            tempConfigBuilder.AddJsonFile(
                @"C:\Program Files\Amazon\ElasticBeanstalk\config\containerconfiguration",
                optional: true,
                reloadOnChange: true
            );

            IConfigurationRoot tempConfig = tempConfigBuilder.Build();

            Dictionary<string, string> ebConfig = ElasticBeanstalk.GetConfig(tempConfig);

            // START WEB HOST BUILDER
            IWebHostBuilder builder = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory());

            // CHECK IF EBCONFIG HAS ENVIRONMENT KEY IN IT
            // IF SO THEN CHANGE THE BUILDERS ENVIRONMENT
            const string envKey = "ASPNETCORE_ENVIRONMENT";

            if (ebConfig.ContainsKey(envKey))
            {
                string ebEnvironment = ebConfig[envKey];
                builder.UseEnvironment(ebEnvironment);
            }

            // CONTINUE WITH WEB HOST BUILDER AS NORMAL
            builder.ConfigureAppConfiguration((hostingContext, config) =>
            {
                IHostingEnvironment env = hostingContext.HostingEnvironment;

                // ADD THE ELASTIC BEANSTALK CONFIG DICTIONARY
                config.AddJsonFile(
                        "appsettings.json",
                        optional: true,
                        reloadOnChange: true
                    )
                    .AddJsonFile(
                        $"appsettings.{env.EnvironmentName}.json",
                        optional: true,
                        reloadOnChange: true
                    )
                    .AddInMemoryCollection(ebConfig);

                if (env.IsDevelopment())
                {
                    Assembly appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
                    if (appAssembly != null)
                    {
                        config.AddUserSecrets(appAssembly, optional: true);
                    }
                }

                config.AddEnvironmentVariables();

                if (args != null)
                {
                    config.AddCommandLine(args);
                }
            })
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .UseIISIntegration()
                .UseDefaultServiceProvider(
                    (context, options) => { options.ValidateScopes = context.HostingEnvironment.IsDevelopment(); })
                .ConfigureServices(
                    services =>
                    {
                        services.AddTransient<IConfigureOptions<KestrelServerOptions>, KestrelServerOptionsSetup>();
                    });

            return builder.UseStartup<Startup>();
        }

        public static class ElasticBeanstalk
        {
            public static Dictionary<string, string> GetConfig(IConfiguration configuration)
            {
                return
                    configuration.GetSection("iis:env")
                        .GetChildren()
                        .Select(pair => pair.Value.Split(new[] { '=' }, 2))
                        .ToDictionary(keypair => keypair[0], keypair => keypair[1]);
            }
        }

        // WebHost.CreateDefaultBuilder(args)
        //   .UseStartup<Startup>();
    }
}
