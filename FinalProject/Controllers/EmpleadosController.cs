using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController(EmpleadosServices empleadosServices) : ControllerBase
    {
        // GET: api/GetEmpleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleados>>> GetUsuarios()
        {
            var deps = await empleadosServices.GetEmpleados();
            return Ok(deps);
        }

        // GET: api/GetEmpleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleados>> GetEmpleados(short id)
        {
            return await empleadosServices.GetEmpleado(id);
        }

        // POST: api/GetEmpleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empleados>> SaveUsuarios(Empleados empleados)
        {
            var empleadoSaved= await empleadosServices.Save(empleados);
            return Ok(empleadoSaved);
        }
    }
}
