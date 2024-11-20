
using PruebaAPI_C.Entities;
namespace PruebaAPI_C.Entities
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Pais Pais { get; set; }
    }
}
