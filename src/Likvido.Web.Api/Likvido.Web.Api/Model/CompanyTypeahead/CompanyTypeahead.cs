using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likvido.Web.Api.Model.CompanyTypeahead
{
    public class CompanyTypeahead
    {
        public string Label { get; set; }
        public string RegistrationName { get; set; }

        public CompanyTypeahead(CompanyTypeaheadDTO dto)
        {
            Label = dto.Label;
            RegistrationName = dto.RegistrationName;
        }
    }
}
