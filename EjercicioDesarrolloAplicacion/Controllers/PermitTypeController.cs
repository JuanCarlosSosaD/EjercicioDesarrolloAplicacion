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
    public class PermitTypeController : ControllerBase
    {
        private ApplicationDbContext _context;

        public PermitTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _context.PermitType.ToListAsync();
            return Ok(result);
        }
    }
}