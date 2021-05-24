using EDA.Infraestructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EDA.UnitTest.Repositories
{
    public class PermitTypeRepository : BaseTest
    {
        private EDA.Infraestructure.Repositories.PermitTypeRepository _repo;
        public PermitTypeRepository()
        {
          _repo = new Infraestructure.Repositories.PermitTypeRepository(_context);
        }

        [Fact]
        public async void GetPermitTypes()
        {
            var result = await _repo.GetAsync();
            Assert.True(result.ToList().Count > 1);
        }
    }
}
