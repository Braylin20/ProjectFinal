using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AudienciasController(AudienciasServices audienciasServices) :ControllerBase
    {
        // GET: api/GetUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Audiencias>>> GetAudiencias()
        {
            var deps = await audienciasServices.GetAudiencias();
            return Ok(deps);
        }

        // GET: api/GetUsuarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Audiencias>> GetAudiencia(int id)
        {
            return await audienciasServices.GetAudiencia(id);
        }

        // POST: api/GetUsuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Audiencias>> SaveUsuarios(Audiencias audiencias)
        {
            var audienciaSaved = await audienciasServices.Save(audiencias);
            return Ok(audienciaSaved);
        }
        // GET: api/GetUsuarios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Audiencias>> DeleteAudiencia(int id)
        {
            var eliminado = await audienciasServices.DeleteAudiencia(id);
            if(!eliminado)
            {
                return StatusCode(500);
            }
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Audiencias>> EditAudiencia( Audiencias audiencias)
        {
            var editado = await audienciasServices.Edit(audiencias);
            if (!editado)
            {
                return StatusCode(500);
            }
            return Ok();
        }
    }
}
