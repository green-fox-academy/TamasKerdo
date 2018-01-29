using PallidaOrientationExam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PallidaOrientationExam.Models;

namespace PallidaOrientationExam.Repositories
{
    public class Repository
    {
        public PlateContext Context { get; set; }

        public Repository(PlateContext Context)
        {
            this.Context = Context;
        }

        internal List<Plates> SearchPolice()
        {
            var List = Context.LicensePlates.Where(p=>p.Plate.StartsWith("RB")).ToList();
            return List;
        }

        internal List<Plates> SearchDiplomat()
        {
            var List = Context.LicensePlates.Where(p => p.Plate.StartsWith("DT")).ToList();
            return List;
        }

        internal List<Plates> SearchPlate(string plate)
        {
            var List = Context.LicensePlates.Where(p=>p.Plate.Contains(plate)).ToList();
            return List;
        }

        internal List<Plates> SearchBrand(string brand)
        {
            var List = Context.LicensePlates.Where(p => p.CarBrand.Equals(brand)).ToList();
            return List;
        }

        internal List<Plates> ListAll()
        {
            var List = Context.LicensePlates.ToList();
            return List;
        }
    }
}
