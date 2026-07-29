using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext // OOP Inhertance
    {
        // 1. Register models
        public DbSet<Employee> employees {  get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Dependent> dependents { get; set; }
        public DbSet<DepLocation> deplocations { get; set; }
        public DbSet<empProj> empProjs { get; set; }



        // 2. Connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=CompanyProject;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
