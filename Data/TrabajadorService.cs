namespace VacasCool.Data
{
    public class TrabajadorService
    {
        private readonly HttpClient _httpClient;

        public TrabajadorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Trabajador>> ObtenerElementos(string url)
        {
            return await _httpClient.GetFromJsonAsync<List<Trabajador>>(url);
        }
    }
}
