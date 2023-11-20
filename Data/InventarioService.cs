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

        public async Task<int> GuardarDatos(Inventario inventario)
        {
            // Realizar una solicitud POST a la API para guardar los datos
            string url = "https://vacas20231113212142.azurewebsites.net/Inventario";
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, inventario);

            if (response.IsSuccessStatusCode)
            {
                return 200;
            }
            else
            {
                return 0;
            }
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
