using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Azure;

namespace ADO.NET___MiniInsta
{
    internal class MiniInstaContext : DbContext
    {
        private readonly string _connectionString;
        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Tags> Tags { get; set; }

        public MiniInstaContext()
        {
            _connectionString = ConfigurationManager
             .ConnectionStrings["DefaultConnectionString"]
             .ConnectionString;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }


    }
}
