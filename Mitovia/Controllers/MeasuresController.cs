using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mitovia.data;
using Mitovia.Models;

namespace Mitovia.Controllers
{
    public class MeasuresController : Controller
    {
        private readonly MitoviaDbContext dbContext;
        public MeasuresController(MitoviaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var measures = await dbContext.Measure.ToListAsync();
            return View(measures);
        }
    }
}
