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
    public class IndexModel : PageModel
    {
        private readonly EnergyPerformance.Models.EnergyPerformanceDbContext _context;

        public IndexModel(EnergyPerformance.Models.EnergyPerformanceDbContext context)
        {
            _context = context;
        }

        public IList<MeasurementPoint> MeasurementPoint { get;set; }

        public async Task OnGetAsync()
        {
            MeasurementPoint = await _context.MeasurementPoint.ToListAsync();
        }
    }
}
