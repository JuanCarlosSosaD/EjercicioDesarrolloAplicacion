using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDA.Domain.Supervisor;
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

        private IEDASupervisor _edaSupervisor;

        public PermitController(IEDASupervisor edaSupervisor)
        {
            _edaSupervisor = edaSupervisor;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _edaSupervisor.GetPermits();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int? id)
        {
            var result = await _edaSupervisor.GetPermit(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EDA.Domain.ApiModels.PermitAPIModel permit)
        {
            try
            {
                var result = await _edaSupervisor.CreatePermit(permit);
                return CreatedAtAction(nameof(Create), permit);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EDA.Domain.ApiModels.PermitAPIModel permit)
        {
            try
            {
                await _edaSupervisor.UpdatePermit(permit);
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
                var permit = await _edaSupervisor.GetPermit(id);
                if (permit == null)
                {
                    return NotFound();
                }
                await _edaSupervisor.DeletePermit(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}