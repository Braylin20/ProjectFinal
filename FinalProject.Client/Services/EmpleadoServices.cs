using Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace FinalProject.Client.Services
{
    public class EmpleadoServices(HttpClient httpClient)
    {
        public async Task<List<Empleados>?> GetEmpleados()
        {
            return await httpClient
                 .GetFromJsonAsync<List<Empleados>>("api/Empleados");
        }

        public async Task<Empleados?> GetEmpleado(int id)
        {
            return await httpClient
                .GetFromJsonAsync<Empleados>($"api/Empleados/{id}");
        }
        public async Task<Empleados?> Save(Empleados empleado)
        {
            var empleadoGuardado = await httpClient
                .PostAsJsonAsync("api/Empleados", empleado);
            if (!empleadoGuardado.IsSuccessStatusCode)
            {
                return null;
            }
            return await empleadoGuardado.Content.ReadFromJsonAsync<Empleados>();
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"api/Empleados/{id}");
        }
        public async Task<bool> Edit(int id, Empleados empleado)
        {
            var EmpleadoEditado = await httpClient.PutAsJsonAsync($"api/Empleados/{id}", empleado);
            if (!EmpleadoEditado.IsSuccessStatusCode)
            {
                return false;
            }
            return true;
        }
    }
}
