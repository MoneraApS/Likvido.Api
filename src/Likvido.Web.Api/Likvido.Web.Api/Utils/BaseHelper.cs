using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Likvido.Web.Api.Model.Company;
using Newtonsoft.Json;

namespace Likvido.Web.Api.Utils
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="U">The object we expect to convert to</typeparam>
    public class BaseHelper<U>
    {
        /// <summary>
        /// Downloads and parses the object based on the URL
        /// </summary>
        /// <typeparam name="T">The DTO from the third party </typeparam>
        /// <param name="url">The URL to retrive stuff from</param>
        /// <returns></returns>
        public static List<U> DownloadAndParseList<T>(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Cannot download and parse from empty URL");
            }

            using (var client = new WebClient())
            {
                var data = client.DownloadString(url);
                var dtos = JsonConvert.DeserializeObject<List<T>>(data);
                
                List<U> companies = new List<U>();
                foreach (var companyDto in dtos)
                {
                    var company = (U)Activator.CreateInstance(typeof(U), companyDto);
                    if (company != null)
                    {
                        companies.Add(company);
                    }
                }

                return companies;
            }
        }

        public static U DownloadAndParse<T>(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("Cannot download and parse from empty URL");
            }

            using (var client = new WebClient())
            {
                var data = client.DownloadString(url);
                var dtos = JsonConvert.DeserializeObject<T>(data);

                var company = (U)Activator.CreateInstance(typeof(U), dtos);
                return company;
            }
        }
    }
}
