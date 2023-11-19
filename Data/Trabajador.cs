﻿using MongoDB.Bson;

namespace VacasCool.Data
{
    public class Trabajador
    {
        public ObjectId Id { get; set; }
        public string? Nombre { get; set; }
        public double? Edad { get; set; }
        public string? Sexo { get; set; }
        public string HistoriaEmpleo { get; set; }
        public double? Salario { get; set; }
        public string? Permisos { get; set; }
        public string? Certificaciones { get; set; }
        public string? idTrabajador { get; set; }
    }
}
