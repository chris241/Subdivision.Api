using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Subdivision.Api.Models;

namespace Subdivision.Api.Controllers._1._0.Countries
{
    public class SubdivisionController : ApiBaseController
    {
        [HttpGet]
        public Country GetListByCountry()
        {

            return new Country();
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
