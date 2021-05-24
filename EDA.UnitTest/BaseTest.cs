using EDA.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDA.UnitTest
{
   public class BaseTest
    {
        protected ApplicationDbContext _context;
        public BaseTest(ApplicationDbContext context = null)
        {
            this._context = context ?? GetInMemoryDBContext();
        }
        protected ApplicationDbContext GetInMemoryDBContext()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var options = builder.UseInMemoryDatabase("EDA").UseInternalServiceProvider(serviceProvider).Options;

            ApplicationDbContext dbContext = new ApplicationDbContext(options);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            return dbContext;
        }
    }
}
