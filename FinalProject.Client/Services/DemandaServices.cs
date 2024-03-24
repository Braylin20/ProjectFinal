using Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace FinalProject.Client.Services
{
    public class DemandaServices(HttpClient httpClient)
    {
        public async Task<List<Demandas>?> GetDemandas()
        {
            return await httpClient
                 .GetFromJsonAsync<List<Demandas>>("api/Demandas");
        }

        public async Task<Demandas?> GetDemandas(int id)
        {
            return await httpClient
                .GetFromJsonAsync<Demandas>($"api/Demandas/{id}");
        }

    }
}
