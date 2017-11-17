using SpringBootApp.Models;
using SpringBootApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpringBootApp.Services
{
    public class SpringBootAppService
    {
        SpringBootAppRepository SpringBootAppRepository;

        public SpringBootAppService(SpringBootAppRepository springBootAppRepository)
        {
            SpringBootAppRepository = springBootAppRepository;
        }

        public List<LicencePlate> GetLicencePlateListForUser(string inputPlate)
        {
            return SpringBootAppRepository.GetPlateList(inputPlate);
        }

        public List<LicencePlate> GetBrandListForUser(string inputBrand)
        {
            return SpringBootAppRepository.GetBrandList(inputBrand);
        }

        public List<LicencePlate> GetPoliceCarsForUser(string inputPlate)
        {
            return SpringBootAppRepository.GetPoliceCars(inputPlate);
        }

        public List<LicencePlate> GetDiplomatCarsForUser(string inputPlate)
        {
            return SpringBootAppRepository.GetDiplomatCars(inputPlate);
        }
    }
}
