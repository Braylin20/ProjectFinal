using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services;

public class DemandasServices(Context _context)
{
    public async Task<IEnumerable<Demandas>> GetDemandas()
    {
        return await _context.Demandas.Include(d => d.TipoDemanda).Include(d => d.Audiencias).Include(d => d.Demandados)
            .Include(d => d.EstadoDemanda).Include(d => d.TipoDemanda)
            .AsNoTracking().ToListAsync();
    }

    public async Task<Demandas?> GetDemanda(short id)
    {
        return await _context.Demandas.FindAsync(id);
    }

    public async Task<Demandas> Save(Demandas demandas)
    {
        _context.Demandas.Add(demandas);
        await _context.SaveChangesAsync();
        return demandas;
    }
}
