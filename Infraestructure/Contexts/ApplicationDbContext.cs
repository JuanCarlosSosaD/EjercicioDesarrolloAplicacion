//using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDA.Domain;
using EDA.Domain.Entities;

namespace EDA.Infraestructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Configuration.PermitTypeConfiguration.Configure(modelBuilder);
        }
        public DbSet<Permit> Permit { get; set; }
        public DbSet<PermitType> PermitType { get; set; }
    }
}
