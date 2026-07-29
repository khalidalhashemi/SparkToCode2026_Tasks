using E_CommerceTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_CommerceTask
{
    public class ProjectContext : DbContext
    {
        // Register model
        DbSet<User> users { get; set; }
        DbSet<Product> products { get; set; }
        DbSet<Category> categories { get; set; }
        DbSet<Review> reviews { get; set; }
        DbSet<Order> orders { get; set; }
        DbSet<OrderProduct> orderProducts { get; set; }



        // Connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=E-CommerceDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

    }
}
