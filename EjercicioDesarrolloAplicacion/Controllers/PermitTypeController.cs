using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDA.Domain.Supervisor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EjercicioDesarrolloAplicacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermitTypeController : ControllerBase
    {
        private IEDASupervisor _edaSupervisor;

        public PermitTypeController(IEDASupervisor edaSupervisor)
        {
            _edaSupervisor = edaSupervisor;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _edaSupervisor.GetPermitTypes();
            return Ok(result);
        }
    }
}