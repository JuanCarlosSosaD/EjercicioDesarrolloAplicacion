using EDA.Domain.ApiModels;
using EDA.Domain.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Domain.Supervisor
{
    public partial class EDASupervisor : IEDASupervisor
    {
        public async Task<IEnumerable<PermitTypeApiModel>> GetPermitTypes()
        {
            var result = await _permitTypeRepository.GetAsync();
            return result.ConvertAll();
        }
    }
}
