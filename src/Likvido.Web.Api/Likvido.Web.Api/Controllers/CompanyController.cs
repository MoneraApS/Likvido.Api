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
            var path = url + "?query=" + query;
            return BaseHelper<Company>.DownloadAndParseList<CompanyDTO>(path);
        }

    }
}