using EDA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EDA.Domain.Extensions;
using EDA.Domain.ApiModels;

namespace EDA.Domain.Supervisor
{
    public partial class EDASupervisor : IEDASupervisor
    {
        public async Task<IEnumerable<PermitAPIModel>> GetPermits()
        {
            var permits = await _permitRepository.GetAsync();
            return permits.ConvertAll();
        }

        public async Task<PermitAPIModel> GetPermit(int? id)
        {
            var permit = await _permitRepository.GetAsync(id);
            return permit.Convert();
        }

        public async Task<PermitAPIModel> CreatePermit(PermitAPIModel permitAPIModel)
        {
            var permit = permitAPIModel.Convert();
            await _permitRepository.CreateAsync(permit);
            await _permitRepository.SaveAsync();
            return permit.Convert();
        }

        public async Task UpdatePermit(PermitAPIModel permitAPIModel)
        {
            var permit = permitAPIModel.Convert();
            _permitRepository.Update(permit);
            await _permitRepository.SaveAsync();
        }

        public async Task DeletePermit(int id)
        {
            var permit = await _permitRepository.GetAsync(id);
            if (permit != null)
            {
                await _permitRepository.DeleteAsync(id);
                await _permitRepository.SaveAsync();
            }

        }
    }
}
