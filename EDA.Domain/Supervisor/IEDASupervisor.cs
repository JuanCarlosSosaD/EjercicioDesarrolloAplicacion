using EDA.Domain.ApiModels;
using EDA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Domain.Supervisor
{
    public interface IEDASupervisor
    {
        //Permit
        public Task<IEnumerable<PermitAPIModel>> GetPermits();
        public Task<PermitAPIModel> GetPermit(int? id);
        public Task<PermitAPIModel> CreatePermit(PermitAPIModel permitAPIModel);
        public Task UpdatePermit(PermitAPIModel permitAPIModel);
        public Task DeletePermit(int id);


        //PermitType
        public Task<IEnumerable<PermitTypeApiModel>> GetPermitTypes();
    }
}
