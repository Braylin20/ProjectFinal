using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace FinalProject.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SentenciasController(SentenciasServices sentenciasServices): ControllerBase
    {
        // GET: api/GetSentencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sentencias>>> GetUsuarios()
        {
            var deps = await sentenciasServices.GetSentencias();
            return Ok(deps);
        }

        // GET: api/GetSentencias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sentencias>> GetUsuarios(short id)
        {
            return await sentenciasServices.GetSentencia(id);
        }

        // POST: api/GetSentencias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Sentencias>> SaveUsuarios(Sentencias sentencias)
        {
            var sentenciaSaved = await sentenciasServices.Save(sentencias);
            return Ok(sentenciaSaved);
        }
    }
}
