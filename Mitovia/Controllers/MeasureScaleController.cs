using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mitovia.data;

namespace Mitovia.Controllers
{
    public class MeasureScaleController : Controller
    {
        private readonly MitoviaDbContext dbContext;
        public MeasureScaleController(MitoviaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var measureScales = await dbContext.MeasureScale.ToListAsync();
            return View(measureScales);
        }
    }
}
