using System;
using System.Collections.Generic;

namespace BallotViewer.Web.Models.Models
{
    public struct Agenda
    {
        public int AgendaId { get; set; }
        public int MeetingId { get; set; }
        public string AgendaKey { get; set; }
        public DateTime FileProcessingDate { get; set; }
        public string CommitteeCode { get; set; }
        public string StatusCode { get; set; }
        public int BatchControlId { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool IsManuallyEntered { get; set; }
        public int AgendaVersion { get; set; }
        public int RpReportId { get; set; }
        public DateTime RpPublishDate { get; set; }
        public int FactVersion { get; set; }
        public double FactServicePercentage { get; set; }
        public string OriginalAgendaKey { get; set; }
        public bool IsCumulativeVoting { get; set; }
        public ICollection<AgendaItem> PxAgendaItem { get; set; }
        public ICollection<Ballot> PxBallot { get; set; }
    }
}