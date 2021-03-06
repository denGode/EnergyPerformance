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
    public class IndexModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public IndexModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        public IList<Unit> Unit { get;set; }

        public async Task OnGetAsync()
        {
            Unit = await _context.Unit.ToListAsync();
        }
    }
}
