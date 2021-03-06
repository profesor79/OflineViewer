﻿using System;
using System.Collections.Generic;

namespace OflineViewer.Models
{
    public struct Ballot2
    {
        public int BallotId { get; set; }
        public string BallotVoteIndicatorCode { get; set; }
        public DateTime VoteDate { get; set; }
        public string ControlNumberKey { get; set; }
        public string BallotStatusCode { get; set; }
        public int AccountId { get; set; }
        public decimal NoOfShares { get; set; }
        public string ClassOfStockCode { get; set; }
        public int AgendaId { get; set; }
        public string InstitutionId { get; set; }
        public DateTime FileProcessingDate { get; set; }
        public string AppointeeName { get; set; }
        public string StatusCode { get; set; }
        public string Comments { get; set; }
        public string ProviderSecurityId { get; set; }
        public string ProviderIssuerCd { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime ValidatedDate { get; set; }
        public bool IsManuallyEntered { get; set; }
        public int BatchControlId { get; set; }
        public int SecuritySymbolId { get; set; }
        public string ProviderCustodianAccountNumber { get; set; }
        public string Provider { get; set; }
        public string DeliveredModeCode { get; set; }
        public string BatchMarker { get; set; }
        public string DeliveryNote { get; set; }
        public bool IsUngroupedBallot { get; set; }
        public string VoteStatusCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SettlementLocation { get; set; }
        public int CustodianSubAccountId { get; set; }
        public string EntryComments { get; set; }
        public bool IsAutoGenerated { get; set; }
        public bool IsAutoInstructed { get; set; }
        public int Createdby { get; set; }
        public bool IsCopiedForReporting { get; set; }
        public DateTime Cutoffdate { get; set; }
        public decimal BallotSharesOnLoan { get; set; }
        public DateTime SubCustodianCutOffDate { get; set; }
        public bool HasMeetingChangedToContested { get; set; }
        public int LatestBallotId { get; set; }
        public int LastApprovedBy { get; set; }
        public string RecommendationFlavorCode { get; set; }
        public DateTime InstructedDate { get; set; }
        public int LogicalBallotId { get; set; }
        public bool NonStandardVote { get; set; }
        public decimal AbsoluteAmount { get; set; }
        public decimal VotedAmount { get; set; }
        public decimal PartialVotePercentage { get; set; }
        public bool IsPartialVote { get; set; }
        public bool IsSplitVote { get; set; }
        public string BlockingIndicator { get; set; }
        public int InstructedBy { get; set; }
        public bool IsZeroSharesChange { get; set; }
        public Account AmAccount { get; set; }
        public LogicalBallot PxLogicalBallot { get; set; }
        public WorkflowNotesBallot PxWorkflowNotesBallot { get; set; }
        public ICollection<BallotAuditTrail> PxBallotAuditTrail { get; set; }
        public ICollection<BallotVotes> PxBallotVotes { get; set; }
        public ICollection<Shares> PxShares { get; set; }
    }

    public struct Ballot


    {
        public int BallotId { get; set; }
        public string BallotVoteIndicatorCode { get; set; }
        public DateTime VoteDate { get; set; }
        public string ControlNumberKey { get; set; }
        public string BallotStatusCode { get; set; }
        public int AccountId { get; set; }
        public decimal NoOfShares { get; set; }
        public string ClassOfStockCode { get; set; }
        public int AgendaId { get; set; }
        public string InstitutionId { get; set; }
        public DateTime FileProcessingDate { get; set; }
        public string AppointeeName { get; set; }
        public string StatusCode { get; set; }
        public string Comments { get; set; }
        public string ProviderSecurityId { get; set; }
        public string ProviderIssuerCd { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime ValidatedDate { get; set; }
        public bool IsManuallyEntered { get; set; }
        public int BatchControlId { get; set; }
        public int SecuritySymbolId { get; set; }
        public string ProviderCustodianAccountNumber { get; set; }
        public string Provider { get; set; }
        public string DeliveredModeCode { get; set; }
        public string BatchMarker { get; set; }
        public string DeliveryNote { get; set; }
        public bool IsUngroupedBallot { get; set; }
        public string VoteStatusCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string SettlementLocation { get; set; }
        public int CustodianSubAccountId { get; set; }
        public string EntryComments { get; set; }
        public bool IsAutoGenerated { get; set; }
        public bool IsAutoInstructed { get; set; }
        public int Createdby { get; set; }
        public bool IsCopiedForReporting { get; set; }
        public DateTime Cutoffdate { get; set; }
        public decimal BallotSharesOnLoan { get; set; }
        public DateTime SubCustodianCutOffDate { get; set; }
        public bool HasMeetingChangedToContested { get; set; }
        public int LatestBallotId { get; set; }
        public int LastApprovedBy { get; set; }
        public string RecommendationFlavorCode { get; set; }
        public DateTime InstructedDate { get; set; }
        public int LogicalBallotId { get; set; }
        public bool NonStandardVote { get; set; }
        public decimal AbsoluteAmount { get; set; }
        public decimal VotedAmount { get; set; }
        public decimal PartialVotePercentage { get; set; }
        public bool IsPartialVote { get; set; }
        public bool IsSplitVote { get; set; }
        public string BlockingIndicator { get; set; }
        public int InstructedBy { get; set; }
        public bool IsZeroSharesChange { get; set; }
        public Account AmAccount { get; set; }
        public LogicalBallot PxLogicalBallot { get; set; }
        public WorkflowNotesBallot PxWorkflowNotesBallot { get; set; }
        public ICollection<BallotAuditTrail> PxBallotAuditTrail { get; set; }
        public ICollection<BallotVotes> PxBallotVotes { get; set; }
        public ICollection<Shares> PxShares { get; set; }
    }
}