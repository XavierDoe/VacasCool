namespace VacasCool.Data
{
    public class InventarioService
    {
        private readonly HttpClient _httpClient;

        public InventarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Inventario>> ObtenerElementos(string url)
        {
            return await _httpClient.GetFromJsonAsync<List<Inventario>>(url);
        }
    }
}
