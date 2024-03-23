using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services
{
    public class ExpedientesServices(Context _context)
    {

        public async Task<IEnumerable<Expedientes>> GetExpedientes()
        {
            return await _context.Expedientes.
                Include(e=>e.ExpedientesDetalles)
                .ThenInclude(e=>e.Demandas)
                .ThenInclude(d=>d!.Demandados).
                Include(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.Audiencias).
                Include(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.TipoDemanda).
                Include(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.EstadoDemanda).
                Include(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Sentencia).
                 ThenInclude(s=>s!.TipoResoluciones).
                Include(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Sentencia).
                AsNoTracking().
                ToListAsync();
        }

        public async Task<Expedientes?> GetExpediente(short id)
        {
            return await _context.Expedientes.
                Include(e=>e.ExpedientesDetalles).
                FirstOrDefaultAsync(e=>e.ExpedienteId ==id);
        }

        public async Task<Expedientes> Save(Expedientes expediente)
        {
            _context.Expedientes.Add(expediente);
            await _context.SaveChangesAsync();
            return expediente;
        }
    }
}
