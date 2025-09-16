using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcNote.Protos;

namespace GraphQLGateway.Query
{
    public class Query
    {

        private readonly NoteService.NoteServiceClient _GrpcClient;

        public Query(NoteService.NoteServiceClient grpcClient)
        {
            _GrpcClient = grpcClient;
        }

        public IEnumerable<NoteDTO> GetNotes()
        {
            var result = _GrpcClient.GetAllNotes(new GrpcNote.Protos.Void());
            return result.NotesDto;
        }


    }
}