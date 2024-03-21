using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services
{
    public class AudienciasServices(Context _context)
    {
        public async Task<IEnumerable<Audiencias>> GetAudiencias()
        {
            return await _context.Audiencias.AsNoTracking().ToListAsync();
        }

        public async Task<Audiencias?> GetAudiencia(short id)
        {
            return await _context.Audiencias.FindAsync(id);
        }

        public async Task<Audiencias> Save(Audiencias audiencias)
        {
            _context.Audiencias.Add(audiencias);
            await _context.SaveChangesAsync();
            return audiencias;
        }
    }
}
