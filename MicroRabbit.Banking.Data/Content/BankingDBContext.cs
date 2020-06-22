using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Data.Content
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions<BankingDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@Directory.GetCurrentDirectory() + "/../MicroRabbit.Banking.Api/appsettings.json").Build();
          
            var builder = new DbContextOptionsBuilder<BankingDbContext>();
            //var connectionString = configuration.GetConnectionString("BankingDbConnection");
            var connectionString = "Server=localhost;Database=BankingDB;Trusted_Connection=True;";
            builder.UseSqlServer(connectionString);
            return new BankingDbContext(builder.Options);
        }
    }
}
