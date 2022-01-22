using backend_tareas.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace backend_tareas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : Controller
    {
        private readonly AplicationDbContext _context;

        public TareaController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listTareas = await _context.Tareas.ToListAsync();
                return Ok(listTareas);
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
