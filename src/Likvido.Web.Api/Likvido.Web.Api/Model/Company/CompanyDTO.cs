using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likvido.Web.Api.Model.Company
{
    public class CompanyDTO
    {
        public bool AnnualReportAvailable { get; set; }
        public string VAT { get; set; }
        public string OfficialName { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone{ get; set; }


        public string[] ContactInformation { get; set; }

        public string Startdate { get; set; }
        public string Enddate { get; set; }
        public string Employees { get; set; }
        public CompanyType Type { get; set; }
        public int IndustryCode { get; set; }
        public string IndustryCodeDescription { get; set; }
        public int? IndustrySecondaryCode { get; set; }
        public string IndustryCodeSecondaryDescription { get; set; }

        public string CompanySituation { get; set; }
        public string CompanyTypeDescription { get; set; }

        public string Creditstartdate { get; set; }
        public int? Creditstatus { get; set; }
        public bool CreditBankrupt { get; set; }
        public bool CompanyStopped { get; set; }
        public bool CompanyDissolved { get; set; }

        public int Version { get; set; }

        public string EmployeesDescription { get; set; }

        public decimal? GrossProfitLoss { get; set; }
        public decimal? ProfitLoss { get; set; }
        public decimal? CurrentAssets { get; set; }
        public decimal? Assets { get; set; }
        public decimal? Equity { get; set; }
    }
}
