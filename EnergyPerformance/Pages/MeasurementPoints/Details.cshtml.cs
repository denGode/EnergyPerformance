using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnergyPerformance.Models;

namespace EnergyPerformance.Pages.MeasurementPoints
{
    public class DetailsModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public DetailsModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        public MeasurementPoint MeasurementPoint { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasurementPoint = await _context.MeasurementPoint.SingleOrDefaultAsync(m => m.Id == id);

            if (MeasurementPoint == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
