using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;
using Shared1.Models;

namespace FinalProject.Services
{
    public class EmpleadoSentenciaServices(Context _context)
    {
        public async Task<IEnumerable<EmpleadoSentencia>> GetEmpleadoSentencias()
        {
            return await _context.EmpleadoSentencia.
                Include(es=>es.Empleado).
                Include(es=>es.Sentencia).ThenInclude(s=>s.TipoResoluciones).
                AsNoTracking().
                ToListAsync();
        }

        public async Task<EmpleadoSentencia?> GetEmpleadoSentencia(short id)
        {
            return await _context.EmpleadoSentencia.
                Include(es => es.Empleado).
                Include(es => es.Sentencia)
                .SingleOrDefaultAsync(es=>es.EmpleadoSentenciaId == id);
        }

        public async Task<EmpleadoSentencia> Save(EmpleadoSentencia empleadoSentencia)
        {
            _context.EmpleadoSentencia.Add(empleadoSentencia);
            await _context.SaveChangesAsync();
            return empleadoSentencia;
        }
    }
}

