using EDA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EDA.Infraestructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EDA.Infraestructure.Repositories
{
    public class PermitTypeRepository : EDA.Domain.Repositories.IPermitTypeRepository
    {
        private ApplicationDbContext _context;
        public PermitTypeRepository(ApplicationDbContext context) => _context = context;
        public async Task Delete(int id)
        {
            Domain.Entities.PermitType permit = await _context.PermitType.FindAsync(id);
            if (permit != null)
            {
                _context.Remove(permit);
            }
        }

        public async Task<IEnumerable<PermitType>> GetAsync()
        {
            return await _context.PermitType.ToListAsync();
        }

        public async Task<PermitType> GetAsync(int? id)
        {
            return await _context.PermitType.FindAsync(id);
        }

        public async Task<PermitType> CreateAsync(PermitType entity)
        {
            await _context.AddAsync(entity);
            return entity;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public PermitType Update(PermitType entity)
        {
             _context.Update(entity);
            return entity;
        }
    }
}
