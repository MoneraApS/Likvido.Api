using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Likvido.Web.Api.Model.CompanyTypeahead;
using Likvido.Web.Api.Utils;
using Microsoft.AspNetCore.Mvc;


namespace Likvido.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class CompanyTypeaheadController : Controller
    {
        // GET api/company
        [HttpGet]
        public IEnumerable<CompanyTypeahead> Get(string query)
        {
            var url = Constants.MicroservicePath.CompanyTypeaheadEndpoint;
            var path = url + "?query=" + query;
            return BaseHelper<CompanyTypeahead>.DownloadAndParseList<CompanyTypeaheadDTO>(path);
        }
    }
}