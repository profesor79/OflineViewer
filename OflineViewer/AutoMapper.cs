using AutoMapper;
using OflineViewer.Models;

namespace OflineViewer
{
    public static class AutoMapper
    {
        public static void Configure()
        {
            Mapper.Initialize(x => { x.AddProfile(new ContractToHxDomainMappings()); });
        }
    }

    public class ContractToHxDomainMappings : Profile
    {
        protected override void Configure()
        {
            /*
             * CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.Parts, opts => opts.Ignore())
                .ForMember(dest => dest.CustomerContacts, opts => opts.ResolveUsing<CustomerContactResolver>())
                .ForMember(dest => dest.ShippingMethod, opts => opts.Ignore())
                .ForMember(dest => dest.PurchaseOrders, opts => opts.Ignore())
                .ForMember(dest => dest.BlanketPurchaseOrders, opts => opts.Ignore())
                .ForMember(dest => dest.CustomerBillingAddresses,
                    opts => opts.ResolveUsing<CustomerBillingAddressResolver>())
                .ForMember(dest => dest.CustomerShippingAddresses,
                    opts => opts.ResolveUsing<CustomerShippingAddressResolver>())
                .ForMember(dest => dest.UTCDateUpdated, opts => opts.UseValue(DateTime.UtcNow))
                ;
                */


            CreateMap<AA_Customer, Customer>()
                .ForMember(dest => dest.PL_Policy, opts => opts.MapFrom(x => x.PL_Policy))
                //           .ForMember(dest => dest.PX_VoteExecutionProfile, opts => opts.MapFrom(x => x.PX_VoteExecutionProfile))
                //         .ForMember(dest => dest.PX_VotingInstructions, opts => opts.MapFrom(x => x.PX_VotingInstructions))
                ;

            CreateMap<AA_Security, Security>()
                .ForMember(dest => dest.EdiIssId, opts => opts.MapFrom(x => x.EDI_IssID))
                .ForMember(dest => dest.AaSecuritySymbol, opts => opts.MapFrom(x => x.AA_SecuritySymbol))
                .ForMember(dest => dest.PxWatchListSecurity, opts => opts.MapFrom(x => x.PX_WatchListSecurity))
                ;


            CreateMap<AA_SecuritySymbol, SecuritySymbol>()
                .ForMember(dest => dest.EdiIssId, opts => opts.MapFrom(x => x.EDI_IssID))
                .ForMember(dest => dest.EdiSecId, opts => opts.MapFrom(x => x.EDI_SecID))
                .ForMember(dest => dest.EdiSedolId, opts => opts.MapFrom(x => x.EDI_SedolID))
                ;
            CreateMap<AM_SubAccount, SubAccount>();

            CreateMap<AM_Account, Account>()
                .ForMember(dest => dest.AA_Customer, opts => opts.MapFrom(x => x.AA_Customer))
                ;


            CreateMap<PL_Policy, Policy>();

            CreateMap<PX_Agenda, Agenda>()
                .ForMember(dest => dest.PxAgendaItem, opts => opts.MapFrom(x => x.PX_AgendaItem))
                .ForMember(dest => dest.PxBallot, opts => opts.MapFrom(x => x.PX_Ballot))
                ;


            CreateMap<PX_AgendaItem, AgendaItem>()
                .ForMember(dest => dest.PxAgendaSubItem, opts => opts.MapFrom(x => x.PX_AgendaSubItem))
                .ForMember(dest => dest.PxProposalRecommendations,
                    opts => opts.MapFrom(x => x.PX_ProposalRecommendations))
                ;

            CreateMap<PX_AgendaSubItem, AgendaSubItem>()
                .ForMember(dest => dest.PxAgendaSubItemRecommendations,
                    opts => opts.MapFrom(x => x.PX_AgendaSubItemRecommendations))
                ;


            CreateMap<PX_AgendaSubItemRecommendations, AgendaSubItemRecommendations>();

            CreateMap<PX_Ballot, Ballot>()
                //ForMember(dest => dest.Meeting, opts => opts.Ignore())
                .ForMember(dest => dest.AmAccount, opts => opts.MapFrom(x => x.AM_Account))
                .ForMember(dest => dest.PxShares, opts => opts.MapFrom(x => x.PX_Shares))
                .ForMember(dest => dest.PxLogicalBallot, opts => opts.MapFrom(x => x.PX_LogicalBallot))
                .ForMember(dest => dest.PxBallotAuditTrail, opts => opts.MapFrom(x => x.PX_BallotAuditTrail))
                .ForMember(dest => dest.PxBallotVotes, opts => opts.MapFrom(x => x.PX_BallotVotes))
                .ForMember(dest => dest.PxWorkflowNotesBallot, opts => opts.MapFrom(x => x.PX_WorkflowNotes_Ballot))
                ;


            CreateMap<PX_BallotAuditTrail, BallotAuditTrail>();


            CreateMap<PX_BallotVotes, BallotVotes>()
                .ForMember(dest => dest.PxBallotSubItemVotes, opts => opts.MapFrom(x => x.PX_BallotSubItemVotes))
                ;

            CreateMap<PX_BallotSubItemVotes, BallotSubItemVotes>()
                ;

            CreateMap<PX_LogicalBallot, LogicalBallot>();

            CreateMap<PX_Meeting, Meeting>()
                .ForMember(dest => dest.PxAgenda, opts => opts.MapFrom(x => x.PX_Agenda))
                .ForMember(dest => dest.AaSecurity, opts => opts.MapFrom(x => x.AA_Security))
                ;


            CreateMap<PX_ProposalRecommendations, ProposalRecommendations>();

            CreateMap<PX_Shares, Shares>();

            CreateMap<PX_WorkflowNotes_Ballot, WorkflowNotesBallot>();

            CreateMap<PX_WatchList, WatchList>();
            CreateMap<PX_WatchListSecurity, WatchListSecurity>()
                .ForMember(dest => dest.PxWatchListSecurityId, opts => opts.MapFrom(x => x.PX_WatchListSecurityID))
                .ForMember(dest => dest.PxWatchList, opts => opts.Ignore())
                ;


            //CreateMap<>();
            CreateMap<Ballot, Ballot2>();
            CreateMap<Meeting, MeetingAggregated>();
            CreateMap<Agenda, AgendaAggregated>();
        }
    }
}