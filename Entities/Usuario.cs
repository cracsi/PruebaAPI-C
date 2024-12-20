﻿using PruebaAPI_C.Entities;

namespace PruebaAPI_C.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public Pais Pais { get; set; }
        public Departamento Departamento { get; set; }
        public Municipio Municipio { get; set; }
    }
}