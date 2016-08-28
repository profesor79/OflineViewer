﻿using System;
using System.Collections.Generic;

namespace OflineViewer.Models
{
    public interface IBallot
    {
        decimal AbsoluteAmount { get; set; }
        int AccountId { get; set; }
        int AgendaId { get; set; }
        Account AmAccount { get; set; }
        string AppointeeName { get; set; }
        int BallotId { get; set; }
        decimal BallotSharesOnLoan { get; set; }
        string BallotStatusCode { get; set; }
        string BallotVoteIndicatorCode { get; set; }
        int BatchControlId { get; set; }
        string BatchMarker { get; set; }
        string BlockingIndicator { get; set; }
        string ClassOfStockCode { get; set; }
        string Comments { get; set; }
        byte[] ConcurrencyTmstp { get; set; }
        string ControlNumberKey { get; set; }
        int Createdby { get; set; }
        DateTime CreatedDate { get; set; }
        int CustodianSubAccountId { get; set; }
        DateTime Cutoffdate { get; set; }
        string DeliveredModeCode { get; set; }
        string DeliveryNote { get; set; }
        string EntryComments { get; set; }
        DateTime FileProcessingDate { get; set; }
        bool HasMeetingChangedToContested { get; set; }
        string InstitutionId { get; set; }
        int InstructedBy { get; set; }
        DateTime InstructedDate { get; set; }
        bool IsAutoGenerated { get; set; }
        bool IsAutoInstructed { get; set; }
        bool IsCopiedForReporting { get; set; }
        bool IsManuallyEntered { get; set; }
        bool IsPartialVote { get; set; }
        bool IsSplitVote { get; set; }
        bool IsUngroupedBallot { get; set; }
        bool IsZeroSharesChange { get; set; }
        int LastApprovedBy { get; set; }
        int LastModifiedBy { get; set; }
        DateTime LastModifiedDate { get; set; }
        int LatestBallotId { get; set; }
        int LogicalBallotId { get; set; }
        Meeting Meeting { get; set; }
        bool NonStandardVote { get; set; }
        decimal NoOfShares { get; set; }
        decimal PartialVotePercentage { get; set; }
        string Provider { get; set; }
        string ProviderCustodianAccountNumber { get; set; }
        string ProviderIssuerCd { get; set; }
        string ProviderSecurityId { get; set; }
        ICollection<BallotAuditTrail> PxBallotAuditTrail { get; set; }
        ICollection<BallotVotes> PxBallotVotes { get; set; }
        LogicalBallot PxLogicalBallot { get; set; }
        ICollection<Shares> PxShares { get; set; }
        WorkflowNotesBallot PxWorkflowNotesBallot { get; set; }
        string RecommendationFlavorCode { get; set; }
        int SecuritySymbolId { get; set; }
        DateTime SentDate { get; set; }
        string SettlementLocation { get; set; }
        string StatusCode { get; set; }
        DateTime SubCustodianCutOffDate { get; set; }
        DateTime ValidatedDate { get; set; }
        decimal VotedAmount { get; set; }
        DateTime VoteDate { get; set; }
        string VoteStatusCode { get; set; }
    }
}