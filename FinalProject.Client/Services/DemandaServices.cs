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

        public async Task<Demandas?> GetDemanda(int id)
        {
            return await httpClient
                .GetFromJsonAsync<Demandas>($"api/Demandas/{id}");
        }
        //public async Task<int?> GetIdDemanda(int id)
        //{
        //    var demanda =await httpClient
        //        .GetFromJsonAsync<Demandas>($"api/Demandas/{id}");
        //    return demanda!.DemandaId;
        //}
    }
}
