using MongoDB.Bson;
using Newtonsoft.Json;
using System.Net;

namespace VacasCool.Data
{
    public class VacaService
    {
        private readonly HttpClient _httpClient;

        public VacaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Vaca>> ObtenerElementos(string url)
        {
            return await _httpClient.GetFromJsonAsync<List<Vaca>>(url);
        }
    }
}
