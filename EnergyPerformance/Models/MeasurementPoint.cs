using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyPerformance.Models
{
    public class MeasurementPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalKey { get; set; }
    }
}
