using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ModelConverter.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using OflineViewer.Models;

namespace ModelConverter
{
    public class Transformer
    {
        public async void Transform()
        {
            AutoMapper.Configure();
            Mapper.AssertConfigurationIsValid();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test2");
            var sourceCollection = database.GetCollection<BallotAggregated>("collectionB6");

            var client2 = new MongoClient("mongodb://localhost:27018");
            var database2 = client2.GetDatabase("test2");
            var destCollection = database2.GetCollection<BallotTransformed>("collectionB6");

            //var count = sourceCollection.Select(a => a._id).Count();


            var filter = new BsonDocument();

            using (var cursor = await sourceCollection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    var bag = new ConcurrentBag<BallotTransformed>();


                    // process document

                    Parallel.ForEach(batch, doc =>

                    {
                        Console.Write(".");
                        var newShape = Mapper.Map<BallotTransformed>(doc);
                        newShape.PxAgendaSubItemRecommendations = new List<AgendaSubItemRecommendations>();
                        newShape.PxAgendaSubItem = new List<AgendaSubItemLocal>();
                        newShape.PxProposalRecommendations = new List<ProposalRecommendations>();

                        foreach (var agendaItem in doc.AgendaAggregated.PxAgendaItem)
                        {
                            foreach (var agendaSubItem in agendaItem.PxAgendaSubItem)
                                newShape.PxAgendaSubItemRecommendations.Concat(
                                    agendaSubItem.PxAgendaSubItemRecommendations);

                            newShape.PxAgendaSubItem.Concat(
                                Mapper.Map<List<AgendaSubItemLocal>>(agendaItem.PxAgendaSubItem));
                            newShape.PxProposalRecommendations.Concat(agendaItem.PxProposalRecommendations);
                        }


                        newShape.PxBallotSubItemVotes = new List<BallotSubItemVotes>();
                        foreach (var vote in doc.Ballot.PxBallotVotes)
                            if (vote.PxBallotSubItemVotes.Any())
                                newShape.PxBallotSubItemVotes.Concat(vote.PxBallotSubItemVotes);

                        bag.Add(newShape);
                    });

                    destCollection.InsertManyAsync(bag.ToList());
                }
            }
        }
    }
}