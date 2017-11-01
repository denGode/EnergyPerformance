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
    public class IndexModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public IndexModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        public IList<MeasurementType> MeasurementType { get;set; }

        public async Task OnGetAsync()
        {
            MeasurementType = await _context.MeasurementType
                .Include(m => m.Unit).OrderBy(itm => itm.Name).ToListAsync();
        }
    }
}
