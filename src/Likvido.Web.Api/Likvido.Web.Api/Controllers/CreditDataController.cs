using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Likvido.Web.Api.Model.CreditData;
using Likvido.Web.Api.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Likvido.Web.Api.Controllers
{
    [Route("api/[controller]")]
    public class CreditDataController : Controller
    {
        // GET api/company
        [HttpGet("{query}", Name = "Get")]
        public CreditData Get(string query)
        {
            var url = Constants.MicroservicePath.CreditDataEndpoint;
            var path = url + "/" + query;
            return BaseHelper<CreditData>.DownloadAndParse<CreditDataDTO>(path);
        }
    }
}