using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AutoMapper;
using MongoDB.Driver;
using OflineViewer.Models;

namespace OflineViewer
{
    public class Converter
    {
        private int _counter;


        public void Convert()
        {
            AutoMapper.Configure();
            Mapper.AssertConfigurationIsValid();


            var c = new glpEntities();
            var meetingIds = c.PX_Meeting.Select(a => a.MeetingID).OrderByDescending(a => a).ToList();
            var count = meetingIds.Count;
            _counter = 0;
            var list1 = new List<int>();
            var list2 = new List<int>();
            var list3 = new List<int>();
            var list4 = new List<int>();
            foreach (var meetingId in meetingIds.Skip(_counter))
            {
                var rest = meetingId%4;
                switch (rest)
                {
                    case 0:
                        list1.Add(meetingId);
                        break;


                    case 1:
                        list2.Add(meetingId);
                        break;

                    case 2:
                        list3.Add(meetingId);
                        break;

                    case 3:
                        list4.Add(meetingId);
                        break;
                }
            }


            var thread1 = new Thread(() => ProcessData(list1, count, "P1 "));
            var thread2 = new Thread(() => ProcessData(list2, count, "P2 "));
            var thread3 = new Thread(() => ProcessData(list3, count, "P3 "));
            var thread4 = new Thread(() => ProcessData(list4, count, "P4 "));


            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();


            Console.WriteLine("Waiting for tasks");

            Console.ReadLine();
        }

        private void ProcessData(List<int> meetingIds, int count, string p1)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("test2");
            var collection = database.GetCollection<BallotAggregated>("collectionB6");
            foreach (var meetingId in meetingIds)
                //Parallel.ForEach(meetingIds.Skip(counter), meetingId =>
            {
                var context = new glpEntities();
                var pxMeeting = context.PX_Meeting.FirstOrDefault(m => m.MeetingID == meetingId);
                var meeting = Mapper.Map<Meeting>(pxMeeting);
                var list = new List<BallotAggregated>();

                foreach (var agenda in meeting.PxAgenda)
                    foreach (var ballot in agenda.PxBallot)
                        list.Add(GenerateBallotAggregated(ballot, meeting, agenda));


                collection.InsertManyAsync(list);

                var a = Interlocked.Increment(ref _counter);
                Console.WriteLine($"{p1} {a} from {count}  {(decimal) a/(decimal) count}");
                context.Dispose();
                GC.Collect();
                Thread.Sleep(50);
            }
            //  )
            ;
        }

        private BallotAggregated GenerateBallotAggregated(Ballot b, Meeting meeting, Agenda agenda)
        {
            var context = new glpEntities();
            var ballot = context.PX_Ballot.FirstOrDefault(x => x.BallotID == b.BallotId);
            var ba = new BallotAggregated
            {
                Ballot = Mapper.Map<Ballot2>(Mapper.Map<Ballot>(ballot)),
                AgendaAggregated = Mapper.Map<AgendaAggregated>(agenda),
                MeetingAggregated = Mapper.Map<MeetingAggregated>(meeting)
            };

            context.Dispose();

            return ba;
        }
    }
}