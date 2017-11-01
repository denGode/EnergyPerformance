using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EnergyPerformance.Models;

namespace EnergyPerformance.Pages.Units
{
    public class DeleteModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public DeleteModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Unit Unit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Unit = await _context.Unit.SingleOrDefaultAsync(m => m.Id == id);

            if (Unit == null)
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

            Unit = await _context.Unit.FindAsync(id);

            if (Unit != null)
            {
                _context.Unit.Remove(Unit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
