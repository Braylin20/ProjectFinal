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
            return await _context.Usuarios.Include(u =>u.Expedientes).
                Include(u=>u.Demandas)
                .ThenInclude(d=>d.TiposDemandas).
                Include(u => u.Demandas)
                .ThenInclude(d=>d.Audiencias).
                Include(u=>u.Niños).
                Include(u=>u.Abogados).AsNoTracking().ToListAsync();
        }

        public async Task<Usuarios?> GetUsuario(short id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<Usuarios> Save(Usuarios department)
        {
            _context.Usuarios.Add(department);
            await _context.SaveChangesAsync();
            return department;
        }
    }
}
