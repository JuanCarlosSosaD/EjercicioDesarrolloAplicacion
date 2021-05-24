using EDA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EDA.Infraestructure;
using EDA.Infraestructure.Contexts;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EDA.Infraestructure.Repositories
{
    public class PermitRepository : EDA.Domain.Repositories.IPermitRepository
    {
        private ApplicationDbContext _context;

        public PermitRepository(ApplicationDbContext context) => _context = context;

        public async Task DeleteAsync(int id)
        {
            Domain.Entities.Permit permit = await _context.Permit.FindAsync(id);
            if (permit != null)
            {
                _context.Remove(permit);
            }
        }

        public async Task<IEnumerable<Permit>> GetAsync()
        {
            return await _context.Permit.Include(t => t.PermitType).ToListAsync();
        }

        public async Task<Permit> GetAsync(int? id)
        {
            var result = await _context.Permit.Include(t => t.PermitType).FirstOrDefaultAsync(t => t.ID == id);
            return result;
        }

        public async Task<Permit> CreateAsync(Permit entity)
        {
            await _context.AddAsync(entity);
            return entity;

        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public Permit Update(Permit entity)
        {
            _context.Update(entity);
            return entity;
        }
    }
}
