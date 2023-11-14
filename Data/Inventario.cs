﻿using MongoDB.Bson;

namespace VacasCool.Data
{
    public class Inventario
    {
        public ObjectId Id { get; set; }
        public String? NombreArticulo { get; set; }
        public int? Cantidad { get; set; }
        public string IdInventario => IdVac(Id);
        public String IdVac(ObjectId id)
        {
            return id.ToString();
        }
    }
}
