﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OflineViewer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class glpEntities : DbContext
    {
        public glpEntities()
            : base("name=glpEntities")
        {
    	 ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 15;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AA_Customer> AA_Customer { get; set; }
        public DbSet<AA_Customer_ProposalProvider> AA_Customer_ProposalProvider { get; set; }
        public DbSet<AA_CustomerProduct> AA_CustomerProduct { get; set; }
        public DbSet<AA_IssueCode> AA_IssueCode { get; set; }
        public DbSet<AA_IssueCodeDD> AA_IssueCodeDD { get; set; }
        public DbSet<AA_Security> AA_Security { get; set; }
        public DbSet<AA_SecuritySymbol> AA_SecuritySymbol { get; set; }
        public DbSet<AM_Account> AM_Account { get; set; }
        public DbSet<AM_AccountGroup> AM_AccountGroup { get; set; }
        public DbSet<AM_AccountHoldings> AM_AccountHoldings { get; set; }
        public DbSet<AM_CustodianSubAccount> AM_CustodianSubAccount { get; set; }
        public DbSet<AM_SubAccount> AM_SubAccount { get; set; }
        public DbSet<PL_Policy> PL_Policy { get; set; }
        public DbSet<PL_PolicyIssue> PL_PolicyIssue { get; set; }
        public DbSet<PL_PolicyIssueRules> PL_PolicyIssueRules { get; set; }
        public DbSet<PX_Agenda> PX_Agenda { get; set; }
        public DbSet<PX_AgendaItem> PX_AgendaItem { get; set; }
        public DbSet<PX_AgendaSubItem> PX_AgendaSubItem { get; set; }
        public DbSet<PX_AgendaSubItemRecommendations> PX_AgendaSubItemRecommendations { get; set; }
        public DbSet<PX_Ballot> PX_Ballot { get; set; }
        public DbSet<PX_BallotAuditTrail> PX_BallotAuditTrail { get; set; }
        public DbSet<PX_BallotSubItemVotes> PX_BallotSubItemVotes { get; set; }
        public DbSet<PX_BallotVotes> PX_BallotVotes { get; set; }
        public DbSet<PX_Group> PX_Group { get; set; }
        public DbSet<PX_GroupAccount> PX_GroupAccount { get; set; }
        public DbSet<PX_IssuerNotes> PX_IssuerNotes { get; set; }
        public DbSet<PX_LogicalBallot> PX_LogicalBallot { get; set; }
        public DbSet<PX_Meeting> PX_Meeting { get; set; }
        public DbSet<PX_MissingBallot> PX_MissingBallot { get; set; }
        public DbSet<PX_MissingBallotNote> PX_MissingBallotNote { get; set; }
        public DbSet<PX_ProposalRecommendations> PX_ProposalRecommendations { get; set; }
        public DbSet<PX_ProposalRecommendationsProviders> PX_ProposalRecommendationsProviders { get; set; }
        public DbSet<PX_SubCustodianCutoffDate> PX_SubCustodianCutoffDate { get; set; }
        public DbSet<PX_VoteExecutionNonVotingMarkets> PX_VoteExecutionNonVotingMarkets { get; set; }
        public DbSet<PX_VoteExecutionProfile> PX_VoteExecutionProfile { get; set; }
        public DbSet<PX_VoteExecutionVotingMarketException> PX_VoteExecutionVotingMarketException { get; set; }
        public DbSet<PX_VotingInstructions> PX_VotingInstructions { get; set; }
        public DbSet<PX_WatchList> PX_WatchList { get; set; }
        public DbSet<PX_WatchListAccounts> PX_WatchListAccounts { get; set; }
        public DbSet<PX_WatchListSecurity> PX_WatchListSecurity { get; set; }
        public DbSet<PX_WatchListUser> PX_WatchListUser { get; set; }
        public DbSet<PX_WorkflowNotes_AgendaPolicy> PX_WorkflowNotes_AgendaPolicy { get; set; }
        public DbSet<PX_WorkflowNotes_Ballot> PX_WorkflowNotes_Ballot { get; set; }
        public DbSet<PX_WorkflowNotes_Meeting> PX_WorkflowNotes_Meeting { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<PX_Shares> PX_Shares { get; set; }
    }
}
