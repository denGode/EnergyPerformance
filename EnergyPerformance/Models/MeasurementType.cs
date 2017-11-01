using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyPerformance.Models
{
    public class MeasurementType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UnitId { get; set; }

        public Unit Unit { get; set; }
    }
}
