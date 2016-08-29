using System;
using System.Collections.Generic;

namespace ModelConverter.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public string JobNumber { get; set; }
        public int SecurityId { get; set; }
        public string ProviderSecurityId { get; set; }
        public string ProviderIssueTypeCd { get; set; }
        public DateTime? RecordDate { get; set; }
        public string MeetingTypeCode { get; set; }
        public bool? IsContested { get; set; }
        public DateTime? HoldReconciliationDate { get; set; }
        public bool? IsAllowSplitVote { get; set; }
        public bool? IsAllowPartialVote { get; set; }
        public bool? IsBlockingMarket { get; set; }
        public DateTime? MeetingDate { get; set; }
        public string MeetingCityCode { get; set; }
        public DateTime? VoteDeadlineDate { get; set; }
        public string MeetingStatusCode { get; set; }
        public string MeetingStatusReasonCode { get; set; }
        public string MeetingClassificationLevelCode { get; set; }
        public bool? IsRecordDateMarket { get; set; }
        public string CommonCode { get; set; }
        public string QuickCode { get; set; }
        public string ParValue { get; set; }
        public DateTime? FileProcessingDate { get; set; }
        public int? DataProviderId { get; set; }
        public int? BatchControlId { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool? IsManuallyEntered { get; set; }
        public int? ProviderSecuritySymbolId { get; set; }
        public bool? IsCopy { get; set; }
        public int? MeetingGroupId { get; set; }
        public string MeetingReconciliationTypeCode { get; set; }
        public bool? IsCopiedForReporting { get; set; }
        public string OriginalJobNumber { get; set; }
        public DateTime? SharesDependentChangeDate { get; set; }
        public Security AaSecurity { get; set; }
        public ICollection<Agenda> PxAgenda { get; set; }
    }
}