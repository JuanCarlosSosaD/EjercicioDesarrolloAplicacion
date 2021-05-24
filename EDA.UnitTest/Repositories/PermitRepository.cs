using EDA.UnitTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace EDA.UnitTest.Repositories
{
    public class PermitRepository : BaseTest
    {
        private EDA.Infraestructure.Repositories.PermitRepository _repo;
        public PermitRepository()
        {
            _repo = new Infraestructure.Repositories.PermitRepository(_context);
        }

        [Fact]
        public async void GetPermits()
        {
            TestData.AddMultipleTestData(_repo);
            var result = await _repo.GetAsync();
            Assert.True(result.ToList().Count > 0);
        }

        [Fact]
        public async void AddPermit()
        {
            var result = await _repo.CreateAsync(new Domain.Entities.Permit
            {
                PermitDate = DateTime.Now,
                PermitTypeId = 1,
                EmployeeName = "Juan",
                EmployeeLastName = "Sosa"
            });
            await _repo.SaveAsync();
            Assert.True(result.ID == 1);
        }

        [Fact]
        public async void GetPermit()
        {
            TestData.AddTestData(_repo);
            var result = await _repo.GetAsync(1);
            Assert.True(result.ID == 1);
        }

        [Fact]
        public async void UpdatePermit()
        {
            TestData.AddTestData(_repo);
            var permit = await _repo.GetAsync(1);
            permit.EmployeeLastName = "De la Cruz";
            var result = _repo.Update(permit);
            await _repo.SaveAsync();

            Assert.True(result.EmployeeLastName == "De la Cruz");
        }

        [Fact]
        public async void DeletePermit()
        {
            TestData.AddTestData(_repo);
            await _repo.DeleteAsync(1);
            await _repo.SaveAsync();
            var result = await _repo.GetAsync(1);
            Assert.Null(result);
        }

    }
}
