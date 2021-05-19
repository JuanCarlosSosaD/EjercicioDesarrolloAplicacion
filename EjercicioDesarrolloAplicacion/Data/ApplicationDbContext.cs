using EjercicioDesarrolloAplicacion.Model;
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
        public DbSet<Permit> Permiso { get; set; }
        public DbSet<PermitType> TipoPermiso { get; set; }
    }
}
