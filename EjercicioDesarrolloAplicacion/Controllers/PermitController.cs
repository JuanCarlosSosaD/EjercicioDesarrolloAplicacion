using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EjercicioDesarrolloAplicacion.Data;
using EjercicioDesarrolloAplicacion.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EjercicioDesarrolloAplicacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermitController : ControllerBase
    {
        private ApplicationDbContext _context;

        public PermitController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _context.Permit.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            Permit permit = await _context.Permit.FindAsync(id);
            if (permit == null)
            {
                return NotFound();
            }
            return Ok(permit);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Permit permit)
        {
            try
            {
                _context.Add(permit);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(Create), permit);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpPut]
        public async Task<IActionResult> Edit(Permit permit)
        {
            try
            {
                _context.Update(permit);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Permit permit = await _context.Permit.FindAsync(id);
                if (permit == null)
                {
                    return NotFound();
                }
                _context.Remove(permit);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}