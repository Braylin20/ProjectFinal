using FinalProject.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services
{
    public class UsuariosServices(Context _context)
    {
        public async Task<IEnumerable<Usuarios>> GetUsuarios()
        {
            return await _context.Usuarios.
                Include(u => u.Abogados).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.EstadoDemanda).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.TipoDemanda).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.Demandados).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Sentencia).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Sentencia)
                .ThenInclude(s => s!.TipoResoluciones).
                Include(u => u.Niños).
                Include(u => u.Roles)
                .AsNoTracking().ToListAsync();
        }

        public async Task<Usuarios?> GetUsuario(short id)
        {
            return await _context.Usuarios.Include(u => u.Abogados).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.EstadoDemanda).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.TipoDemanda).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Demandas)
                .ThenInclude(d => d!.Demandados).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Sentencia).
                Include(u => u.Expedientes)
                .ThenInclude(e => e.ExpedientesDetalles)
                .ThenInclude(e => e.Sentencia)
                .ThenInclude(s => s!.TipoResoluciones).
                Include(u => u.Niños)
                .SingleOrDefaultAsync(u => u.UsuarioId == id);
        }

        public async Task<Usuarios> Save(Usuarios usuarios)
        {
            _context.Usuarios.Add(usuarios);
            await _context.SaveChangesAsync();
            return usuarios;
        }
    }
}
