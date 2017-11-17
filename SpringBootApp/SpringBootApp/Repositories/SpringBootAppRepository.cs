using SpringBootApp.Entities;
using SpringBootApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpringBootApp.Repositories
{
    public class SpringBootAppRepository
    {
        SpringBootAppContext SpringBootAppContext;

        public SpringBootAppRepository(SpringBootAppContext springBootAppContext)
        {
            SpringBootAppContext = springBootAppContext;
        }

        public List<LicencePlate> GetPlateList(string inputPlate)
        {
            return SpringBootAppContext.LicenePlates.Where(x => x.Plate.Equals(inputPlate)).ToList();
        }
    }
}
