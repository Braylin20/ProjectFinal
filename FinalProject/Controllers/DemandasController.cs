using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandasController :ControllerBase
    {
        // GET: api/GetUsuarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuarios>>> GetUsuarios()
        {
            var deps = await usuariosServices.GetUsuarios();
            return Ok(deps);
        }

        // GET: api/GetDepartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> GetUsuarios(short id)
        {
            return await usuariosServices.GetUsuario(id);
        }

        // POST: api/GetUsuarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Usuarios>> SaveUsuarios(Usuarios usuario)
        {
            var usuarioSaved = await usuariosServices.Save(usuario);
            return Ok(usuarioSaved);
        }
    }
}
