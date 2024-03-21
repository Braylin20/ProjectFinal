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
        public async Task<ActionResult<Audiencias>> GetAudiencia(short id)
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
    }
}
