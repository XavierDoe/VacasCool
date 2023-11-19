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
