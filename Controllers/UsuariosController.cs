using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAPI_C.DB;
using PruebaAPI_C.Entitites;

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
        public JsonResult CreateEdit(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);   
            _context.SaveChanges();
            return new JsonResult(Ok(usuario));
        }
    }
}
