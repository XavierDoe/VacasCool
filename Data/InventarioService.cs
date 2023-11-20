namespace VacasCool.Data
{
    public class InventarioService
    {
        private readonly HttpClient _httpClient;

        private Inventario _inventario;

        public InventarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Inventario>> ObtenerElementos(string url)
        {
            return await _httpClient.GetFromJsonAsync<List<Inventario>>(url);
        }

        public void SetInventario(Inventario inventario)
        {
            _inventario = inventario;
        }
        public Inventario GetInventario()
        {
            return _inventario;
        }
    }
}
