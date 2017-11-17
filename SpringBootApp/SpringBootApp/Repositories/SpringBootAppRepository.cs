using SpringBootApp.Entities;
using SpringBootApp.Models;
using System.Collections.Generic;
using System.Linq;

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
            return SpringBootAppContext.LicenePlates.Where(x => x.Plate.Contains(inputPlate)).ToList();
        }

        public List<LicencePlate> GetBrandList(string inputBrand)
        {
            return SpringBootAppContext.LicenePlates.Where(x => x.CarBrand.Equals(inputBrand)).ToList();
        }

        public List<LicencePlate> GetPoliceCars(string police)
        {
            return SpringBootAppContext.LicenePlates.Where(x => x.Plate.StartsWith("RB")).ToList();
        }

        public List<LicencePlate> GetDiplomatCars(string diplomat)
        {
            return SpringBootAppContext.LicenePlates.Where(x => x.Plate.StartsWith("DT")).ToList();
        }
    }
}