using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mitovia.data;

namespace Mitovia.Controllers
{
    public class ValueDialController : Controller
    {
        private readonly MitoviaDbContext dbContext;
        public ValueDialController(MitoviaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var valueDials = await dbContext.ValueDial.ToListAsync();
            return View(valueDials);
        }
    }
}
