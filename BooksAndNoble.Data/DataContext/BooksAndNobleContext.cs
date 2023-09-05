using BooksAndNoble.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAndNoble.Data.DataContext
{
    internal class BooksAndNobleContext : DbContext
    {
        // allows for database connection string dependency injection
        public BooksAndNobleContext(DbContextOptions<BooksAndNobleContext> options)
            :base(options)
        {}

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(config.GetConnectionString("DBConnection"));
            }
            
            /* Raw, insecure database connection string:
            optionsBuilder.UseNpgsql(
                $"Host=..." +
                $"Database=..." +
                $"Username=..." +
                $"Password=..."
            );
            */
        }
    }
}
