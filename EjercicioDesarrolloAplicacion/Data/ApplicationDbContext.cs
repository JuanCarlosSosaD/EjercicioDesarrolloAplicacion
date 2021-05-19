using EjercicioDesarrolloAplicacion.Model;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDesarrolloAplicacion.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PermitType>().HasData(new PermitType
            {
                ID = 1,
                Description = "Sickness"
            });
            modelBuilder.Entity<PermitType>().HasData(new PermitType
            {
                ID = 2,
                Description = "Errands"
            });
            modelBuilder.Entity<PermitType>().HasData(new PermitType
            {
                ID = 3,
                Description = "Other"
            });
        }
        public DbSet<Permit> Permit { get; set; }
        public DbSet<PermitType> PermitType { get; set; }
    }
}
