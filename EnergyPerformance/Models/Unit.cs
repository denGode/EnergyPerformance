﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyPerformance.Models
{
    public class Unit
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Abbreviation { get; set; }

        public List<MeasurementType> MeasurementTypeList { get; set; }
    }
}
