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

        public async Task<Audiencias?> GetAudiencia(int id)
        {
            return await _context.Audiencias.FindAsync(id);
        }

        public async Task<bool> DeleteAudiencia(int id)
        {
            return await _context.Audiencias
                .AsNoTracking()
                .Where(a => a.AudienciaId == id)
                .ExecuteDeleteAsync() > 0;
        }
        public async Task<Audiencias> Save(Audiencias audiencias)
        {
            _context.Audiencias.Add(audiencias);
            await _context.SaveChangesAsync();
            return audiencias;
        }
        public async Task<bool> Edit(Audiencias audiencia)
        {
            _context.Update(audiencia);
            _context.Entry(audiencia).State = EntityState.Modified;
            return await _context.SaveChangesAsync() >0;
        }
    }
}
