using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services
{
    public class SentenciasServices(Context _context)
    {
        public async Task<IEnumerable<Sentencias>> GetSentencias()
        {
            return await _context.Sentencias.AsNoTracking().ToListAsync();
        }

        public async Task<Sentencias?> GetSentencia(short id)
        {
            return await _context.Sentencias.FindAsync(id);
        }

        public async Task<Sentencias> Save(Sentencias sentencias)
        {
            _context.Sentencias.Add(sentencias);
            await _context.SaveChangesAsync();
            return sentencias;
        }
    }
}
