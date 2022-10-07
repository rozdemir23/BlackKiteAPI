using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class IsScanStatus
    {
        public Nullable<int> CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string DomainName { get; set; }
        public CyberRatings CyberRating { get; set; }
        public Compliance Compliance { get; set; }
        public FinancialImpact FinancialImpact { get; set; }
        public string DashboardLink { get; set; }
        public List<Ecosystem> Ecosystems { get; set; }
        public Industry Industry { get; set; }
        public string Country { get; set; }
        public object Tags { get; set; }
        public string ScanStatus { get; set; }
        public string Type { get; set; }
    }

    public class Compliance
    {
        public Nullable<int> Rating { get; set; }
        public Nullable<double> Confidence { get; set; }
        public Nullable<double> Completeness { get; set; }
        public Nullable<DateTime> LastUpdatedAt { get; set; }
    }

    public class CyberRatings
    {
        public string GradeLetter { get; set; }
        public Nullable<int> CyberRating { get; set; }
        public Nullable<double> BreachIndex { get; set; }
        public Nullable<double> RansomwareIndex { get; set; }
        public Nullable<DateTime> CyberRatingLastUpdatedAt { get; set; }
        public Nullable<DateTime> BreachIndexLastUpdatedAt { get; set; }
        public Nullable<DateTime> RansomwareIndexLastUpdatedAt { get; set; }
    }

    public class Ecosystem
    {
        public Nullable<int> EcosystemId { get; set; }
        public string EcosystemName { get; set; }
    }

    public class FinancialImpact
    {
        public Nullable<double> Rating { get; set; }
        public Nullable<double> RatingMin { get; set; }
        public Nullable<double> RatingMax { get; set; }
        public Nullable<double> LossMagnitude { get; set; }
        public Nullable<double> LossEventFrequency { get; set; }
        public Nullable<DateTime> LastUpdatedAt { get; set; }
    }

    public class Industry
    {
        public Nullable<int> IndustryId { get; set; }
        public string IndustryName { get; set; }
    }



}
