using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mitovia.data;
using Mitovia.Models;
using System.Linq;
using System.Threading.Tasks;

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
            var measuresWithDialNames = await dbContext.Measure
                .Select(m => new MeasureView
                {
                    ID = m.ID,
                    Name = m.Name,
                    DisplayName = m.DisplayName ?? m.Name,
                    Description = m.Description ?? "No Description Present",
                    LastUpdatedDate = m.LastUpdatedDate,
                    ValueDialID = m.ValueDialID,
                    // Include other properties as needed
                    ValueDialName = dbContext.ValueDial.Where(v => v.ID == m.ValueDialID).Select(v => v.Name).FirstOrDefault()
                })
                .ToListAsync();

            foreach (var measure in measuresWithDialNames)
            {
                measure.LastUpdatedDateString = measure.LastUpdatedDate.HasValue
                    ? measure.LastUpdatedDate.Value.ToString("dd MMM yyyy")
                    : string.Empty;
            }

            return View(measuresWithDialNames);
        }
    }
}
