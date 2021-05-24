using System;
using System.Collections.Generic;
using System.Text;

namespace EDA.UnitTest.Common
{
    public class TestData
    {
        public static async void AddTestData(Infraestructure.Repositories.PermitRepository _repo)
        {
            var result = await _repo.CreateAsync(new Domain.Entities.Permit
            {
                PermitDate = DateTime.Now,
                PermitTypeId = 1,
                EmployeeName = "Juan",
                EmployeeLastName = "Sosa"
            });
            await _repo.SaveAsync();
        }

        public static async void AddMultipleTestData(Infraestructure.Repositories.PermitRepository _repo)
        {
            await _repo.CreateAsync(new Domain.Entities.Permit
            {
                PermitDate = DateTime.Now,
                PermitTypeId = 1,
                EmployeeName = "Juan",
                EmployeeLastName = "Sosa"
            });

            await _repo.CreateAsync(new Domain.Entities.Permit
            {
                PermitDate = DateTime.Now,
                PermitTypeId = 2,
                EmployeeName = "Pedro",
                EmployeeLastName = "Martínez"
            });

            await _repo.CreateAsync(new Domain.Entities.Permit
            {
                PermitDate = DateTime.Now,
                PermitTypeId = 2,
                EmployeeName = "Frank",
                EmployeeLastName = "Soto"
            });

            await _repo.SaveAsync();
        }
    }
}
