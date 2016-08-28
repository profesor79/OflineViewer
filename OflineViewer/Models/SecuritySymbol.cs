using System;

namespace OflineViewer.Models
{
    public struct SecuritySymbol
    {
        public int SecuritySymbolId { get; set; }
        public int SecurityId { get; set; }
        public string SymbolTypeCode { get; set; }
        public string SymbolNumber { get; set; }
        public string SecurityClassCode { get; set; }
        public string CountryCode { get; set; }
        public string Ticker { get; set; }
        public bool? IsPrimary { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool DeletedFlag { get; set; }
        public string Exchange { get; set; }
        public string Register { get; set; }
        public string Market { get; set; }
        public string Currency { get; set; }
        public DateTime? ValidFromDate { get; set; }
        public DateTime? ValidToDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? EdiIssId { get; set; }
        public long? EdiSecId { get; set; }
        public long? EdiSedolId { get; set; }
        public string SecurityDescription { get; set; }
        public long? SharesOutstanding { get; set; }
        public bool? SecuritySymbolMerged { get; set; }
        public int? MergedSymbolId { get; set; }
    }
}