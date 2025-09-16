using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcNote.Protos;
using HotChocolate.Subscriptions;



namespace GraphQLGateway.Mutation
{
    public class Mutation
    {
        private readonly NoteService.NoteServiceClient _GrpcClient;
        private readonly ITopicEventSender _sender;

        public Mutation(NoteService.NoteServiceClient grpcClient, ITopicEventSender sender)
        {
            _GrpcClient = grpcClient;
            _sender = sender;
        }

        public async Task<GrpcNote.Protos.Void> AddNote(NoteDTO note)
        {
            var result = await _GrpcClient.CreateNoteAsync(note);

            await _sender.SendAsync(nameof(Subscription.Subscription.OnNoteAdded), note);
            return result;
        }

    }
}