using Microsoft.EntityFrameworkCore;
using PallidaOrientationExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExam.Entities
{
    public class PlateContext : DbContext
    {
        public PlateContext(DbContextOptions<PlateContext> options) : base(options) { }

        public DbSet<Plates> LicensePlates { get; set; }
    }
}
