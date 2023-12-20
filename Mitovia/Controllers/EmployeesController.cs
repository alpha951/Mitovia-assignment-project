using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mitovia.data;
using Mitovia.Models;

namespace Mitovia1.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MitoviaDbContext dbContext;

        public EmployeesController(MitoviaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var employees = await dbContext.Employees.ToListAsync();
            return View(employees);
        }

    }
}
