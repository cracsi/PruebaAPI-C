using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaAPI_C.DB;
using PruebaAPI_C.Entities;

namespace PruebaAPI_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public JsonResult CreateEdit(Usuario usuario, int PaisId, int DepartamentoId, int MunicipioId)
        {
            var pais = _context.Paises.Find(PaisId);
            var dep = _context.Departamentos.Find(DepartamentoId);
            var muni = _context.Municipios.Find(MunicipioId);

            if (pais == null || dep == null || muni== null) { 
                return new JsonResult(NotFound());
            }
            usuario.Pais = pais;
            usuario.Departamento = dep;
            usuario.Municipio = muni;
            _context.Usuarios.Add(usuario);   
            _context.SaveChanges();
            return new JsonResult(Ok(usuario));
        }

        [HttpGet]
        public JsonResult Get()
        {
            _context.Database.ExecuteSqlRaw("CALL getPaises()");

            return new JsonResult(Ok(_context.Paises.ToList()));
        }

    }
}
