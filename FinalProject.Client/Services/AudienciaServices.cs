using Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace FinalProject.Client.Services
{
    public class AudienciaServices(HttpClient httpClient)
    {
        public async Task<List<Audiencias>?> GetAudiencias()
        {
            return await httpClient
                 .GetFromJsonAsync<List<Audiencias>>("api/Audiencias");
        }

        public async Task<Audiencias?> GetAudiencias(int id)
        {
            return await httpClient
                .GetFromJsonAsync<Audiencias>($"api/Audiencias/{id}");
        }
        public async Task<Audiencias?> Save(Audiencias audiencia)
        {
            var audienciaGuardada = await httpClient
                .PostAsJsonAsync("api/Audiencias", audiencia);
            if(!audienciaGuardada.IsSuccessStatusCode)
            {
                return null;
            }
            return await audienciaGuardada.Content.ReadFromJsonAsync<Audiencias>();
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync($"api/Audiencias/{id}");
        }
        public async Task<bool> Edit(int id, Audiencias audiencia)
        {
            var audienciaEditada=await httpClient.PutAsJsonAsync($"api/Audiencias/{id}", audiencia);
            if (!audienciaEditada.IsSuccessStatusCode)
            {
                return false;
            }
            return true;
        }
    }
}
