using PruebaAPI_C.Entities;

namespace PruebaAPI_C.Entities
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Departamento Departamento { get; set; }

    }
}
