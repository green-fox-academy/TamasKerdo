using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PallidaOrientationExam.Repositories;
using PallidaOrientationExam.Models;

namespace PallidaOrientationExam.Services
{
    public class PlateService
    {
        public Repository Repository { get; set; }

        public PlateService(Repository Repository)
        {
            this.Repository = Repository;
        }

        public List<Plates> Search(string q, int police, int diplomat)
        {
            if (police == 1)
            {
                return Repository.SearchPolice();
            }
            else if (diplomat == 1)
            {
                return Repository.SearchDiplomat();
            }
            return Repository.SearchPlate(q);
        }

        public List<Plates> SearchBrand(string brand)
        {
            return Repository.SearchBrand(brand);
        }

        public List<Plates> ListAll()
        {
            return Repository.ListAll();
        }
    }
}
