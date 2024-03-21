using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services
{
    public class ExpedientesServices(Context _context)
    {

        public async Task<IEnumerable<Expedientes>> GetExpedientes()
        {
            return await _context.Expedientes.AsNoTracking().ToListAsync();
        }

        public async Task<Expedientes?> GetExpediente(short id)
        {
            return await _context.Expedientes.FindAsync(id);
        }

        public async Task<Expedientes> Save(Expedientes expediente)
        {
            _context.Expedientes.Add(expediente);
            await _context.SaveChangesAsync();
            return expediente;
        }
    }
}
