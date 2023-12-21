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

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Add(AddMeasure model)
        {
            var existingMeasure = await dbContext.Measure.FirstOrDefaultAsync(x => x.Name == model.Name);
            if(existingMeasure != null)
            {
                ModelState.AddModelError("Name", "Measure with this name already exists");
            }
            var measure = new Measure
            {
                Name = model.Name,
                DisplayName = model.DisplayName ?? model.Name,
                Description = model.Description ?? "No Description Present",
                ValueDialID = model.ValueDialID
            };

            dbContext.Measure.Add(measure);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Add");   
        }

        [HttpGet]

        public async Task<IActionResult> View(int id)
        {
            var measure = await dbContext.Measure.FirstOrDefaultAsync(x => x.ID == id);

            var viewModel = new UpdateMeasure()
            {
                ID = measure.ID,
                Name = measure.Name,
                DisplayName = measure.DisplayName,
                Description = measure.Description,
                ValueDialID = measure.ValueDialID,
            };

            return View("View", viewModel);
        }

        [HttpPost]

        public async Task<IActionResult> Update(UpdateMeasure model)
        {
            var measure = await dbContext.Measure.FirstOrDefaultAsync(x => x.ID == model.ID);
            if (measure == null)
            {
                return RedirectToAction("Index");
            }
            measure.Name = model.Name;
            measure.DisplayName = model.DisplayName;
            measure.Description = model.Description;
            measure.ValueDialID = model.ValueDialID;

            // Save changes to the database
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]

        public async Task<IActionResult> Delete(UpdateMeasure model)
        {
            var measure = await dbContext.Measure.FirstOrDefaultAsync(x => x.ID == model.ID);
            if (measure == null)
            {
                return RedirectToAction("Index");
            }
            dbContext.Measure.Remove(measure);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
