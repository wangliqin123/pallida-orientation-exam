using SpringBootApp.Models;
using SpringBootApp.Repositories;
using System.Collections.Generic;

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

        public List<LicencePlate> GetPoliceCarsForUser(string police)
        {
            return SpringBootAppRepository.GetPoliceCars(police);
        }

        public List<LicencePlate> GetDiplomatCarsForUser(string diplomat)
        {
            return SpringBootAppRepository.GetDiplomatCars(diplomat);
        }
    }
}