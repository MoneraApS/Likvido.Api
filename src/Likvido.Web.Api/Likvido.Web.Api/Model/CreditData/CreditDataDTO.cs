using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Likvido.Web.Api.Model.Company;

namespace Likvido.Web.Api.Model.CreditData
{
    public class CreditDataDTO
    {

            public string Recommendation { get; set; }
            public string Description { get; set; }
            public CompanyDTO CompanyData { get; set; }
            public Rating RatingData { get; set; }
    }


    public class Rating
    {
        public int SummaryRating { get; set; }
        public RatingEntity Equity { get; set; }
        public RatingEntity Result { get; set; }

        public RatingEntity Age { get; set; }
        public RatingEntity Employees { get; set; }
        public RatingEntity Type { get; set; }
        public RatingEntity Situation { get; set; }

        public bool Stopped { get; set; }

    }

    public class RatingEntity
    {
        public string Explaination { get; set; }
        public decimal? Value { get; set; }
        public string DataPoint { get; set; }
        public string Impact { get; set; }
        public bool Include { get; set; }

        public RatingEntity()
        {
            this.Include = true;
        }

    }
}
