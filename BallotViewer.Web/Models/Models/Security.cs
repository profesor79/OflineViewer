using System;
using System.Collections.Generic;

namespace BallotViewer.Web.Models.Models
{
    public struct Security
    {
        public int SecurityId { get; set; }
        public string IssuerName { get; set; }
        public string IssueData { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool DeletedFlag { get; set; }
        public bool? MergedIndicator { get; set; }
        public int? MergedWithIssuerId { get; set; }
        public bool? GlCoverageUniverseIndicator { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int FactVersion { get; set; }
        public bool IsInCoverageUniverse { get; set; }
        public int? RpOrgId { get; set; }
        public string CountryOfOrigin { get; set; }
        public string OldIssuerName { get; set; }
        public bool? IsUpdated { get; set; }
        public double? Shares { get; set; }
        public string ComType { get; set; }
        public long? OutstandingShares { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? EdiIssId { get; set; }
        public bool? EdiIssuerNameOverride { get; set; }
        public ICollection<SecuritySymbol> AaSecuritySymbol { get; set; }
        public ICollection<WatchListSecurity> PxWatchListSecurity { get; set; }
    }
}