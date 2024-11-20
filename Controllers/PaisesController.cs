using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaAPI_C.DB;

namespace PruebaAPI_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PaisesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(Ok(_context.Paises.ToList()));
        }

    }
}
