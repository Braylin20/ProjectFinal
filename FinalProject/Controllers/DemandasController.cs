using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandasController(DemandasServices demandasServices) :ControllerBase
    {
        // GET: api/GetDemandas
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Demandas>>> GetUsuarios()
        //{
        //    var deps = await demandasServices.GetDemandas();
        //    return Ok(deps);
        //}

        // GET: api/GetDemandas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Demandas>> GetUsuarios(short id)
        {
            return await demandasServices.GetDemanda(id);
        }

        // POST: api/GetDemandas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Demandas>> SaveUsuarios(Demandas demandas)
        {
            var demandaSaved = await demandasServices.Save(demandas);
            return Ok(demandaSaved);
        }
    }
}
