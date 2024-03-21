using FinalProject.Dal;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services;

public class DemandasServices(Context _context)
{
    public async Task<IEnumerable<Demandas>> GetDemandas()
    {
        return await _context.Demandas
            .AsNoTracking().ToListAsync();
    }

    public async Task<Demandas?> GetDemanda(short id)
    {
        return await _context.Demandas.FindAsync(id);
    }

    public async Task<Demandas> Save(Demandas demandas)
    {
        _context.Demandas.Add(department);
        await _context.SaveChangesAsync();
        return department;
    }
}
