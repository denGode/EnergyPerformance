using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EnergyPerformance.Models;

namespace EnergyPerformance.Pages.MeasurementTypes
{
    public class CreateModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public CreateModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["UnitId"] = new SelectList(_context.Unit.OrderBy(itm => itm.Name), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public MeasurementType MeasurementType { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.MeasurementType.Add(MeasurementType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}