using E_CommerceTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceTask
{
    public class AppDBContext : DbContext
    {
        // Register model
        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderProduct> orderProducts { get; set; }



        // Connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=E-CommerceDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

    }
}
