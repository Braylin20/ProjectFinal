using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;
using Shared1.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoSentenciaController(EmpleadoSentenciaServices empleadoSentenciaServices) : ControllerBase
    {
        // GET: api/GetEmpleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpleadoSentencia>>> GetEmpleadoSentencias()
        {
            var deps = await empleadoSentenciaServices.GetEmpleadoSentencias();
            return Ok(deps);
        }

        // GET: api/GetEmpleados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpleadoSentencia>> GetEmpleadoSentencia(short id)
        {
            return await empleadoSentenciaServices.GetEmpleadoSentencia(id);
        }

        // POST: api/GetEmpleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpleadoSentencia>> SaveUsuarios(EmpleadoSentencia empleadoSentencia)
        {
            var empleadoSentenciaSaved = await empleadoSentenciaServices.Save(empleadoSentencia);
            return Ok(empleadoSentenciaSaved);
        }
    }
}
