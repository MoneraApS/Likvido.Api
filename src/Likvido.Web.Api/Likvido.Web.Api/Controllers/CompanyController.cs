using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Likvido.Web.Api.Model.Company;
using Likvido.Web.Api.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Likvido.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {

        public CompanyController()
        {
            
        }

        // GET api/company
        [HttpGet]
        public IEnumerable<Company> Get(string query)
        {
            var url = Constants.MicroservicePath.CompanyEndpoint;

            using (var client = new WebClient())
            {
                var data = client.DownloadString(url + "?query=" + query);
                var dtos = JsonConvert.DeserializeObject<List<CompanyDTO>>(data);

                List<Company> companies = new List<Company>();
                foreach (var companyDto in dtos)
                {
                    companies.Add(new Company()
                    {
                        Address = companyDto.Address,
                        City = companyDto.City,
                        CompanyRegistrationId = companyDto.VAT,
                        Name = companyDto.OfficialName,
                        Zipcode = companyDto.Zipcode
                    });
                }

                return companies;
            }
        }

    }
}