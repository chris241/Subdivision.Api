using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Subdivision.Api.Models;
using Subdivision.Api.Repositories;
using Subdivision.Api.Repositories.Interfaces;

namespace Subdivision.Api.Controllers._1._0.Countries
{
    public class SubdivisionController : ApiBaseController
    {
        private IUnitOfWork Unit;
        public SubdivisionController(IUnitOfWork unit)
        {
            Unit = unit;
        }
        [HttpGet]
        public Country GetCountryId(long number)
        {
            return Unit.CountryRepository.GetById(x => x.Number == number);
        }
        [HttpPost]
        public void AddCountry([FromBody]Country country)
        {
             Unit.CountryRepository.Add(country);
        }
        [HttpGet]
        public Region GetListByRegion()
        {
            return new Region();
        }
        [HttpGet]
        public District GetListByDistrict()
        {
            return new District();
        }
        [HttpGet]
        public Municipality GetListByMunicipality()
        {
            return new Municipality();
        }
        [HttpGet]
        public Village GetListByVillage()
        {
            return new Village();
        }
    }
}
