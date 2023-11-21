namespace VacasCool.Data
{
    public class TrabajadorService
    {
        private readonly HttpClient _httpClient;

        private Trabajador _trabajador;

        public TrabajadorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Trabajador>> ObtenerElementos(string url)
        {
            return await _httpClient.GetFromJsonAsync<List<Trabajador>>(url);
        }

        public async Task<int> GuardarDatos(Trabajador trabajador)
        {
            // Realizar una solicitud POST a la API para guardar los datos
            string url = "https://vacas20231113212142.azurewebsites.net/Trabajadores";
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync(url, trabajador);

            if (response.IsSuccessStatusCode)
            {
                return 200;
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> ActualizarDatos(string id, Trabajador trabajador)
        {
            // Realizar una solicitud POST a la API para guardar los datos
            string url = $"https://vacas20231113212142.azurewebsites.net/Trabajadores/{id}";
            HttpResponseMessage response = await _httpClient.PutAsJsonAsync(url, trabajador);

            if (response.IsSuccessStatusCode)
            {
                return 200;
            }
            else
            {
                return 0;
            }
        }

        public void SetTrabajador (Trabajador trabajador)
        {
            _trabajador = trabajador;
        }

        public Trabajador getTrabajador()
        {
            return _trabajador;
        }
    }
}
