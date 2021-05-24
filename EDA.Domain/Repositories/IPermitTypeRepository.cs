using EDA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Domain.Repositories
{
    public interface IPermitTypeRepository
    {
        Task<IEnumerable<PermitType>> GetAsync();
        Task<PermitType> GetAsync(int? id);
        Task<PermitType> CreateAsync(PermitType entity);
        PermitType Update(PermitType entity);
        Task Delete(int id);
        Task SaveAsync();
    }
}
