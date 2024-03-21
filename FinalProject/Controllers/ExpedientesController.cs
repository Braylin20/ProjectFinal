using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Dal;
using Shared.Models;
using FinalProject.Services;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpedientesController(ExpedientesServices expedientesServices) : ControllerBase
    {
        private readonly Context _context;

    

        // GET: api/Expedientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleados>>> GetExpedientes()
        {
            var expe = await expedientesServices.GetExpedientes();
            return Ok(expe);
        }

        // GET: api/Expedientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Expedientes>> GetExpedientes(short id)
        {
            var expedientes = await expedientesServices.GetExpediente(id);

            if (expedientes == null)
            {
                return NotFound();
            }

            return expedientes;
        }

       

        // POST: api/Expedientes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Expedientes>> PostExpedientes(Expedientes expedientes)
        {
            _context.Expedientes.Add(expedientes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpedientes", new { id = expedientes.ExpedienteId }, expedientes);
        }

       
    }
}
