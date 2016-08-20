﻿using System;
using System.Collections.Generic;

namespace OflineViewer.Models
{
    internal class Ballot
    {
        public int BallotID { get; set; }
        public string BallotVoteIndicatorCode { get; set; }
        public DateTime? VoteDate { get; set; }
        public string ControlNumberKey { get; set; }
        public string BallotStatusCode { get; set; }
        public int AccountID { get; set; }
        public decimal? NoOfShares { get; set; }
        public string ClassOfStockCode { get; set; }
        public int AgendaID { get; set; }
        public string InstitutionID { get; set; }
        public DateTime FileProcessingDate { get; set; }
        public string AppointeeName { get; set; }
        public string StatusCode { get; set; }
        public string Comments { get; set; }
        public string ProviderSecurityId { get; set; }
        public string ProviderIssuerCd { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? ValidatedDate { get; set; }
        public bool IsManuallyEntered { get; set; }
        public int? BatchControlID { get; set; }
        public int SecuritySymbolID { get; set; }
        public string ProviderCustodianAccountNumber { get; set; }
        public string Provider { get; set; }
        public string DeliveredModeCode { get; set; }
        public string BatchMarker { get; set; }
        public string DeliveryNote { get; set; }
        public bool IsUngroupedBallot { get; set; }
        public string VoteStatusCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string SettlementLocation { get; set; }
        public int? CustodianSubAccountId { get; set; }
        public string EntryComments { get; set; }
        public bool? IsAutoGenerated { get; set; }
        public bool? IsAutoInstructed { get; set; }
        public int? Createdby { get; set; }
        public bool? IsCopiedForReporting { get; set; }
        public DateTime? cutoffdate { get; set; }
        public decimal? BallotSharesOnLoan { get; set; }
        public DateTime? SubCustodianCutOffDate { get; set; }
        public bool HasMeetingChangedToContested { get; set; }
        public int? LatestBallotID { get; set; }
        public int? LastApprovedBy { get; set; }
        public string RecommendationFlavorCode { get; set; }
        public DateTime? InstructedDate { get; set; }
        public int? LogicalBallotID { get; set; }
        public bool? NonStandardVote { get; set; }
        public decimal? AbsoluteAmount { get; set; }
        public decimal? VotedAmount { get; set; }
        public decimal? PartialVotePercentage { get; set; }
        public bool IsPartialVote { get; set; }
        public bool IsSplitVote { get; set; }
        public string BlockingIndicator { get; set; }
        public int? InstructedBy { get; set; }
        public bool IsZeroSharesChange { get; set; }
        public Account Account { get; set; }
        public Agenda Agenda { get; set; }
        public LogicalBallot LogicalBallot { get; set; }
        public WorkflowNotes_Ballot WorkflowNotes_Ballot { get; set; }
        public ICollection<BallotAuditTrail> BallotAuditTrail { get; set; }
        public ICollection<BallotVotes> BallotVotes { get; set; }
        public ICollection<Shares> Shares { get; set; }
    }

    internal class Shares
    {
        public int BallotID { get; set; }
        public int CustomerID { get; set; }
        public int AgendaID { get; set; }
        public int MeetingID { get; set; }
        public int PolicyID { get; set; }
        public int AccountID { get; set; }
        public decimal? BallotSharesOnLoan { get; set; }
        public decimal? HoldingsSharesHeld { get; set; }
        public decimal? HoldingsSharesOnLoan { get; set; }
        public int? SecuritySymbolId { get; set; }
        public int? MeetingSecuritySymbolId { get; set; }
        public long? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }

    internal class BallotVotes
    {
        public int BallotVoteID { get; set; }
        public int BallotID { get; set; }
        public int AgendaItemID { get; set; }
        public string ActualVoteCode { get; set; }
        public string VotingInstructions { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool? VoteAgainstPolicy { get; set; }
        public virtual PX_Ballot PX_Ballot { get; set; }
        public virtual ICollection<PX_BallotSubItemVotes> PX_BallotSubItemVotes { get; set; }
    }

    internal class BallotAuditTrail
    {
        public int BallotAuditTrailID { get; set; }
        public int BallotID { get; set; }
        public string ControlNumberKey { get; set; }
        public string BallotStatusCode { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string VoteStatusCode { get; set; }
        public bool? IsCopiedForReporting { get; set; }
        public decimal? NoOfShares { get; set; }
        public decimal? BallotSharesOnLoan { get; set; }
        public string ProposalVotes { get; set; }
        public string DirectorVotes { get; set; }
        public DateTime? InstructedDate { get; set; }
        public int? LogicalBallotID { get; set; }
        public bool? NonStandardVote { get; set; }
        public int? InstructedBy { get; set; }
    }

    internal class WorkflowNotes_Ballot
    {
        public int BallotID { get; set; }
        public string Note { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public virtual PX_Ballot PX_Ballot { get; set; }
    }

    internal class LogicalBallot
    {
        public int LogicalBallotID { get; set; }
        public int? AgendaID { get; set; }
        public int? GroupID { get; set; }
        public int? PolicyID { get; set; }
        public string LogicalBallotComments { get; set; }
        public int? BallotID { get; set; }
        public int? SumNoOfBallots { get; set; }
        public double? SumNoOfShares { get; set; }
        public string SumVoteStatusCode { get; set; }
        public string SumBallotStatusCode { get; set; }
        public string SumWatchList { get; set; }
        public DateTime? MinVoteDeadlineDate { get; set; }
        public string FirstClassOfStockCode { get; set; }
        public DateTime? LastCreatedDate { get; set; }
        public int? LastApprovedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? InstructedDate { get; set; }
        public int? InstructedBy { get; set; }
        public virtual ICollection<PX_Ballot> PX_Ballot { get; set; }
    }

    internal class Agenda
    {
        public int AgendaID { get; set; }
        public int MeetingID { get; set; }
        public string AgendaKey { get; set; }
        public DateTime? FileProcessingDate { get; set; }
        public string CommitteeCode { get; set; }
        public string StatusCode { get; set; }
        public int? BatchControlId { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool? IsManuallyEntered { get; set; }
        public int AgendaVersion { get; set; }
        public int? RPReportID { get; set; }
        public DateTime? RPPublishDate { get; set; }
        public int FactVersion { get; set; }
        public double FactServicePercentage { get; set; }
        public string OriginalAgendaKey { get; set; }
        public bool? IsCumulativeVoting { get; set; }
        public virtual PX_Meeting PX_Meeting { get; set; }
        public virtual ICollection<PX_AgendaItem> PX_AgendaItem { get; set; }
        public virtual ICollection<PX_Ballot> PX_Ballot { get; set; }
        public virtual ICollection<PX_WorkflowNotes_AgendaPolicy> PX_WorkflowNotes_AgendaPolicy { get; set; }
    }

    internal class Account
    {
        public int CustomerID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountName { get; set; }
        public string ClientName { get; set; }
        public int? VotingGroupId { get; set; }
        public int? ReportingGroupId { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public int? PolicyID { get; set; }
        public string AccountStatusCode { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public string AccountSubStatusCode { get; set; }
        public string AccountTypeCode { get; set; }
        public string AccountVotingTypeCode { get; set; }
        public string BallotTypeCode { get; set; }
        public bool? IsNonVotingAccount { get; set; }
        public int? UploadBatchId { get; set; }
        public bool? IsHoldingSentFlag { get; set; }
        public string HoldingsID { get; set; }
        public string HoldingsSourceCode { get; set; }
        public bool IsSelectedForDisclosure { get; set; }
        public string AccountReconcileTypeCode { get; set; }
        public DateTime? ADPConfirmationDate { get; set; }
        public string AccountNotes { get; set; }
        public bool? IsSelectedForNPX { get; set; }
        public bool? IsHoldingReceived { get; set; }
        public DateTime? HoldingsReceivedDate { get; set; }
        public bool? IsDummy { get; set; }
        public int? IsDummyOfAcctID { get; set; }
        public DateTime? LastHoldingsProcessedDate { get; set; }
        public int? BallotInboxGroupID { get; set; }
        public decimal? PartialVotePercentage { get; set; }
        public DateTime? AccountClosedDate { get; set; }
        public string ReportingRequirement { get; set; }
        public virtual AA_Customer AA_Customer { get; set; }
        public virtual ICollection<AM_SubAccount> AM_SubAccount { get; set; }
        public virtual ICollection<PX_Ballot> PX_Ballot { get; set; }
        public virtual ICollection<PX_GroupAccount> PX_GroupAccount { get; set; }
        public virtual ICollection<PX_WatchListAccounts> PX_WatchListAccounts { get; set; }
    }
}