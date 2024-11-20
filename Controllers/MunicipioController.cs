using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaAPI_C.DB;

namespace PruebaAPI_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly AppDbContext _context;
        public MunicipioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(Ok(_context.Municipios.ToList()));
        }

    }
}
