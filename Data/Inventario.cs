using MongoDB.Bson;

namespace VacasCool.Data
{
    public class Inventario
    {
        public ObjectId Id { get; set; }
        public String? NombreArticulo { get; set; }
        public int? Cantidad { get; set; }
        public string IdInventario {  get; set; }
        public String? tipoArticulo { get; set; }
        public String descripcion { get; set; }
        public double? precio { get; set; }
    }
}
