using AutoMapper;
using ModelConverter.Models;
using OflineViewer.Models;

namespace ModelConverter
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


            //CreateMap<>();
            CreateMap<Account, AccountLocal>();
            CreateMap<AgendaAggregated, AgendaLocal>();
            CreateMap<AgendaItem, AgendaItemLocal>();
            CreateMap<AgendaSubItem, AgendaSubItemLocal>();
            CreateMap<Ballot2, BallotLocal>();
            CreateMap<BallotVotes, BallotVotesLocal>();
            CreateMap<MeetingAggregated, MeetingLocal>();

            CreateMap<BallotAggregated, BallotTransformed>()
                .ForMember(dest => dest.Ballot, opts => opts.MapFrom(a => a.Ballot))
                .ForMember(dest => dest.PxWorkflowNotesBallot, opts => opts.MapFrom(a => a.Ballot.PxWorkflowNotesBallot))
                .ForMember(dest => dest.PxBallotAuditTrail, opts => opts.MapFrom(a => a.Ballot.PxBallotAuditTrail))
                .ForMember(dest => dest.PxBallotVotes, opts => opts.MapFrom(a => a.Ballot.PxBallotVotes))
                .ForMember(dest => dest.PxShares, opts => opts.MapFrom(a => a.Ballot.PxShares))
                .ForMember(dest => dest.AmAccount, opts => opts.MapFrom(a => a.Ballot.AmAccount))
                .ForMember(dest => dest.AA_Customer, opts => opts.MapFrom(a => a.Ballot.AmAccount.AA_Customer))
                .ForMember(dest => dest.PxLogicalBallot, opts => opts.MapFrom(a => a.Ballot.PxLogicalBallot))
                .ForMember(dest => dest.AaSecurity, opts => opts.MapFrom(a => a.MeetingAggregated.AaSecurity))
                .ForMember(dest => dest.PxAgendaItem, opts => opts.MapFrom(a => a.AgendaAggregated.PxAgendaItem))
                .ForMember(dest => dest.Meeting, opts => opts.MapFrom(a => a.MeetingAggregated))
                .ForMember(dest => dest.Agenda, opts => opts.MapFrom(a => a.AgendaAggregated))
                // chec 
                .ForMember(dest => dest.PxAgendaSubItemRecommendations, opts => opts.Ignore())
                .ForMember(dest => dest.PxBallotSubItemVotes, opts => opts.Ignore())
                .ForMember(dest => dest.PxAgendaSubItem, opts => opts.Ignore())
                .ForMember(dest => dest.PxProposalRecommendations, opts => opts.Ignore())
                ;
        }
    }
}