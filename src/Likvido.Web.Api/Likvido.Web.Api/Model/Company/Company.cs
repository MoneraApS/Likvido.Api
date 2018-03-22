using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likvido.Web.Api.Model.Company
{
    public class Company
    {
        public string Name { get; set; }
        public string CompanyRegistrationId { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }

        public Company(CompanyDTO companyDto)
        {
            Address = companyDto.Address;
            City = companyDto.City;
            CompanyRegistrationId = companyDto.VAT;
            Name = companyDto.OfficialName;
            Zipcode = companyDto.Zipcode;
        }
    }
}
