using EDA.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Infraestructure.Configuration
{
   public class PermitTypeConfiguration
    {
        public static void Configure(ModelBuilder modelBuilder)
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
    }
}
