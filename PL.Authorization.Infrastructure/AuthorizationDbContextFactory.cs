﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PL.Authorization.Infrastructure.Configuration;

namespace PL.Authorization.Infrastructure
{
    public class AuthorizationDbContextFactory : IDesignTimeDbContextFactory<AuthorizationDbContext>
    {
        public AuthorizationDbContext CreateDbContext(string[] args)
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            //IConfiguration configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile($"moduleName.{envName}.json", optional: false)
            //    .Build()
            //    .GetSection("Module");
            //var optionsBuilder = new DbContextOptionsBuilder();
            //optionsBuilder.Configure(configuration);
            var dbContextOptionsBuilder = DatabaseModule.CreateDbContextOptionsBuilder("Data Source=:memory:");

            return new AuthorizationDbContext(dbContextOptionsBuilder.Options);
        }
    }
}
