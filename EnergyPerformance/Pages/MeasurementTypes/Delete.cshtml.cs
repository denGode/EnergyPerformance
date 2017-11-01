using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnergyPerformance.Models;

namespace EnergyPerformance.Pages.MeasurementTypes
{
    public class DeleteModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public DeleteModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MeasurementType MeasurementType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasurementType = await _context.MeasurementType
                .Include(m => m.Unit).SingleOrDefaultAsync(m => m.Id == id);

            if (MeasurementType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasurementType = await _context.MeasurementType.FindAsync(id);

            if (MeasurementType != null)
            {
                _context.MeasurementType.Remove(MeasurementType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
