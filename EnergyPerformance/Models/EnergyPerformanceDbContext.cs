using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyPerformance.Models
{
    public class EnergyPerformanceDbContext:DbContext
    {
        public EnergyPerformanceDbContext(DbContextOptions<EnergyPerformanceDbContext> options):base(options)
        {

        }

        public DbSet<Unit> Unit { get; set; }
        public DbSet<MeasurementPoint> MeasurementPoint { get; set; }
        public DbSet<MeasurementType> MeasurementType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeasurementType>()
                .HasOne(m => m.Unit)
                .WithMany(u => u.MeasurementTypeList)
                .HasForeignKey(m => m.UnitId);
        }
    }
}
