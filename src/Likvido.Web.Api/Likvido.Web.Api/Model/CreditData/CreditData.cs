using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Likvido.Web.Api.Model.CreditData
{
    public class CreditData
    {
        public string Name { get; set; }
        public string CompanyRegistrationId { get; set; }
        public int SummaryRating { get; set; }
        public string CreditRecommendation { get; set; }

        public CreditData(CreditDataDTO dto)
        {
            this.Name = dto.CompanyData.OfficialName;
            this.CompanyRegistrationId = dto.CompanyData.VAT;
            this.CreditRecommendation = dto.Recommendation;
            this.SummaryRating = dto.RatingData.SummaryRating;
        }
    }
}
