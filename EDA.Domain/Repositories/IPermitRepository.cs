using EDA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EDA.Domain.Repositories
{
    public interface IPermitRepository
    {
        Task<IEnumerable<Permit>> GetAsync();
        Task<Permit> GetAsync(int? id);
        Task<Permit> CreateAsync(Permit entity);
        Permit Update(Permit entity);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}
