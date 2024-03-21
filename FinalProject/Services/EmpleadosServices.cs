using FinalProject.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace FinalProject.Services
{
    public class EmpleadosServices(Context _context)
    {
        public async Task<IEnumerable<Empleados>> GetEmpleados()
        {
            return await _context.Empleados.AsNoTracking().ToListAsync();
        }

        public async Task<Empleados?> GetEmpleado(short id)
        {
            return await _context.Empleados.FindAsync(id);
        }

        public async Task<Empleados> Save(Empleados empleado)
        {
            _context.Empleados.Add(empleado);
            await _context.SaveChangesAsync();
            return empleado;
        }
    }
}
