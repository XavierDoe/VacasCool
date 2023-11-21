namespace VacasCool.Data
{
    public class VacaService
    {
        private readonly HttpClient _httpClient;

        private Vaca _vaca;

        public VacaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Vaca>> ObtenerElementos(string url)
        {
            return await _httpClient.GetFromJsonAsync<List<Vaca>>(url);
        }

        public async Task<int> GuardarDatos(Vaca vaca)
        {
            // Realizar una solicitud POST a la API para guardar los datos
            string url = "https://vacas20231113212142.azurewebsites.net/Inventario";
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, vaca);

            if (response.IsSuccessStatusCode)
            {
                return 200;
            }
            else
            {
                return 0;
            }
        }

        public void SetVaca(Vaca vaca)
        {
            _vaca  = vaca;
        }
        public Vaca GetVaca()
        {
            return _vaca;
        }
    }
}
